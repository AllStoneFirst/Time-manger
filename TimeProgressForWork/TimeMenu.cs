using InterfacesWork;
using System;
using System.Text.RegularExpressions;
using System.Threading;
using TimeProgressForWork;

namespace TimeObject
{
    public class TimeMenu : TimeBase, IMenuFunctions
    {
        public TimeMenu() : base(TimeType.TypeOne) { HeadMenu(); }

        public void HeadMenu()
        {
            Console.Clear();
            Options.ProgramMessage("Choose the function you need. If you have questions, enter the command /help");
            var choice = Console.ReadLine();

            if (choice != null || choice[0] != '/')
            {
                switch (choice)
                {
                    case "/setregion":
                        RegionOptions();
                        HeadMenu();
                        break;
                    case "/time":
                        Options.ProgramMessage("Time is set to UTC! To set the time, go to the main menu and enter the command /setregion");
                        Options.ProgramMessage($"Time now: {Options.Time}");
                        Options.ProgramMessage("Press any button to go back");
                        if (Console.ReadKey(true) != null)
                            HeadMenu();
                        break;
                    case "/stopwatch":
                        new StopWatchProgress().StartWork(Options.stopWatch);
                        StopWatchOptions();
                        break;
                    case "/timer":
                        new TimerProgress().StartWork();
                        TimerOptions();
                        break;
                    case "/help":
                        new HelpProgress().StartWork();
                        if(Console.ReadKey(true) != null)
                            HeadMenu();
                        break;
                }
            }
        }

        public void RegionOptions()
        {
            Array array = Enum.GetValues(typeof(Regions));

            Options.ProgramMessage("To view the names of all regions, type /regions!");
            Options.ProgramMessage("Enter the name region you need through the command /region [City]! ");
            Options.ProgramMessage("If you want to return to the main menu, press Enter");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "/regions":
                    for (int i = 0; i < array.Length; i++)
                        Options.ProgramMessage($"{i} - {array.GetValue(i)}");
                    if (Console.ReadKey(true) != null)
                        Console.Clear();
                    RegionOptions();
                    break;

                case string _choice when new Regex(@"/region [A-Z]").IsMatch(_choice):
                    new TimeRegionOptions(choice);
                    break;
                case string _choice when !string.IsNullOrEmpty(_choice):
                    Options.ProgramMessage("An error has occurred");
                    Thread.Sleep(3000);
                    break;
            }
        }

        public void StopWatchOptions()
        {
            switch (Console.ReadLine())
            {
                case "/segment":
                    new StopWatchProgress().ShowSegmentTime();
                    StopWatchOptions();
                    break;
                case "/next":
                    new StopWatchProgress().StartWork(Options.stopWatch);
                    StopWatchOptions();
                    break;
                case "/exit":
                    Options.stopWatch.Reset();
                    Options.segmentlist.Clear();
                    HeadMenu();
                    break;
            }
        }

        public void TimerOptions()
        {
            Options.ProgramMessage("Enter one of the commands: /exit or /next...");

            switch (Console.ReadLine())
            {
                case "/next":
                    new TimerProgress().StartWork();
                    TimerOptions();
                    break;
                case "/exit":
                    Options.timer = default;
                    HeadMenu();
                    break;
            }
        }
    }
}
