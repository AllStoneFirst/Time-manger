using InterfacesWork;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using TimeObject;

namespace TimeProgressForWork
{
    public class StopWatchProgress : TimeBase, IStopWatchFunctions
    {
        TimeSpan ts;

        public StopWatchProgress() : base(TimeType.TypeOne) { }

        public void StartWork(Stopwatch stopWatch)
        {
            Options.ProgramMessage("Enter to stop the stopwatch or space to draw a timeline!");

            Thread.Sleep(2000);

            stopWatch.Start();

            do
            {
                ts = stopWatch.Elapsed;

                Options.ProgramMessage($"{ts.Seconds:00}:{ts.Milliseconds:00}");

                Thread.Sleep(100);

                Console.Clear();
            }
            while (Console.KeyAvailable == false);

            if(Console.KeyAvailable == true && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
            {
                if (Options.segmentlist.Count <= 150)
                {
                    Console.WriteLine("Add segment!");

                    Options.segmentlist.Add($"{ts.Seconds:00}:{ts.Milliseconds:00}");

                    StartWork(stopWatch);
                }
            }
            else
            {
                stopWatch.Stop();

                Options.ProgramMessage("Stopwatch is stoped!");
                Options.ProgramMessage($"Your time : {ts.Seconds:00}:{ts.Milliseconds:00}");
                Options.ProgramMessage("You can find out the results of the stopwatch: /segments, /next");
            }
        }

        public void ShowSegmentTime()
        {
            if(Options.segmentlist != null)
            {
                int i = 1;

                Options.ProgramMessage("Your time segments:");

                foreach (var item in Options.segmentlist)
                {
                    Options.ProgramMessage($"{i++} - {item}");
                }
            }
        }
    }
}
