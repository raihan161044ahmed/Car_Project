using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Project.Models
{
    public class Person
    {
        double balance = 0;
        public Person()
        {
            this.balance = 50;
        }

        public Person(string firstName, string middleName, string lastName) : this(firstName, lastName)
        {

            this.MiddleName = middleName;
        }
        public Person(string firstName, string lastName) : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return GetFullName();
            }
        }

        private string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }
    }
}