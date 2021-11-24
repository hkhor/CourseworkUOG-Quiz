using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseworkUOG_Quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkUOG_Quiz.Tests
{
    [TestClass()]
    public class RoundedCalculatorTests
    {
        [TestMethod()]
        public void divideTest()
        {
            Assert.Fail();
            RoundedCalculator rdc = new RoundedCalculator();
            double correct = 4;
            double total = 15;
            double actual;
            double expected = 3;
            actual = rdc.divide(correct, total);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void mutliplyTest()
        {

            RoundedCalculator rdc = new RoundedCalculator();
            double afterDivide = 0.26666;
            double percentage = 100;
            double actual;
            double expected = 26.67;
            actual = rdc.mutliply(afterDivide, percentage);
            Assert.AreEqual(expected, actual);
            Assert.Fail();
        }
    }
}