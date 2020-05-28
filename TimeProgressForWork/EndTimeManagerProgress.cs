using InterfacesWork;
using TimeObject;

namespace TimeProgressForWork
{
    public class EndTimeManagerProgress : TimeBase, IStart
    {
        public EndTimeManagerProgress() : base(TimeType.TypeOne) { StartWork(); }

        public void StartWork()
        {
            Options.FlagTag();

            Options.TimeTag(Options.TimeNow.ToString());

            Options.FlagTag();

            Options.ProgramTag("Program is closing...");
        }
    }
}
