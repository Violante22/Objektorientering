using System;
using System.Collections.Generic;
using System.Text;

namespace Objektorientering
{
    public class Person
    {
        public string Name { get; set; }
        public double Lenght { get; set; }
        public double Weight { get; set; }

        public string Password { get;  }//bara läsa
        public double CalculateBmi()
        {
            double bmi = Weight / (Lenght * Lenght);
            return bmi;

        }
        public override string ToString()//imbygt metod som ge namn på personer i vara list box
        {
            return Name;
        }

    }
}
