using System;

namespace ex
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//OrderDemo1();
			OrderDemo2();
			
		}
		
		public static void OrderDemo1()
		{
			Order[] orders = new Order[10];
			orders[0] = new Order(1,4,"billy joseph");
			orders[1] = new Order(1,6,"claude debussy");
			orders[2] = new Order(2,4,"bill clinton");
			orders[3] = new Order(3,4,"john smith");
			orders[4] = new Order(4,4,"barack obama");
			orders[5] = new Order(5,4,"george bush");
			orders[6] = new Order(6,4,"ronald reagan");
			orders[7] = new Order(7,4,"timothy geitner");
			orders[8] = new Order(8,4,"newt gingrich");
			orders[9] = new Order(9,4,"franz liszt");
			
			foreach (Order item in orders)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("checking equality...");
			
			for (int i=0; i < orders.Length-1; i++)
			{
				CheckIfEqual(orders[i],orders[i+1]);
			}
		}
		
		public static void CheckIfEqual(Order a,Order b)
		{
			if (a.Equals(b))
			{
				Console.WriteLine("the two objects are equal");
			} else 
			{
				Console.WriteLine("NOT EQUAL");
			}
		}
		
		public static void OrderDemo2()
		{
			Order[] orders = new Order[5];
			int orderNum, qty;
			string name;
			for (int i=0; i < orders.Length; i++)
			{
				GetOrderNumInput(out orderNum);		
				if (orders.Length != 0)
				{
					foreach (Order item in orders)
					{
						if (item != null && orderNum == item.OrderNum)
						{
							Console.WriteLine("error, order w/ that number already exists");
							GetOrderNumInput(out orderNum);
						}
					}
				}
				
				Console.WriteLine("enter the quantity ordered");
				while (!Int32.TryParse(Console.ReadLine(),out qty))
				{
					Console.WriteLine("Error!\nenter the quantity ordered");
				}
				
				Console.WriteLine("enter the name of the customer");
				name = Console.ReadLine();
				
				orders[i] = new Order(orderNum,qty,name);
			}
			double totalOrderCharges = 0;
			foreach (Order item in orders)
			{
				Console.WriteLine(item);
				totalOrderCharges += item.TotalPrice;
			}
			Console.WriteLine("total accumulated charges is: {0}",totalOrderCharges.ToString("C"));
		}
		
		public static void GetOrderNumInput(out int orderNum)
		{
			Console.WriteLine("Please enter the order number");
			while (!Int32.TryParse(Console.ReadLine(),out orderNum))
			{
				Console.WriteLine("Error!\nPlease enter the order number");
			}
		}
	}
}

