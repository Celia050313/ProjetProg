
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerSimulation{
    public class ThreadPool {

        public ThreadPool() {
        }

        private static List<Task> AllThreads = new List<Task>();

        public static void AddTask(Task task)
        {
            AllThreads.Add(task);
        }

        public static void WaitCompletion()
        {
            Task[] tasks = AllThreads.ToArray();
            Task.WaitAll(tasks);
            AllThreads.Clear();
        }


        public void pool() {
            // TODO implement here
        }

    }
}