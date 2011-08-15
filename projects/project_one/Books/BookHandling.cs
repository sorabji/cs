using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace Books
{
	[Serializable]
	public class BookHandling
	{
		private static string filename = "books.data";
		private static char[] delim = {'|'};
		
		public static Book[] ReadBooksFromFile ()
		{
			string title, author, isbn;
			string[] tokens;
			double listPrice,retailPrice;
			
			//string path = System.Environment.CurrentDirectory;
			/*string[] lines = System.IO.File.ReadAllLines (System.IO.Path.Combine (path, filename));
			Book[] b = new Book[lines.Length];
			for (int i = 0; i < lines.Length; i++) {
				tokens = lines[i].Split (delim);
				isbn = tokens[0];
				title = tokens[1];
				author = tokens[2];
				if (!Double.TryParse ((tokens[3]), out listPrice))
				{
					Console.WriteLine ("double parsing error on line: {0}", (i + 1));
				}
				if (!Double.TryParse ((tokens[4]), out retailPrice))
				{
					Console.WriteLine ("double parsing error on line: {0}", (i + 1));
				}
				b[i] = new Book(title,author,isbn,listPrice,retailPrice);
			}
			*/
			Book[] b = new Book[4050];
			FileStream bookStream = new FileStream(filename,FileMode.Open,FileAccess.Read);
			StreamReader reader = new StreamReader(bookStream);
			String line = "";
			int i = 0;
			while((line=reader.ReadLine()) !=null)
			{
				tokens = line.Split(delim);
				isbn = tokens[0];
				title = tokens[1];
				author = tokens[2];
				if (!Double.TryParse ((tokens[3]), out listPrice))
				{
					Console.WriteLine ("double parsing error on "+line);
				}
				if (!Double.TryParse ((tokens[4]), out retailPrice))
				{
					Console.WriteLine ("double parsing error on "+line);
				}
				b[i] = new Book(title,author,isbn,listPrice,retailPrice);
				i++;
			}
			reader.Close();
			bookStream.Close();
			return b;
		}
		
		public static List<Book> ReadBooksFromFile2 ()
		{
			string title, author, isbn;
			string[] tokens;
			double listPrice,retailPrice;
			
			//string path = System.Environment.CurrentDirectory;
			/*string[] lines = System.IO.File.ReadAllLines (System.IO.Path.Combine (path, filename));
			Book[] b = new Book[lines.Length];
			for (int i = 0; i < lines.Length; i++) {
				tokens = lines[i].Split (delim);
				isbn = tokens[0];
				title = tokens[1];
				author = tokens[2];
				if (!Double.TryParse ((tokens[3]), out listPrice))
				{
					Console.WriteLine ("double parsing error on line: {0}", (i + 1));
				}
				if (!Double.TryParse ((tokens[4]), out retailPrice))
				{
					Console.WriteLine ("double parsing error on line: {0}", (i + 1));
				}
				b[i] = new Book(title,author,isbn,listPrice,retailPrice);
			}
			*/
			List<Book> b = new List<Book>();
			FileStream bookStream = new FileStream(filename,FileMode.Open,FileAccess.Read);
			StreamReader reader = new StreamReader(bookStream);
			String line = "";
			while((line=reader.ReadLine()) !=null)
			{
				tokens = line.Split(delim);
				isbn = tokens[0];
				title = tokens[1];
				author = tokens[2];
				if (!Double.TryParse ((tokens[3]), out listPrice))
				{
					Console.WriteLine ("double parsing error on "+line);
				}
				if (!Double.TryParse ((tokens[4]), out retailPrice))
				{
					Console.WriteLine ("double parsing error on "+line);
				}
				b.Add(new Book(title,author,isbn,listPrice,retailPrice));
			}
			reader.Close();
			bookStream.Close();
			return b;
		}
		public static void WriteToFile(List<Book> bookList)
		{
			FileStream bookStream = new FileStream("books.ser",FileMode.OpenOrCreate,FileAccess.Write);
			BinaryFormatter bFormatter = new BinaryFormatter();
			bFormatter.Serialize(bookStream,bookList);
			bookStream.Close();
		}
		
		public static List<Book> ReadFromSerializedFile()
		{
			FileStream bookStream = new FileStream("books.ser",FileMode.Open,FileAccess.Read);
			BinaryFormatter bFormatter = new BinaryFormatter();
			return (List<Book>)bFormatter.Deserialize(bookStream);
		}
		
	}
}

