using System;
using System.Collections.Generic;
using System.Text;

namespace Objektorientering
{
    public class Cours
    {
        public string Name { get; set; }
        public List<Person> Students { get; set; }// class cour har kontakt med class person igenom en list av students
    }
}
