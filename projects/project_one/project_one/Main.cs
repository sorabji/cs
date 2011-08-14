using System;
using Books;

namespace project_one
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Book[] books = BookHandling.ReadBooksFromFile();
			foreach (Book book in books) {
				Console.Write(book);
			}
			
		}
	}
}

