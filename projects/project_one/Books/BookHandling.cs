using System;
namespace Books
{
	public class BookHandling
	{
		private static string filename = "books.data";
		private static char[] delim = {'|'};
		
		public static Book[] ReadBooksFromFile ()
		{
			string title, author, isbn;
			string[] tokens;
			double price;
			
			string path = System.Environment.CurrentDirectory;
			string[] lines = System.IO.File.ReadAllLines (System.IO.Path.Combine (path, filename));
			Book[] b = new Book[lines.Length];
			for (int i = 0; i < lines.Length; i++) {
				tokens = lines[i].Split (delim);
				isbn = tokens[0];
				title = tokens[1];
				author = tokens[2];
				if (!Double.TryParse ((tokens[3]), out price))
				{
					Console.WriteLine ("double parsing error on line: {0}", (i + 1));
				}
				b[i] = new Book(title,author,isbn,price);
			}
			return b;
		}
	}
}

