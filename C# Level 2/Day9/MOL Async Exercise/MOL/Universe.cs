using System;

namespace MOL
{
	public delegate void WorkStarted();
	public delegate void WorkProgressing();
	public delegate int WorkCompleted();

	class Universe 
	{
		static void WorkerStartedWork() 
		{
			Console.WriteLine("Universe notices worker starting work");
		}

		static int WorkerCompletedWork() 
		{
			System.Threading.Thread.Sleep(4000);
			Console.WriteLine("Universe is pleased with worker's work");
			return 42;
		}

		static void Main() 
		{
			Worker peter = new Worker();
			Boss boss = new Boss();
			peter.completed += new WorkCompleted(boss.WorkCompleted);
			peter.started += new WorkStarted(Universe.WorkerStartedWork);
			peter.completed += new WorkCompleted(Universe.WorkerCompletedWork);
			peter.DoWork();

			Console.WriteLine("Main: worker completed work");
			Console.ReadLine();
		}
	}
}
