using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class Student : Person
    {
        public string RegisterNum { get; set; }
        public string Course { get; set; } 
        public bool Active { get; set; }

        public override string ToString()
        {
            return Name + Email + "\nRA: " + RegisterNum +
                   "\nCurso: " + Course;
        }
    }
}
