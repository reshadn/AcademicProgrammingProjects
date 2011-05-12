using System;

namespace MOL
{
	

	public class Worker
	{
		public event WorkStarted started;
		public event WorkProgressing progressing;
		public event WorkCompleted completed;

		public void DoWork() 
		{
			Console.WriteLine("Worker: work started");
			if( started != null ) started();

			Console.WriteLine("Worker: work progressing");
			if( progressing != null ) progressing();

			Console.WriteLine("Worker: work completed");
			if( completed != null ) 
			{
				foreach( WorkCompleted wc in completed.GetInvocationList() ) 
				{
					wc.BeginInvoke(new AsyncCallback(WorkGraded), wc);
				}
			}
		}

		void WorkGraded(IAsyncResult res) 
		{
			WorkCompleted wc = (WorkCompleted)res.AsyncState;
			int grade = wc.EndInvoke(res);
			Console.WriteLine("Worker grade= " + grade);
		}
	}
}
