using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProjectEuler.Solutions;

namespace ProjectEuler.Solution.Tests
{
    [TestFixture]
    public class EvenFibonacciNumbersTest
    {

        private EvenFibonacciNumbers _evenFibonacciNumbers;
        private int Answer;


        [SetUp]
        protected void SetUp()
        {
            _evenFibonacciNumbers = new EvenFibonacciNumbers();
        }

        
        [Test]
        public void SumOfFibNumbersUnder10is19()
        {
            // 1+2+3+5+8 = 19

            
            for (int i = 1; i <= 3; i++)
            {
                _evenFibonacciNumbers.Sum += _evenFibonacciNumbers.currentFibonacciNumber;
                _evenFibonacciNumbers.GetNextFibonacci();

            }

            Assert.AreEqual(19,_evenFibonacciNumbers.Sum);
        }


        [Test]
        public void ShouldBePositiveSumForFibNumbersUnder100()
        {
            _evenFibonacciNumbers.Reset();


            while (_evenFibonacciNumbers.currentFibonacciNumber < 100)
            {
                _evenFibonacciNumbers.Sum += _evenFibonacciNumbers.currentFibonacciNumber;
                _evenFibonacciNumbers.GetNextFibonacci();
                Console.WriteLine(_evenFibonacciNumbers.currentFibonacciNumber);
            }

            Console.WriteLine(_evenFibonacciNumbers.Sum);
            Assert.IsTrue(_evenFibonacciNumbers.Sum > 0);
        }

        [Test]
        public void SumOfFOnlyEvenFibNumbersUnder10is10()
        {
            // 2+8 = 10

            _evenFibonacciNumbers.Reset();
            _evenFibonacciNumbers.Sum = 2; //

            for (int i = 1; i <= 3; i++)
            {
                if(_evenFibonacciNumbers.currentFibonacciNumber % 2==0)
                    _evenFibonacciNumbers.Sum += _evenFibonacciNumbers.currentFibonacciNumber;
                _evenFibonacciNumbers.GetNextFibonacci();

            }

            Assert.AreEqual(10, _evenFibonacciNumbers.Sum);
        }

        [Test]
        public void SumOfFOnlyEvenFibNumbersNotExeceeding4millionisPositive()
        {
            // 2+8 = 10

            _evenFibonacciNumbers.Reset();
            _evenFibonacciNumbers.Sum = 2; //

            while (_evenFibonacciNumbers.currentFibonacciNumber <= 4000000)
            {
                if (_evenFibonacciNumbers.currentFibonacciNumber % 2 == 0)
                    _evenFibonacciNumbers.Sum += _evenFibonacciNumbers.currentFibonacciNumber;
                Console.WriteLine(_evenFibonacciNumbers.currentFibonacciNumber);
                _evenFibonacciNumbers.GetNextFibonacci();
            }

            Console.WriteLine(_evenFibonacciNumbers.Sum);

            Assert.IsTrue(_evenFibonacciNumbers.Sum > 0);
        }


    }
}
