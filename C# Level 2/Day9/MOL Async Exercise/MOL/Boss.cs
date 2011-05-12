using System;

namespace MOL
{
	/// <summary>
	/// Summary description for ComputerSeer.
	/// </summary>
	class Boss 
	{
		public int WorkCompleted() 
		{
			System.Threading.Thread.Sleep(3000);
			Console.WriteLine("Better..."); 
			return 6; 
		}
	}
}
