using System;
using Recoverable;

namespace ex
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Patient p = new Patient();				
			Furniture f = new Furniture();				
			Football football = new Football();				
			
			p.Recover();
			f.Recover();
			football.Recover();
		}
	}
}

