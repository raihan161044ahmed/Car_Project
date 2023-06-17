using Car_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Project.Models
{

    public class Agency 
    {
        public Payment payment { get; set; }
        public Person person { get; set; }


        public Agency(Person person, Payment payment)
         
        {
            this.person = person;
            this.payment = payment;
        }
    

    }
}