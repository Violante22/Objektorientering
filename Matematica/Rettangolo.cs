using System;
using System.Collections.Generic;
using System.Text;

namespace Matematica
{
    public class Rettangolo:Shape
    {
        

        public override double CalculateArea()
        {
            return Height * Width / 2;
        }
    }
}
