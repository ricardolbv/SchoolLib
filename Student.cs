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

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj.GetType() != this.GetType())
                return false;

            if (this == obj)
                return true;

            Student other = (Student) obj;

            if (other.Name == this.Name && other.Age == this.Age && other.Email == this.Email &&
                other.RegisterNum == this.RegisterNum && other.Course == this.Course && other.Active == this.Active)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            int hash = 17;

            hash = hash * 23 + Name.GetHashCode(); 
            hash = hash * 23 + Age.GetHashCode();
            hash = hash * 23 + Email.GetHashCode();
            hash = hash * 23 + RegisterNum.GetHashCode();
            hash = hash * 23 + Course.GetHashCode();
            hash = hash * 23 + Active.GetHashCode();

            return hash;
        }
    }
}
