using System;
using System.Collections.Generic;
using System.Text;

namespace Matematica
{
   public class Exercise
    {
        public string Name { get; set; }

        public List<Shape> Shapes { get; set; } = new List<Shape>();//tomm lista med start värde
        public double CalculateArea()
        {
            double sum = 0;
            foreach(Shape shape in Shapes) //för varje figurer som jag har in min lista så vill jag göra nånting
            {
                sum += shape.CalculateArea();//sum ska tilldela väre av(somma assegnera' un valore di)
                // double totArea = rettangolo.CalculateArea() + triangolo.CalculateArea();
            }
            return sum;
        }
        public Exercise (string name)
        {
            Name = name;
        }
        public bool IsAnswerCorrect(double guess)// le rispost possono essere si o no(bool) il parametro che mando dentro \n e quello che voglio sapere se e' corretto  
        {
            if(guess==CalculateArea())
            { 
                return true;// har gissat rätt?
            }
            return false;
        }
    
   }
}
