
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;

namespace ControllerSimulation{
    public class ThreadComm : Idisposable {

        public ThreadComm() {
        }

        private bool disposed;

        public Component component;


        public static bool QueueUserWorkItem(WaitCallback callBack, object state)

        public void threadStart() {
       
            ThreadPool.QueueUserWorkItem();
            // TODO implement here
        }

        public void dispose() {
            // TODO implement here
        }

        public void finalize() {
            // TODO implement here
        }

        public void traitementThread() {
            // TODO implement here
        }

        public void ThreadComm() {
            // TODO implement here
        }

        /// <summary>
        /// @return
        /// </summary>
        public Singleton getInstance() {
            // TODO implement here
            return null;
        }

    }
}