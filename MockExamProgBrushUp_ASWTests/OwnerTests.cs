using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockExamProgBrushUp_ASW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExamProgBrushUp_ASW.Tests
{
    [TestClass()]
    public class OwnerTests
    {

        #region Test til at tjekke at adressen skal have mere end 6 tegn.
        [TestMethod()]
        public void GetAddressTestAbove6Charac()
        {
            //Arrange 

            var owner = new Owner("Hirsevej");

            //Act

            String address = owner.GetAddress();

            //Assert

            Assert.AreEqual("Hirsevej", address);

        }

        [TestMethod()]

        [ExpectedException(typeof(ArgumentException))]
        public void GetAddressTest6Charac()
        {
            //Arrange 

            var owner = new Owner("Kålvej");

            //Act

            String address = owner.GetAddress();

        }

        [TestMethod()]

        [ExpectedException(typeof(ArgumentException))]
        public void GetAddressTestUnder6Charac()
        {
            //Arrange

            var owner = new Owner("Øvej");

            //Act

            string nummerplade = owner.GetAddress();

        }

        #endregion


    }
}

