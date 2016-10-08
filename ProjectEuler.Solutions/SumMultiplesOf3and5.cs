using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    public class SumMultiplesOf3and5
    {
        private int numbersFrom {
            get { return 1; }
            set { }
        }
        public int numbersTo { get; set; }

        public int GetAnswer()
        {
            var sum = 0;
            for (var i = numbersFrom; i < numbersTo; i++)
            {
                if (i%3 == 0 || i % 5 == 0)
                    sum += i;
            }

            return sum;
        }
    }
}
