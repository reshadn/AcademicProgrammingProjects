using System;
using System.Threading;

namespace ThreadSafety
{
	abstract class Counter
	{
		protected int count = 0;

		public abstract int Read(int threadNum);
		public abstract void Increment(int threadNum); 
	}
}
