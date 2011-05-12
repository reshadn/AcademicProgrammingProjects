using System;
using System.Threading;

namespace ThreadSafety
{
	class UseThreads
	{
		static Counter counter = null;
		static int totalNumberOfAsyncOps = 10;
		static int numAsyncOps = totalNumberOfAsyncOps;
		static AutoResetEvent asyncOpsAreDone = new AutoResetEvent(false);

		public static void Main() 
		{
			Console.WriteLine("\n\nUnsafe test:");
			asyncOpsAreDone.Reset();
			numAsyncOps = totalNumberOfAsyncOps;
			counter = new CounterUnsafe();
			for (int threadNum = 0; threadNum < numAsyncOps; threadNum++) 
			{
				ThreadPool.QueueUserWorkItem(new WaitCallback(UpdateResource), threadNum);
			}
			asyncOpsAreDone.WaitOne();
			Console.WriteLine("All Unsafe threads have completed.");

			Console.WriteLine("\n\nLock test:");
			asyncOpsAreDone.Reset();
			numAsyncOps = totalNumberOfAsyncOps;
			counter = new CounterUsingLock();
			for (int threadNum = 0; threadNum < numAsyncOps; threadNum++) 
			{
				ThreadPool.QueueUserWorkItem(new WaitCallback(UpdateResource), threadNum);
			}
			asyncOpsAreDone.WaitOne();
			Console.WriteLine("All Lock threads have completed.");
		}

		static void UpdateResource(Object state) 
		{
			int threadNum = (int) state;

			if ((threadNum % 2) != 0)
				counter.Read(threadNum);
			else
				counter.Increment(threadNum);

			if (( Interlocked.Decrement(ref numAsyncOps)) == 0)
				asyncOpsAreDone.Set();
		}
	}
}
