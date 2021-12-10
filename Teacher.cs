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

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj.GetType() != this.GetType())
                return false;

            if (this == obj)
                return true;

            Teacher other = (Teacher)obj;

            if (this.Name == other.Name && this.Age == other.Age && this.Email == other.Email &&
                this.Formation == other.Formation && this.Especiality == other.Especiality)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            int hash = 17;

            hash = hash * 23 + Name.GetHashCode(); 
            hash = hash * 23 + Age.GetHashCode();
            hash = hash * 23 + Email.GetHashCode();
            hash = hash * 23 + Formation.GetHashCode();
            hash = hash * 23 + Especiality.GetHashCode();

            return hash;
        }

    }
}
