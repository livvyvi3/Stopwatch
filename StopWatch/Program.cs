using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            for (var i = 0; i < 2; i++)
            {
                stopwatch.Start();

                Thread.Sleep(100);

                stopwatch.Stop();
                Console.WriteLine("Duration: " + stopwatch.GetInterval().ToString());
                Console.WriteLine("Press Enter to Reset");
                Console.ReadLine();
            }
        }
    }
    
}
