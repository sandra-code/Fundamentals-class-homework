using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApp36
{
    [TestFixture]
    class ExercisesTesting
    {
        Exercises ex;
        [SetUp]
        public void TestSetup()
        {
            ex = new Exercises();
        }

        [Test]
        public void CheckJoiningStrings_karupuksid()
        {
            string expectedResult = ex.JoinStrings("karu", "püksid");
            Assert.That(expectedResult, Is.EqualTo("karupüksid"));
        }
        [Test]
        public void CheckTheArrayOfsix()
        {
            int[] arrayOfNumbers = new int[] { 1, 30, 100, 14, 41, 199 };
            //bool areThereEvenNumbers, areThereOddNumbers;
            int[] expectedArray = ex.GenerateArrayOfSix();
            Assert.That(arrayOfNumbers, Has.Exactly(2).InRange(0, 20));
            Assert.That(arrayOfNumbers, Has.Exactly(2).InRange(30, 60));
            Assert.That(arrayOfNumbers, Has.Exactly(2).InRange(100, 200));

        }

        [Test]
        public void CheckBMICalculationWithNormal()
        {
            string expectedResult = ex.CalculateBMI(165.2, 62);
            Assert.That(expectedResult, Is.EqualTo("normal"));
        }
        [Test]
        public void CheckBMICalculationWithUnderweight()
        {
            string expectedResult = ex.CalculateBMI(165.2, 32);
            Assert.That(expectedResult, Is.EqualTo("underweight"));
        }
        [Test]
        public void CheckBMICalculationWithObese()
        {
            string expectedResult = ex.CalculateBMI(165.2, 220);
            Assert.That(expectedResult, Is.EqualTo("obese"));
        }
        [Test]
        public void CheckBMICalculationWithOverweight()
        {
            string expectedResult = ex.CalculateBMI(165.2, 70);
            Assert.That(expectedResult, Is.EqualTo("overweight"));
        }


        [Test]
        public void CheckReplacingSpaces_tere_hommikust()
        {
            string expectedResult = ex.ReplaceSpaces("tere homm           ikust");
            Assert.That(expectedResult, Is.EqualTo("tere*homm*ikust"));
        }


    }
}
