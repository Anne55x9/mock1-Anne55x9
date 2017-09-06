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
    public class CarTests
    {
        #region Test til doors metoden mht antal døre i bilen. 

        [TestMethod()]
        public void GetDoorsTest2()
        {
            //Arrange

            var car = new Car(2);

            //Act 

            int doors = car.GetDoors();

            //Assert

            Assert.AreEqual(2, doors);
        }

        [TestMethod()]
        public void GetDoorsTest5()
        {
            //Arrange

            var car = new Car(5);

            //Act 

            int doors = car.GetDoors();

            //Assert

            Assert.AreEqual(5, doors);
        }

        [TestMethod()]
        public void GetDoorsTest4()
        {
            //Arrange

            var car = new Car(4);

            //Act 

            int doors = car.GetDoors();

            //Assert

            Assert.AreEqual(4, doors);
        }

        [TestMethod()]

        [ExpectedException(typeof(ArgumentException))]
        public void GetDoorsUnder2()
        {
            //Arrange 

            var car = new Car(1);

            //Act

            int doors = car.GetDoors();

        }

        [TestMethod()]

        [ExpectedException(typeof(ArgumentException))]
        public void GetDoorsAbove5()
        {
            //Arrange 

            var car = new Car(6);

            //Act

            int doors = car.GetDoors();

        }

        #endregion


        #region Test til model metoden mht model navn ikke er tomt. Plus parameter dør.
        [TestMethod()]
        public void GetModelNotNullPlusDoors4()
        {
            //Arrange

            var car = new Car(4, "Volvo");

            //Act

            int doors = car.GetDoors();
            String model = car.GetModel();

            //Assert

            Assert.AreEqual(4, doors);
            Assert.AreEqual("Volvo", model);
        }

        [TestMethod()]

        [ExpectedException(typeof(ArgumentException))]
        public void GetModelNullPlusDoors1()
        {
            //Arrange 

            var car = new Car(1, "");

            //Act

            int doors = car.GetDoors();
            String model = car.GetModel();

        }

        #endregion

        #region Test til registreringNummer metoden mht nummeret skal være 7. Plus parametre døre og model.

        [TestMethod()]
        public void GetRegistrationNoTest7Doors2ModelNotNull()
        {
            //Arrange

            var car = new Car(2, "Volvo", "1234567");

            //Act 

            int doors = car.GetDoors();
            String model = car.GetModel();
            String regNo = car.GetRegistrationNo();

            //Assert

            Assert.AreEqual(2, doors);
            Assert.AreEqual("Volvo", model);
            Assert.AreEqual("1234567", regNo);
        }

        [TestMethod()]

        [ExpectedException(typeof(ArgumentException))]
        public void GetMRegNoNot7Door1ModelNull()
        {
            //Arrange 

            var car = new Car(1, "", "12345");

            //Act

            int doors = car.GetDoors();
            String model = car.GetModel();
            String regNo = car.GetRegistrationNo();

        }

        #endregion

        [TestMethod()]
        public void GetColorTest()
        {
            //Arrange

            var car = new Car(2,"Volvo","1234567","Black");

            //Act

            int doors = car.GetDoors();
            String model = car.GetModel();
            String regNo = car.GetRegistrationNo();
            String color = car.GetColor();

            //Assert

            Assert.AreEqual(2,doors);
            Assert.AreEqual("Volvo",model);
            Assert.AreEqual("1234567",regNo);
            Assert.AreEqual("Black",color);
        }
    }
}