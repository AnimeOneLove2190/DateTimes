using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class DateService
    {
        readonly TechnicalService techService = new TechnicalService();
        //Quest01
        public DateTime GetDateWithSelectedYear(int year)
        {
            int month = techService.GetRandomNumber(1, 12);
            int maxDay = DateTime.DaysInMonth(year, month);
            int day = techService.GetRandomNumber(1, maxDay + 1);
            int hour = techService.GetRandomNumber(1, 24);
            int minute = techService.GetRandomNumber(1, 60);
            int second = techService.GetRandomNumber(1, 60);
            DateTime dateWithSelectedYear = new DateTime(year, month, day, hour, minute, second);
            return dateWithSelectedYear;
        }
        //Quest02
        public DateTime GetFirstDayInWeek(DateTime dateTime)
        {
            DayOfWeek initialDayOfWeek = dateTime.DayOfWeek;
            while (!(initialDayOfWeek == DayOfWeek.Monday))
            {
                dateTime = dateTime.AddDays(-1);
                initialDayOfWeek = dateTime.DayOfWeek;
            }
            return dateTime;
        }
        //Quest03
        public DateTime GetLastDayInWeek(DateTime dateTime)
        {
            DayOfWeek initialDayOfWeek = dateTime.DayOfWeek;
            while (!(initialDayOfWeek == DayOfWeek.Sunday))
            {
                dateTime = dateTime.AddDays(1);
                initialDayOfWeek = dateTime.DayOfWeek;
            }
            return dateTime;
        }
        //Quest05
        public int GetCountOfWeekends(DateTime firstDate, DateTime lastDate)
        {
            if (firstDate == lastDate)
            {
                if (firstDate.DayOfWeek == DayOfWeek.Saturday || firstDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    return 1;
                }
            }
            if (firstDate > lastDate)
            {
                DateTime tempStorage = lastDate;
                lastDate = firstDate;
                firstDate = tempStorage;
            }
            DateTime tempStore = lastDate.AddDays(1);
            int countOfWeekends = 0;
            while (!(firstDate == tempStore))
            {
                if (firstDate.DayOfWeek == DayOfWeek.Saturday || firstDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    countOfWeekends++;
                }
                firstDate = firstDate.AddDays(1);
            }
            return countOfWeekends;
        }
        //Quest04
        public DateTime[] GetWeekendsDateArray(DateTime firstDate, DateTime lastDate)
        {
            DateTime[] dateArray = new DateTime[0];
            if (firstDate == lastDate)
            {
                if (firstDate.DayOfWeek == DayOfWeek.Saturday || firstDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    dateArray = new DateTime[1];
                    dateArray[0] = firstDate;
                }
            }
            if (firstDate > lastDate)
            {
                DateTime tempStorage = lastDate;
                lastDate = firstDate;
                firstDate = tempStorage;
            }
            int countOfWeekends = GetCountOfWeekends(firstDate, lastDate);
            dateArray = new DateTime[countOfWeekends];
            DateTime tempStore = firstDate;
            for (int i = 0; i < countOfWeekends; tempStore = tempStore.AddDays(1))
            {
                if (tempStore.DayOfWeek == DayOfWeek.Saturday || tempStore.DayOfWeek == DayOfWeek.Sunday)
                {
                    dateArray[i] = tempStore;
                    i++;
                }
            }
            return dateArray;
        }
        //Quest06
        public DateTime[] GetDateArray(DateTime firstDate, DateTime lastDate)
        {
            DateTime[] dateArray = new DateTime[0];
            if (firstDate == lastDate)
            {
                if (firstDate.DayOfWeek == DayOfWeek.Saturday || firstDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    dateArray = new DateTime[1];
                    dateArray[0] = firstDate;
                }
            }
            if (firstDate > lastDate)
            {
                DateTime tempStorage = lastDate;
                lastDate = firstDate;
                firstDate = tempStorage;
            }
            int countOfDays = techService.GetLengthOfTheInterval(firstDate, lastDate);
            dateArray = new DateTime[countOfDays];
            DateTime tempStore = firstDate;
            for (int i = 0; i < countOfDays; i++)
            {
                dateArray[i] = tempStore;
                tempStore = tempStore.AddDays(1);
            }
            return dateArray;
        }
    }
}
