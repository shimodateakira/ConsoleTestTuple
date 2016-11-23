using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = (1, "AKIRA");
            Trace.WriteLine($"Item1={a.Item1}, Item2={a.Item2}");

            var happyBirthDay = HappyBirthDay(new DateTime(1971, 10, 12), "AKIRA");
            Trace.WriteLine($"{happyBirthDay.Age}: {happyBirthDay.Message}");
        }

        static (int Age, string Message) HappyBirthDay(DateTime birth, string name)
        {
            return ((DateTime.Now - birth).GetYears(), $"Happy birth day! {name}!");
        }
    }
    public static class TimeSpanExtensions
    {
        public static int GetYears(this TimeSpan timespan)
        {
            return (int)((double)timespan.Days / 365.2425);
        }
        public static int GetMonths(this TimeSpan timespan)
        {
            return (int)((double)timespan.Days / 30.436875);
        }
    }
}
