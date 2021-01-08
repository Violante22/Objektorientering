using System;
using System.Collections.Generic;
using System.Text;

namespace Matematica
{
   public class ShapeFactory
    {
        public Shape CreatShape(string type, double width, double height)
        {
            if(type=="Rettangolo")
            {
                return new Rettangolo()
                {
                    Height = height,
                    Width = width
                };
            }
            return null;
        }
    }
}
