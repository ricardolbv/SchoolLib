using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set
            {
                if (value.Contains("@"))
                {
                    _Email = value;
                }
                else
                {
                    throw new Exception(Email + "Must be @!");
                }
            }
        }
    }
}
