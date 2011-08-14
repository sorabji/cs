using System;
namespace Books
{
	public class Book
	{
		private string title,author,isbn;
		private double listPrice,retailPrice;
		
		public Book (string title, string author, string isbn, double listPrice,double retailPrice)
		{
			this.title = title;
			this.author = author;
			this.isbn = isbn;
			this.listPrice = listPrice;
			this.retailPrice = retailPrice;
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

		public double ListPrice {
			get {
				return this.listPrice;
			}
			set {
				listPrice = value;
			}
		}
		
		public double RetailPrice {
			get {
				return this.retailPrice;
			}
			set {
				retailPrice = value;
			}
		}
		
		public override string ToString ()
		{
			return string.Format ("[Book: title={0}\nauthor={1}\nisbn={2}\nlistPrice={3}]\nretailPrice={4}\n\n", 
			                      title, author, isbn, listPrice.ToString("C"),retailPrice.ToString("C"));
		}
		

	}
}

