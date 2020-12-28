 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class Stopwatch
    {
        private DateTime startTime;
        private DateTime endTime;
        private bool isRunning = false;

        // class method to start 
        public void Start ()
        {
            if (isRunning)
            {
                // gives the exception if code is running already
                throw new InvalidOperationException("Stop watch is already running");
            }
            else
            {
                startTime = DateTime.Now;
                isRunning = true;
  
            }
        }

        public void Stop()
        {
            if(isRunning)
            {
                endTime = DateTime.Now;
                isRunning = false;
            }

        }

        public TimeSpan GetInterval()
        {
            return endTime - startTime;
         
        }
    }
}
