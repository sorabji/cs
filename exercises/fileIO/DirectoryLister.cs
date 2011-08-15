using System;
using System.IO;

class DirectoryLister{
    static String[] getContents(String path)
    {
        String[] results = null;
        Console.WriteLine("Searching in "+path);
        if(Directory.Exists(path))
        {
            foreach(String files in Directory.GetFiles(path))
            {
                Console.WriteLine(files);
            }

            if(Directory.GetDirectories(path) != null)
            {
                foreach(String subPath in Directory.GetDirectories(path))
                {
                    Console.WriteLine(subPath);
                    results = getContents(subPath);
                }
            }
            else
            {
                Console.WriteLine("Trying to get files");
                results = Directory.GetFiles(path);
            }
        }
        return results;
    }
    public static void Main (String [] args)
    {
        getContents("/home/laptop/documents/");
    }
}
