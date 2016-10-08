using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    public class EvenFibonacciNumbers
    {
        public const int startingNumber1 = 1;
        public const int startingNumber2 = 2;
        private int number1 = startingNumber1;
        private int number2 = startingNumber2;

        public int currentFibonacciNumber = startingNumber1 + startingNumber2;
        public int Sum = startingNumber1 + startingNumber2;


        public void Reset()
        {
            currentFibonacciNumber = startingNumber1 + startingNumber2;
            Sum = startingNumber1 + startingNumber2;
        }

        public void GetNextFibonacci()
        {
            number1 = number2;
            number2 = currentFibonacciNumber;
            currentFibonacciNumber = number1 + number2;
        }

        public void GetFibNumbers()
        {
            for (int i = 1; i <= 100; i++)
            {
                GetNextFibonacci();
            }
        }
    }
}
