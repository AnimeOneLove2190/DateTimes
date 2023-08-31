using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class TechnicalService
    {
        public int GetRandomNumber(int minValue, int maxValue)
        {
            Random godOfNumbers = new Random();
            int randomNumber = godOfNumbers.Next(minValue, maxValue);
            return randomNumber;
        }
        public int GetLengthOfTheInterval(DateTime firstDate, DateTime lastDate)
        {
            if (firstDate == lastDate)
            {
                return 1;
            }
            if (firstDate > lastDate)
            {
                DateTime tempStorage = lastDate;
                lastDate = firstDate;
                firstDate = tempStorage;
            }
            int countOfDays = 1;
            while (!(firstDate == lastDate))
            {
                firstDate = firstDate.AddDays(1);
                countOfDays++;
            }
            return countOfDays;
        }
        public void Write1DArray(DateTime[] dateArray)
        {
            if (dateArray == null || dateArray.Length == 0)
            {
                Console.WriteLine("Массив пуст, милорд");
                return;
            }
            for (int i = 0; i < dateArray.Length; i++)
            {
                Console.Write($"{dateArray[i]} ");
            }
            Console.WriteLine();
        }
    }
}
