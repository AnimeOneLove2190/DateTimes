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
    }
}
