using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApp36
{
    [TestFixture]
    class EmployeeDataTesting
    {
        EmployeeData employee1;

        [SetUp]
        public void TestSetup()
        {
            employee1= new EmployeeData();
        }

        [Test]
        public void TestIfGotRidOfEnding()
        {
            List<string> ListOfDifferentEmails = new List<string>();
            ListOfDifferentEmails.Add("andre.griffin");
            ListOfDifferentEmails.Add("jhon.snow");
            ListOfDifferentEmails.Add("tim-allen.toomingas");
            ListOfDifferentEmails.Add("hei-hoo.chee_choo");
            ListOfDifferentEmails.Add("a.chin_chan");

            List<string> expected= employee1.GetRidOffEmailEnding();


            Assert.That(expected, Is.EqualTo(ListOfDifferentEmails));
        }
        
        [Test]
        public void TestFindingNames()
        {
            List<string> ListOfDifferentNames = new List<string>();
            ListOfDifferentNames.Add("andre griffin");
            ListOfDifferentNames.Add("jhon snow");
            ListOfDifferentNames.Add("tim allen toomingas");
            ListOfDifferentNames.Add("hei hoo chee-choo");
            ListOfDifferentNames.Add("unknown chin-chan");

            List<string> expected = employee1.FindNames();
           Assert.That(expected, Is.EqualTo(ListOfDifferentNames));
        }

        /*
        [Test]
        public void TestSeparation()
        {
            List<string> ListOfDifferentNames = new List<string>();
            ListOfDifferentNames.Add("andre griffin");
            ListOfDifferentNames.Add("jhon snow");
            ListOfDifferentNames.Add("tim-allen toomingas");
            ListOfDifferentNames.Add("hei hoo chee_choo");
            ListOfDifferentNames.Add("unknown chin_chan");

            employee1.GetRidOffEmailEnding();
            List<string> expected = employee1.SeparateName();
            Assert.That(expected, Is.EqualTo(ListOfDifferentNames));
        }*/

    }
}
