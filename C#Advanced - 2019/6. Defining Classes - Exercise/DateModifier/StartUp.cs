using System;
using System.Globalization;

namespace DateModifier
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateTime first = ModifierStringToDate(firstDate);
            DateTime second = ModifierStringToDate(secondDate);

            int numberOfDates = Math.Abs((first.Date - second.Date).Days);

            Console.WriteLine(numberOfDates);
        }

        private static DateTime ModifierStringToDate(string currentDate)
        {
            //exaple: 1992 05 31
            var date = DateTime.ParseExact(currentDate,
                "yyyy M dd", CultureInfo.InvariantCulture);

            return date;
        }
    }
}
