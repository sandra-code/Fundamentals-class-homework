using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApp36
{
    [TestFixture]
    class TimeCalculatorTesting
    {
        TimeCalculator calc;

        [SetUp]
        public void TestSetup()
        {
            calc = new TimeCalculator();
        }

        [Test]
        public void TestTimeCalculator_2hours()
        {
            DateTime testDate = new DateTime(2000,1,1);
            testDate.AddHours(2);

            DateTime expectedResult = calc.FindTime(+2);

            Assert.That(expectedResult, Is.EqualTo(testDate));
        }

        [Test]
        public void TestFindingMinutesfromInput_2hours_30minutes()
        {
            DateTime testDate = new DateTime(2000, 1, 1);
            testDate.AddMinutes(30);
            testDate.AddHours(2);

            DateTime expectedResult = calc.FindTime(+2.5);

            Assert.That(expectedResult, Is.EqualTo(testDate));
        }

        [Test]
        public void TestAddHours_3hours()
        {
            DateTime testDate = new DateTime(2000, 1, 1);
            testDate.AddHours(3);

            DateTime expectedResult = calc.FindTime(+3);

            Assert.That(expectedResult, Is.EqualTo(testDate));
        }

        [Test]
        public void TestSubtractHours_4hours()
        {
            DateTime testDate = new DateTime(2000, 1, 1);
            testDate.AddHours(-4);

            DateTime expectedResult = calc.FindTime(-4);

            Assert.That(expectedResult, Is.EqualTo(testDate));
        }
    }
}
