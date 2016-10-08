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
    public class MultiplesOf3and5Test
    {

        private SumMultiplesOf3and5 _sumMultiplesOf3And5;
        private int Answer;


        [SetUp]
        protected void SetUp()
        {
            _sumMultiplesOf3And5 = new SumMultiplesOf3and5();
            _sumMultiplesOf3And5.numbersTo = 10;
            Answer = _sumMultiplesOf3And5.GetAnswer();
        }

        [Test]
        public void MustReturn23forNumbersTo10()
        {
            Assert.AreEqual(Answer,23);
        }

        [Test]
        public void MustReturnPositiveResultForNumbersTo1000()
        {
            _sumMultiplesOf3And5.numbersTo = 1000;
            Answer = _sumMultiplesOf3And5.GetAnswer();
            Assert.IsTrue(Answer > 0);
            Console.Write(Answer);
        }


    }
}
