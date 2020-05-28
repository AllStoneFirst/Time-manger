using InterfacesWork;
using System;
using System.Collections.Generic;
using System.Text;
using TimeObject;

namespace TimeProgressForWork
{
    public class HelpProgress : TimeBase, IStart
    {
        public HelpProgress() : base(TimeType.TypeOne) { }

        private List<string> helplist = new List<string>()
        {
            "Head menu:",
            "/help - Show command list.",
            "/timer - Turn on timer.",
            "/stopwatch - Turn on stopwatch.",
            "/setregion - Change region type.",
            "Stopwatch menu:",
            "/next - Continue stopwatch.",
            "/exit - Exit to the main menu.",
            "/segment - Show segments stopwatch.",
            "Timer menu:",
            "/next - Continue timer.",
            "/exit - Exit to the main menu.",
            "Region menu:",
            "/regions - Show regions.",
            "/region [City] - Change region type."
        };

        public void StartWork()
        {
            foreach(var item in helplist)
            {
                Options.ProgramMessage(item);
            }
        }
    }
}
