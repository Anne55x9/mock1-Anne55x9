using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExamProgBrushUp_ASW
{
    public class Owner
    {

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

        /// <summary>
        /// Konstruktor til klassen Owner med en lokal parameter.
        /// </summary>
        /// <param name="address"></param>

        public Owner(String address)
        {
            this.Address = address;
        }

        //Metoder til constraints på de forskellige attributter. 
        
        public String GetAddress()
        {
            if (Address.Length > 6)
            {
                return Address;
            }
               
            else
            {
                throw new ArgumentException("Addressen skal være længere end 6 tegn");
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
                throw new ArgumentException("Navnet skal have mere end 4 tegn i sig");
            }
        }


    }
}
