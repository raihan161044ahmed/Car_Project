using Car_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Project.Models
{

    public class Agency : Person
    {
        public string location { get; private set; }
        public double Contact { get; set; }
        public Payment payment { get; set; }

        private bool isCarServiceSupported { get; set; }

        public Agency(string firstName, string lastName, string location)
          : base(firstName, lastName,null,0)
        {
            this.location = location;
        }
        /* public string GetLocation()
         {
             return location;
         }*/
        public string Service()
        {
            if (!isCarServiceSupported)
            {
                isCarServiceSupported = true;
                return "We will provide you after sell service...Hurrah!!!";
            }
            else
            {
                return "Sorry, no service is available.";
            }
        }

    }
}