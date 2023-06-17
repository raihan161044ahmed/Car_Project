using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Project.Models
{
    public class Person
    {
        public string location { get; set; }
        public double contact { get; set; }
    

        public Person(string firstName, string middleName, string lastName) : this(firstName, lastName, null, 0)
        {

            this.MiddleName = middleName;
        }
        public Person(string firstName, string lastName, string location, double contact) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.location = location;
            this.contact = contact;
           
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