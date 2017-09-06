using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExamProgBrushUp_ASW
{
    public class Car
    {

        #region Full properties til klassen Car med privat instance felter og public metode.

        private Enum color;

        public Enum Color
        {
            get { return color; }
            set { color = value; }
        }

        private int doors;

        public int Doors
        {
            get { return doors; }
            set { doors = value; }
        }

        private String model;

        public String Model
        {
            get { return model; }
            set { model = value; }
        }

        private String registrationNo;

        public String RegistrationNo
        {
            get { return registrationNo; }
            set { registrationNo = value; }
        }

        #endregion
        public Car()
        {

        }
    }
}
