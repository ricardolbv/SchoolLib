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
    }
}
