using System;
using TimeObject;

namespace TimeProgressForWork
{
    public class TimeRegionOptions : TimeBase
    {
        public TimeRegionOptions(string _choice) : base(TimeType.TypeOne)
        {
            SetRegion(_choice);
        }

        public void SetRegion(string choice)
        {
            Array array = Enum.GetValues(typeof(Regions));

            string totalregion = null;

            for (int i = 0; i < choice.Length; i++)
            {
                if (choice[i] == ' ')
                {
                    for (int k = i + 1; k < choice.Length; k++)
                    {
                        totalregion += choice[k];
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (totalregion == array.GetValue(i).ToString())
                {
                    Options.Time -= Options.RegionType;
                    Options.RegionType = TimeSpan.FromHours((int)array.GetValue(i));
                    Options.Time += Options.RegionType;
                    Options.ProgramMessage(Options.Time.Hour + ":" + Options.Time.Minute + ":" + Options.Time.Second);
                    Options.ProgramMessage("Setup completed successfully! Press any button to go back");

                    if (Console.ReadKey(true) != null)
                    {
                        continue;
                    }
                }
            }
        }
    }
}
