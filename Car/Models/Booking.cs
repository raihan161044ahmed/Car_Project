using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Project.Models
{
    public class Booking
    {
        public DateTime Date { get; set; }
        public int qty { get; set; }
        public Car car { get; set; }
        public Person person { get; set; }
        /*
                public Booking(string firstName, string lastName, string location)
                  : base(firstName, lastName)
                {

                }*/
        public Booking(Car car,Person person,int qty) {
            this.person=person;
            this.qty = qty;
            this.car = car;

        }
        public double GetPrice()
        {
            return car.price;
        }
        public double GetTotalPrice()
        {
            return car.price * qty;
        }
        public string GetBookingInfo()
        {

            string message = $"Booking: {car.brand}-{car.color} Unit Price: {car.price} Quantity:{qty}" + Environment.NewLine; ;
            message += $"UserInfo For Agency:{person.FullName}   Location:{person.location}   Contact:{person.contact}  Date:{Date.ToShortDateString()}\"";
            return message;
        }
    }
}
