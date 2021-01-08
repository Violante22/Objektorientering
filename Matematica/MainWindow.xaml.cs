using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Matematica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Exercise exercise;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, RoutedEventArgs e)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            exercise = new Exercise("22 b");
            

            //{
            //    Name = "22b"
            //};
            Shape shape = shapeFactory.CreatShape("Rectangle",7,8);
            if(shape==null)
            {
                MessageBox.Show("Kunde inte skapa figuren");
            }
            else
            {
              exercise.Shapes.Add(shape);//la classe exercise ha una lista dove viene creato una nuova figura dalla fabbrica
                //double totArea = exercise.CalculateArea();
            }
           // if (exercise.IsAnswerCorrect(34)) cosi' si scrive anropa på metod
           


            
            //Rettangolo rettangolo = new Rettangolo
            //{
            //    Height = 7,
            //    Width = 8,

            //};
            //exercise.Shapes.Add(rettangolo);
            //Triangolo triangolo = new Triangolo
            //{
            //    Height = 8,
            //    Width = 6
            //};
            //exercise.Shapes.Add(triangolo);



        }
        //private void Test(Exercise exercise) //skickar in objekt exercise istället för shape 1, shape2, shape 3.


        //{

        //}
    }
}
