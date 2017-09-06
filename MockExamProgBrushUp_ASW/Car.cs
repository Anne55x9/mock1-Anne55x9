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

        #region Klassens forskellige konstruktører, default og 4 overloadede så test ikke skal ændres på undervejs i kodningen.

        /// <summary>
        /// Default konstruktor. 
        /// </summary>
        public Car()
        {

        }

        /// <summary>
        /// Overloaded konstruktor med en  parameter døre.
        /// </summary>
        /// <returns></returns>

        public Car(int doors)
        {
            this.Doors = doors;
        }

        /// <summary>
        /// overloaded konstruktor med 2  parametre døre og model.
        /// </summary>
        /// <returns></returns>
        /// 

        public Car(int doors,String model)
        {
            this.Doors = doors;
            this.Model = model;
        }

        /// <summary>
        /// overloaded konstruktor med 3 parametre døre og model.
        /// </summary>
        /// <returns></returns>
        /// 

        public Car(int doors, String model,String registreringsNummer)
        {
            this.Doors = doors;
            this.Model = model;
            this.RegistrationNo = registreringsNummer;
        }

        #endregion

        #region Metoder til at begrænse input i systemet.

        public int GetDoors()
        {
            if (Doors >= 2 && Doors <= 5)
            {
                return Doors;
            }
            else
            {
                throw new ArgumentException("Antallet af døre i bilen skal være mellem 2 og 5, begge tal inkluderet.");
            }
        }
        

        public String GetModel()
        {
            if(Model.Length != 0)
            {
                return Model;
            }
            else
            {
                throw new ArgumentException("Modellen navnet må ikke være tomt.");
            }
        }

        public String GetRegistrationNo()
        {
            if(RegistrationNo.Length == 7)
            {
                return RegistrationNo;
            }
            else
            {
                throw new ArgumentException("Registreringnummeret skal være på 7 tegn.");
            }
        }
       
        #endregion
    }
}
