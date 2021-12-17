using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class SchoolClass
    {
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        private List<Student> Students { get; set; } = new List<Student>();
        public void registerStudent(Student newStudent) => Students.Add(newStudent);

        
        public int countStudents() => Students.Count();
        public override string ToString()
        {
            return "Nome da materia: "+ Name + "\n" + "Ministrada por: " +
                Teacher.ToString() + "\n" + "Quantidade de alunos: " + Students.Count();
        }

        public string getAllStudents()
        {
            var sb = new StringBuilder();

            Students.ForEach(student =>
            {
                sb.AppendLine(student.Name);
            });

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
                return false;

            if(obj.GetType() != this.GetType())
                return false;

            if(this == obj)
                return true;

            SchoolClass other = (SchoolClass) obj;

            if(other.Name == this.Name && this.Teacher.Equals(other.Teacher)
               && this.Students.SequenceEqual(other.Students))
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            int hash = 17;

            hash = hash * 3 + Teacher.GetHashCode();
            hash = hash * 3 + Students.GetHashCode();
            hash = hash * 3 + Name.GetHashCode();

            return hash;    
        }
    }
}
