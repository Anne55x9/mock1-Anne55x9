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

            var car = new Car(2,"volvo");

            //Act 

            int doors = car.GetDoors();

            //Assert

            Assert.AreEqual(2, doors);
        }


        [TestMethod()]

        [ExpectedException(typeof(ArgumentException))]
        public void GetDoorsUnder2()
        {
            //Arrange 

            var car = new Car(1,"volvo");

            //Act

            int doors = car.GetDoors();

        }

        [TestMethod()]

        [ExpectedException(typeof(ArgumentException))]
        public void GetDoorsAbove5()
        {
            //Arrange 

            var car = new Car(6,"volvo");

            //Act

            int doors = car.GetDoors();

        }

        #endregion


        #region Test til model metoden mht model navn ikke er tomt. Plus parameter dør.
        [TestMethod()]
        public void GetModelNotNullPlusDoors4()
        {
            //Arrange

            var car = new Car(2, "Volvo");

            //Act

            int doors = car.GetDoors();
            String model = car.GetModel();

            //Assert

            Assert.AreEqual(2, doors);
            Assert.AreEqual("Volvo", model);
        }

        [TestMethod()]

        [ExpectedException(typeof(NullReferenceException))]
        public void GetModelNullPlusDoors1()
        {
            //Arrange 

            var car = new Car(2, "");

            //Act

         
            String model = car.GetModel();

        }

    
        #endregion

        #region Test til registreringNummer metoden mht nummeret skal være 7. Plus parametre døre og model.



        #endregion


    }
}