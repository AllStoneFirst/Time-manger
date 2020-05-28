using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TimeObject
{
    public class TimeManagerFunctions : TimeBase, IFunctions
    {
        
        public TimeManagerFunctions(TimeType _type) : base(_type)
        {
        }

        public void SetRegion()
        {
            Array array = Enum.GetValues(typeof(Regions));

            Options.ProgramMessage("Enter the number region you need through the command /region [City]! ");

            string choice = Console.ReadLine();

            Options.ProgramMessage("To view the names of all regions, type /regions!");

            switch (choice)
            {
                case "/regions":
                    for (int i = 0; i < array.Length; i++)
                        Options.ProgramMessage($"{i} - {array.GetValue(i).ToString()}");
                    break;

                case string _choice when new Regex(@"/region [1-9]").IsMatch(choice):
                    Options.RegionType = TimeSpan.FromHours(int.Parse(choice[choice.Length - 1].ToString()));
                    Console.WriteLine(choice[choice.Length - 1]);
                    break;
                case "/exit":

                    break;
            }

            


        }
    }
}
