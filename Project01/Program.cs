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
        }
    }
}
