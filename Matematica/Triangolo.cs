using System;
using System.Collections.Generic;
using System.Text;

namespace Matematica
{
    public class Triangolo:Shape
    {
        

        public override double CalculateArea()//prende il metodo da shape e lo cambia
        {
            return Height * Width / 2;
        }
    }
}
