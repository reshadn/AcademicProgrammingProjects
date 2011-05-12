using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MOL
{
    class Universe
    {
        static void WorkerStartedWork()
        {
            Console.WriteLine("Universe notices worker started work");
        }

        static int WorkerCompletedWork()
        {
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Universe: Work ended, universe" +
                " is pleased with worker's work");
            return 42;
        }

        public static void InTheBeginning()
        {
            Worker peter = new Worker();
            Boss boss = new Boss();
            peter.completed += new WorkCompleted(boss.WorkCompleted);
            peter.started += new WorkStarted(Universe.WorkerStartedWork);
            peter.completed += new WorkCompleted(Universe.WorkerCompletedWork);
            peter.DoWork();

            Console.WriteLine("From Universe Beginning: worker completed work");
        }
    }
}
