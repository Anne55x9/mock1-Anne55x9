using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExamProgBrushUp_ASW
{
    public class Owner

    {

        /// <summary>
        /// KLasen har indeholder properties som har begrænsninger når de sættes. 
        ///De forskellige properties er full props og bruges i metoderne i klassen.  
        ///
        /// </summary>

        #region Full properties til klassen Owner med privat instance felter og public metode.

        private String address;

        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private String phone;

        public String Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        #endregion

        #region Klassens forskellige konstruktører, default og 3 overloadede så test ikke skal ændres på undervejs i kodningen.



        /// <summary>
        /// Ny overloaded konstruktor med parametrene adresse, navn og endelig telefon.
        /// Denne konstruktor laves så de nuværende kodetest ikke skal ændres på. 
        /// </summary>
        /// <returns></returns>
        /// 

        public Owner(String address, String name, String phone)
        {
            this.Address = address;
            this.Name = name;
            this.Phone = phone;
        }

        #endregion

        #region Metoder til at begrænse input i systemet. 

        //Metoder til constraints på de forskellige attributter. Test på metoderne foretages løbende.  

        public String GetAddress()
        {
            if (Address.Length > 6)
            {
                return Address;
            }
               
            else
            {
                throw new ArgumentException("Addressen skal være længere end 6 tegn.");
            }
        }

        public String GetName()
        {
            if(Name.Length > 4)
            {
                return Name;
            }
            else
            {
                throw new ArgumentException("Navnet skal have mere end 4 tegn i sig.");
            }
        }


        public String GetPhone()
        {
            if(Phone.Length == 8)
            {
                return Phone;
            }
            else
            {
                throw new ArgumentException("Telefon nummeret skal være på 8 tegn.");
            }
        }

        #endregion  
    }
}
