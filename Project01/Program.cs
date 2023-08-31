using System;

namespace Project01
{
    class Program
    {
        static void Main(string[] args)
        {
            TechnicalService techService = new TechnicalService();
            DateService dateService = new DateService();
            //Quest01
            DateTime dateWithSelectedYear = dateService.GetDateWithSelectedYear(1861);
            Console.WriteLine(dateWithSelectedYear);
            //Quest02
            DateTime randomDate = new DateTime(2022, 07, 25);
            DateTime randomDatePlus = new DateTime(2022, 07, 15);
            randomDate = dateService.GetFirstDayInWeek(randomDate);
            Console.WriteLine(randomDate);
            //Quest03
            randomDate = dateService.GetLastDayInWeek(randomDate);
            Console.WriteLine(randomDate);
            //Quest05
            int countOfWeekends = dateService.GetCountOfWeekends(randomDate, randomDatePlus);
            Console.WriteLine(countOfWeekends);
            //Quest04
            DateTime[] weekendsDateArray = dateService.GetWeekendsDateArray(randomDate, randomDatePlus);
            techService.Write1DArray(weekendsDateArray);
            //Quest06
            DateTime[] dateArray = dateService.GetDateArray(randomDate, randomDatePlus);
            techService.Write1DArray(dateArray);
        }
    }
}
