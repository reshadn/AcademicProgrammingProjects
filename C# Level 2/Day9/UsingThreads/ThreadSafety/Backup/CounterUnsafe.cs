using System;
using System.Threading;

namespace ThreadSafety
{
	class CounterUnsafe : Counter
	{
		public override int Read(int threadNum) 
		{	
			try 
			{
				Console.WriteLine(
					"Start Resource reading (Thread={0})count: {1}", threadNum, count);
				Thread.Sleep(250);
				Console.WriteLine(
					"Stop  Resource reading (Thread={0}) count: {1}", threadNum, count);
				return count;
			}
			finally 
			{
			}
		}

		public override void Increment(int threadNum) 
		{
			try 
			{
				Console.WriteLine(
					"Start Resource writing (Thread={0}) count: {1}", threadNum, count);
			
				int tempCount = count;
				Thread.Sleep(1000);
				tempCount++;
				count = tempCount;
				Console.WriteLine(
					"Stop  Resource writing (Thread={0}) count: {1}", threadNum, count);
			}
			finally 
			{
			}
		}
	}
}
