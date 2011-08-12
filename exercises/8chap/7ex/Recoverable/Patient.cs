using System;
namespace Recoverable
{
	public class Patient : IRecoverable
	{
		public Patient ()
		{
		}
		public void Recover ()
		{
			Console.WriteLine("I am getting better");
		}
	}
}

