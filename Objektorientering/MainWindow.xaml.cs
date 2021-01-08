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

namespace Objektorientering
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            Person person2 = new Person();//konstruktor till en ny objekt
            List<Person> people = new List<Person>();
        Cours cours;// una nuova classe per un nuovo tipo di studenti che sono persone
        public MainWindow()
        {
            InitializeComponent();
            cours = new Cours();//initiera cours
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person(); //skapa objekt =new
            person.Name = "Vanessa";
            person.Lenght = 1.59;
            MessageBox.Show(person.Password);
            double bmi = person.CalculateBmi();


            person2 = new Person//konstruktor till en ny objekt
            {
                Name = "Omar",
                Weight = 76,
                Lenght = 2.05
            };
            people = new List<Person>();
            people.Add(person);
            people.Add(person2);
            lstNames.ItemsSource = people;
            //string[] test = new string[3];
            //string[] test2 = { "Vanessa", "Emanuele" };
        }

        private void btnok_Click(object sender, RoutedEventArgs e)
        {//e' solo qui che si crea una nuova persona e quindi si puo' di nuovo usare person 2
            //person2 = new Person();
            //person2.Name = "Sara";
            //people.Add(person2);
            //lstNames.ItemsSource = null;
            //lstNames.ItemsSource = people;
           // Cours cours = new Cours();//varje gång man klickar på knappen skopas en ny obj. 
            Person person = new Person();
            Cours cours = new Cours();
            {
                Name = "Sofie";
            };
            cours.Name = "Programmering";
            cours.Students.Add(person2);
            // lstNames.ItemsSource = cours.Students;//binda lista till objekt som ligger i klassen
            UppdateUi();// den legger till i vara lista som är i class av coursList...

        }
        private void UppdateUi()//visa lista i grensnitt
        {
            lstNames.ItemsSource = null;
            lstNames.ItemsSource = cours.Students;
        }
    }
}
