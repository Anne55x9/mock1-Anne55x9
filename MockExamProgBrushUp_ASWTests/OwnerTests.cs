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

        #region Test til at tjekke at navnet er over 4 tegn med adresse parameter med. 

        [TestMethod()]
        public void GetNameTestAbove4PlusAddressAbove6()
        {
            //Arrange 

            var owner = new Owner("Kirsebærvej", "Katrine");

            //Act

            String adresse = owner.GetAddress();
            String navn = owner.GetName();

            //Assert

            Assert.AreEqual("Kirsebærvej", adresse);
            Assert.AreEqual("Katrine", navn);
        }

        [TestMethod()]

        [ExpectedException(typeof(ArgumentException))]
        public void GetNameTest4tegnPlusAddress6tegn()
        {
            //Arrange 

            var owner = new Owner("Solvej", "Klas");

            //Act

            String adresse = owner.GetAddress();
            String navn = owner.GetName();

        }

        [TestMethod()]

        [ExpectedException(typeof(ArgumentException))]
        public void GetNameTestUnder4PlusAddressUnder6()
        {
            //Arrange 

            var owner = new Owner("Øvej", "Lis");

            //Act

            String adresse = owner.GetAddress();
            String navn = owner.GetName();

        }

        #endregion

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

