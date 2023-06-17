using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Car_Project.Models
{
    public class Payment
    {
        public List<Booking> booking { get; set; }
        public Person person { get; set; }
        public Car car { get; set; }
        public int DiscountPercentage { get; set; }
        public int VATPercentage { get; set; }
        public DateTime Date { get; set; }
        public Payment() { 
        
        booking = new List<Booking>();
        
        }
        public double GetTotalProductPrice()
        {
            if (booking == null)
            {
                return 0;
            }

            if (booking.Count == 0)
            {
                return 0;
            }

            double totalProductPrice = 0;

            foreach (Booking item in booking)
            {
                totalProductPrice += item.GetTotalPrice();
            }

            return totalProductPrice;
        }
        public double GetDiscountAmount()
        {
            return GetTotalProductPrice() * (DiscountPercentage / 100.0);
        }

        public double GetVATAmount()
        {
            return GetTotalProductPrice() * (VATPercentage / 100.0);
        }
        public double GetTotalPrice()
        {
            return GetTotalProductPrice() + GetVATAmount() - GetDiscountAmount();
        }
        public bool AddProduct(Person person, Car car, int qty)
        {

            if (booking == null)
            {
                return false;
            }

            var payment = new Booking(car,person, qty);
            booking.Add(payment);
            return true;
        }
        public string GetVoucher()
        {
            string message = "";

            message += $"Date: {Date.ToShortDateString()}" + Environment.NewLine;
            foreach (Booking item in booking)
            {
                message += item.GetBookingInfo() + Environment.NewLine;
            }
            message += $"--------------------------------------------------------------" + Environment.NewLine; ;
            message += $"Car Price: {GetTotalProductPrice()}" + Environment.NewLine;
            message += $"VAT Amount: {GetVATAmount()}" + Environment.NewLine;         
            message += $"Discount Amount: {GetDiscountAmount()}" + Environment.NewLine;
            message += $"--------------------------------------------------------------" + Environment.NewLine; ;     
            message += $"Total: {GetTotalPrice()}" + Environment.NewLine;

            return message;
        }
    }
}
