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

        [TestMethod()]
        public void GetModelNotNullPlusDoors4()
        {
            //Arrange

            var car = new Car(4,"Volvo");

            //Act

            int doors = car.GetDoors();
            String model = car.GetModel();

            //Assert

            Assert.AreEqual(4,doors);
            Assert.AreEqual("Volvo", model);
        }

        [TestMethod()]

        [ExpectedException(typeof(ArgumentException))]
        public void GetModelNullPlusDoors1()
        {
            //Arrange 

            var car = new Car(1,"");

            //Act

            int doors = car.GetDoors();
            String model = car.GetModel();

        }
    }
}