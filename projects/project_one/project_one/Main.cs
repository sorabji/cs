using System;
using System.Collections.Generic;
using Books;

namespace project_one
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*Book[] books = BookHandling.ReadBooksFromFile();
			foreach (Book book in books) {
				Console.Write(book);
			}
			*/
			
			/*List<Book> booksList = BookHandling.ReadBooksFromFile2();
			foreach (Book item in booksList) {
				Console.Write(item);	
			}
			
			BookHandling.WriteToFile(booksList);
			*/
			List<Book> booksList = BookHandling.ReadFromSerializedFile();
			foreach (Book item in booksList) {
				Console.Write(item);	
			}
			
		}
	}
}

