using System;
namespace Customers
{
	public class Customer
	{
		private int id;
		private string fName,lName,address,city,state,zip,phone,
			email,ccType,ccNumber,ccExpDate;
		
		public Customer (int id, string fName, string lName, 
		                 string address, string city, string state, 
		                 string zip, string phone, string email, string ccType,
		                 string ccNumber, string ccExpDate)
		{
			this.id = id;
			this.fName = fName;
			this.lName = lName;
			this.address = address;
			this.city = city;
			this.state = state;
			this.zip = zip;
			this.phone = phone;
			this.email = email;
			this.ccType = ccType;
			this.ccNumber = ccNumber;
			this.ccExpDate = ccExpDate;
		}
		
		public int Id {
			get {
				return this.id;
			}
			set {
				id = value;
			}
		}

		public string FName {
			get {
				return this.fName;
			}
			set {
				fName = value;
			}
		}

		public string LName {
			get {
				return this.lName;
			}
			set {
				lName = value;
			}
		}

		public string Address {
			get {
				return this.address;
			}
			set {
				address = value;
			}
		}

		public string City {
			get {
				return this.city;
			}
			set {
				city = value;
			}
		}

		public string State {
			get {
				return this.state;
			}
			set {
				state = value;
			}
		}

		public string Zip {
			get {
				return this.zip;
			}
			set {
				zip = value;
			}
		}

		public string Phone {
			get {
				return this.phone;
			}
			set {
				phone = value;
			}
		}

		public string Email {
			get {
				return this.email;
			}
			set {
				email = value;
			}
		}

		public string CcType {
			get {
				return this.ccType;
			}
			set {
				ccType = value;
			}
		}

		public string CcNumber {
			get {
				return this.ccNumber;
			}
			set {
				ccNumber = value;
			}
		}

		public string CcExpDate {
			get {
				return this.ccExpDate;
			}
			set {
				ccExpDate = value;
			}
		}

	}
}

