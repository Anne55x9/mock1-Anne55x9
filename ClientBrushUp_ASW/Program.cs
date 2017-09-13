using MockExamProgBrushUp_ASW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClientBrushUp_ASW
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(2,"Volvo","1234567");

           // car.GetRegistrationNo();
            Console.WriteLine(car.ToString());
          

            Console.ReadLine();


           
        }
    }
}
