using System;

namespace TimeObject
{
    public static class TextOptions
    {
        public static void TimeTag(this TimeOptions timeOptions, string text)
        {
            Console.ForegroundColor = timeOptions.TimeColor;

            Console.WriteLine($" [Time]{text}[/Time]");

            Console.ResetColor();
        }

        public static void ProgramTag(this TimeOptions timeOptions, string text)
        {
            Console.ForegroundColor = timeOptions.ProgramColor;

            Console.WriteLine($" [Program]{text}[/Program]");

            Console.ResetColor();
        }

        public static void FlagTag(this TimeOptions timeOptions)
        {
            Console.ForegroundColor = timeOptions.ProgramColor;

            Console.Write("| \n|_");

            Console.ResetColor();
        }
    }
}
