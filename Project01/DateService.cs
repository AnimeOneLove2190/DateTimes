using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class DateService
    {
        readonly TechnicalService techService = new TechnicalService();
        public DateTime GetDateWithSelectedYear(int year)
        {
            int month = techService.GetRandomNumber(1, 12);
            int day = techService.GetRandomNumber(1, 28);
            int hour = techService.GetRandomNumber(1, 23);
            int minute = techService.GetRandomNumber(1, 59);
            int second = techService.GetRandomNumber(1, 59);
            DateTime dateWithSelectedYear = new DateTime(year, month, day, hour, minute, second);
            return dateWithSelectedYear;
        }
    }
}
