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
            var car = new Car("123456");

            //var car1 = new Car();   

           // car.GetRegistrationNo();
            Console.WriteLine(car.ToString());
          

            Console.ReadLine();


           
        }
    }
}
