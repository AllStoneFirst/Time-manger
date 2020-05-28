using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using TimeObject;

namespace TimeProgressForWork
{
    public class TimerProgress : TimeBase
    {
        public TimerProgress() : base(TimeType.TypeOne) { }

        public void StartWork()
        {
            if(Options.timer == default)
            {
                Options.ProgramMessage("Enter to stop the timer!");

                Options.ProgramMessage("Input time [hours:minutes:seconds]...");

                var time = Console.ReadLine();

                try
                {
                    Options.timer = TimeSpan.Parse(time);
                }
                catch(FormatException)
                {
                    Options.ProgramMessage("You entered the time incorrectly");

                    StartWork();
                }
                catch(NullReferenceException)
                {
                    Options.ProgramMessage("You did not enter time");

                    StartWork();
                }
            }

            Console.Clear();

            TimerWork();
        }

        private void TimerWork()
        {
            do
            {
                Options.ProgramMessage($"{Options.timer.Hours}:{Options.timer.Minutes}:{Options.timer.Seconds}");

                Options.timer -= new TimeSpan(0, 0, 1);

                Thread.Sleep(1000);

                Console.Clear();
            }
            while (Options.timer > new TimeSpan(0, 0, 1) && Console.KeyAvailable == false);

            Console.ReadKey();
        }
    }
}
