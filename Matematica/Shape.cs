using System;
using System.Collections.Generic;
using System.Text;

namespace Matematica
{
   public  abstract class Shape // non si puo' fare un objekt, det är bara en mall för att hålla gemensamma egenskaper och metoder
   {
        public double Height { get; set; }
        public double Width { get; set; }
        public virtual double CalculateArea()//si puo' fare quello che vuoi ma non lo puoi toglier,questo fa un virtuall
        {
            return Height * Width;
        }
   }
}
