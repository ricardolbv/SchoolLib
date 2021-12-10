using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class Teacher : Person
    {
        public string Especiality { get; set; }    
        public string Formation { get; set; }

        public override string ToString()
        {
            return Name + Email + "\nEspecialidade: " + Especiality +
                   "\nFormação: " + Formation; 
        }

    }
}
