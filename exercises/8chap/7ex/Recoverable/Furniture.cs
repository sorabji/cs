using System;
namespace Recoverable
{
	public class Furniture : IRecoverable
	{
		public Furniture ()
		{
		}
		public void Recover ()
		{
			Console.WriteLine("furniture...i really don't get this one");
		}
	}
}

