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


      

        #region Test til at tjekke at telofonen kun kan være 8 tegn med adresse og navn parameter. 

        [TestMethod()]
        public void GetPhoneTest8tegnPlusAddresseAbove6PlusNameAbove4()
        {
            //Arrange 

            var owner = new Owner("Kirsebærvej","Lotte","12345678");

            //Act

            String addresse = owner.GetAddress();
            String name = owner.GetName();
            String phone = owner.GetPhone();

            //Assert

            Assert.AreEqual("Kirsebærvej",addresse);
            Assert.AreEqual("Lotte",name);
            Assert.AreEqual("12345678",phone);
        }

        [TestMethod()]

        [ExpectedException(typeof(ArgumentException))]
        public void GetPhoneTestUnder8PlusAddressUnder6NameUnder4()
        {
            //Arrange 

            var owner = new Owner("Øvej", "Lis","12345");

            //Act

            String adresse = owner.GetAddress();
            String navn = owner.GetName();
            String phone = owner.GetPhone();

        }

        [TestMethod()]

        [ExpectedException(typeof(ArgumentException))]
        public void GetPhoneTestAbove8PlusAddressUnder6NameUnder4()
        {
            //Arrange 

            var owner = new Owner("Øvej", "Lis", "123456789");

            //Act

            String adresse = owner.GetAddress();
            String navn = owner.GetName();
            String phone = owner.GetPhone();

        }

        #endregion
    }
}

