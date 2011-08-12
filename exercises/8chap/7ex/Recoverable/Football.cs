using System;
namespace Recoverable
{
	public class Football : IRecoverable
	{
		public Football ()
		{
		}
		public void Recover ()
		{
			Console.WriteLine("i recovered the football?");
		}
	}
}

