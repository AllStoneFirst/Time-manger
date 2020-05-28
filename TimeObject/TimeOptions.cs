using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TimeObject
{
    //Types for timer
    public enum TimeType
    {
        TypeDefault = 0,
        TypeOne = 1
    }

    public class TimeOptions
    {
        //Color for time objects
        public ConsoleColor TimeColor { get; set; }

        //Color for program objects
        public ConsoleColor ProgramColor { get; set; }

        public DateTime TimeNow { get; set; } = DateTime.Now;

        public DateTime Time { get; set; } = DateTime.UtcNow;

        //Type for timer
        internal TimeType TimerType { get; set; } = TimeType.TypeDefault;

        //Region time
        public TimeSpan RegionType { get; set; }

        public static readonly TimeOptions Default = new TimeOptions();

        //Messages for user
        public Func<string, int> ProgramMessage { get; set; }
        public Func<string, int> TimeMessage { get; set; }

        //Stopwatch functions
        public Stopwatch stopWatch = new Stopwatch();

        //Stopwatch segment list
        public List<string> segmentlist = new List<string>();

        public TimeSpan timer = default;

        //Start conficurations for timeoptions
        public static readonly Dictionary<TimeType, TimeOptions> _options = new Dictionary<TimeType, TimeOptions>() {
            { TimeType.TypeDefault, new TimeOptions{ ProgramColor = ConsoleColor.Green,
                TimeColor = ConsoleColor.White } },
            { TimeType.TypeOne,  new TimeOptions{ ProgramColor = ConsoleColor.Green, 
                TimeColor = ConsoleColor.Green }}
        }; 
    }
}
