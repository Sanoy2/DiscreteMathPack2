using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMathPack2
{
    public class Stopwatch
    {
        private System.Diagnostics.Stopwatch stopwatch;

        public Stopwatch()
        {
            stopwatch = new System.Diagnostics.Stopwatch();
        }

        public void Start()
        {
            stopwatch.Reset();
            stopwatch.Start();
        }

        public void Stop()
        {
            stopwatch.Stop();
        }

        public void StopAndPrint()
        {
            stopwatch.Stop();
            Print();

        }

        public void Print()
        {
            var builder = new StringBuilder();
            builder.AppendLine("Execution time: ");
            builder.AppendLine(GetResultInNs() + " nanoseconds");
            builder.AppendLine(GetResultInMs() + " milliseconds");
            builder.AppendLine(GetResultInS() + " seconds");
            builder.AppendLine(GetResultInM() + " minutes");
            builder.AppendLine("Elapsed time: " + stopwatch.Elapsed);
            builder.AppendLine("Elapsed ticks: " + stopwatch.ElapsedTicks);
            Console.WriteLine(builder.ToString());
        }

        public int GetResultInNs()
        {
            double result = stopwatch.Elapsed.TotalMilliseconds * 1000;
            return (int) result;
        } 

        public int GetResultInMs()
        {
            return (int)stopwatch.ElapsedMilliseconds;
        }

        public int GetResultInS()
        {
            return GetResultInMs() / 1000;
        }

        public int GetResultInM()
        {
            return GetResultInS() / 60;
        }
    }
}
