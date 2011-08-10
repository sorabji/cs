using System;
namespace ex
{
	public class Order
	{
		const double PRICE = 19.95;
		int orderNum,qty;
		string custName;
		double totalPrice;
		
		public Order (int orderNum, int qty, string custName)
		{
			this.OrderNum = orderNum;
			this.Qty = qty;
			this.CustName = custName;
		}
		
		public int OrderNum {
			get {
				return this.orderNum;
			}
			set {
				orderNum = value;
			}
		}

		public int Qty {
			get {
				return this.qty;
			}
			set {
				qty = value;
				totalPrice = qty*PRICE;
			}
		}

		public string CustName {
			get {
				return this.custName;
			}
			set {
				custName = value;
			}
		}
		
		public double TotalPrice {
			get {
				return this.totalPrice;
			}
		}
		
		public override bool Equals (object obj)
		{
			if (obj == null)
				return false;
			if (ReferenceEquals (this, obj))
				return true;
			if (obj.GetType () != typeof(Order))
				return false;
			ex.Order other = (ex.Order)obj;
			return orderNum == other.orderNum;
		}


		public override int GetHashCode ()
		{
			unchecked {
				return orderNum;
			}
		}
		
		public override string ToString ()
		{
			return string.Format ("[Order: PRICE={0}, orderNum={1}, qty={2}, custName={3}, totalPrice={4}]",
			                      PRICE, orderNum, qty, custName, totalPrice);
		}



	}
}

