using InterfacesWork;
using System;
using System.Threading;
using TimeObject;

namespace TimeProgressForWork
{
    public class StartTimeManagerProgress : TimeBase, IStart
    {
        public StartTimeManagerProgress() : base(TimeType.TypeOne) { StartWork(); }
        public void StartWork()
        {
            Options.ProgramMessage("Program is starting...");

            Options.TimeMessage($"Time is {Options.TimeNow}");

            Thread.Sleep(3000);
        }
    }
}
