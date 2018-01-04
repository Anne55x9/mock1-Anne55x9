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

            Console.WriteLine(car);

            var car2 = new Car(40, "");

            Console.WriteLine(car2);

          
            Console.ReadLine();

        }
    }
}
