using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExamProgBrushUp_ASW
{
    public class Car
    {
        /// <summary>
        /// KLasen har indeholder properties som har begrænsninger når de sættes. 
        ///De forskellige properties er full props og bruges i metoderne i klassen.  
        ///
        /// </summary>

        #region Full properties til klassen Car med privat instance felter og public metode.


        public ColorEnum Color { get; set; }
        public Owner Owner { get; set; }


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
            get
            {
   
                    return registrationNo;
 
            }
            private set
            {
                try
                {
                    registrationNo = value;
                    GetRegistrationNo();
                }
                catch(ArgumentException)
                {
                    Console.WriteLine("RegNr skal være på 7 tegn!");
                }


}
            
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
        /// overloaded konstruktor med 2  parametre døre og model.
        /// </summary>
        /// <returns></returns>
        /// 

        public Car(int doors,String model)
        {
            this.Doors = doors;
            this.Model = model;
            GetDoors();
            GetModel();
        }

        /// <summary>
        /// overloaded konstruktor med 3 parametre døre og model og registreringsnummer.
        /// </summary>
        /// <returns></returns>
        /// 

        public Car(String registreringsNummer)
        {
           // int doors, String model,
            doors = 2;
            model = "Volvo";
            this.RegistrationNo = registreringsNummer;
            
 
        }

        /// <summary>
        /// overloaded konstruktor med 4 parametre 
        /// </summary>
        /// <returns></returns>
        /// 

        public Car(int doors, String model, String registreringsNummer,ColorEnum color)
        {
            this.Doors = doors;
            this.Model = model;
            this.RegistrationNo = registreringsNummer;
            
            this.Color = color;
            

            
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
        
        /// <summary>
        /// Indsat en nullreferenceexception istedet for argument da propertien ikke må være null.
        /// </summary>
        /// <returns></returns>

        public String GetModel()
        {
            if(Model.Length != 0)
            {
                return Model;
            }
            else
            {
                throw new NullReferenceException("Modellen navnet må ikke være tomt.");
            }
        }

        public String GetRegistrationNo()
        {
            if (RegistrationNo.Length == 7)
            {
                return RegistrationNo;
            }
            else
            {
                throw new ArgumentException("Registreringnummeret skal være på 7 tegn.");
            }
        }




        #endregion

        public override string ToString()
        {
            return "Antal døre: " + Doors + " BilModellen: " + Model + " Registreringsnummer: "+ RegistrationNo;
        }
    }
}
