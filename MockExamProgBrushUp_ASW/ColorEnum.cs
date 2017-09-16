using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExamProgBrushUp_ASW
{
    public class ColorEnum
    {

        ///Klasse enumColor med en enum bestående af farver i color propen. 

/// <summary>
/// Property af typen enum med de farver som systemet tillader. 
/// </summary>
        public enum Color
        {
            Black,
            White,
            Gray,
            Red,
            Green,
            Blue
        }

        public ColorEnum()
        {
            
        }


        public void GetColor (Color color)
        {
            if (color == Color.Black || color == Color.Blue || color == Color.Gray || color == Color.Green || color == Color.Red || color == Color.Red)
            {
                var col = color.ToString();
                Console.WriteLine(col);
            }
            else
            {
                throw new ArgumentException();
            }
        }
            

    }
}
