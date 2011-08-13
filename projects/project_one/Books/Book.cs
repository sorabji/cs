using System;
namespace Books
{
	public class Book
	{
		private string title,author,isbn;
		private double price;
		
		public Book (string title, string author, string isbn, double price)
		{
			this.title = title;
			this.author = author;
			this.isbn = isbn;
			this.price = price;
		}

		public string Title {
			get {
				return this.title;
			}
			set {
				title = value;
			}
		}

		public string Author {
			get {
				return this.author;
			}
			set {
				author = value;
			}
		}

		public string Isbn {
			get {
				return this.isbn;
			}
			set {
				isbn = value;
			}
		}

		public double Price {
			get {
				return this.price;
			}
			set {
				price = value;
			}
		}
		
		public override string ToString ()
		{
			return string.Format ("[Book: title={0}\nauthor={1}\nisbn={2}\nprice={3}]\n\n", 
			                      title, author, isbn, price);
		}

	}
}

