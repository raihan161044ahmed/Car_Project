// See https://aka.ms/new-console-template for more information

using Car_Project.Models;


var car1 = new Car()
{

   brand="BMW",
   color="blue",
   price=double.Parse("100000")

};
var car2 = new Car()
{
    brand = "Lamborghini",
    color = "red",
    price = double.Parse("200000")
};

var person1 = new Person("Raihan", "Ahmed", "Dhaka",01521565);
var person2 = new Person("md.", "Nahid", "chittagong", 123456789);
Payment payment = new Payment();
payment.AddProduct(person1,car1, 2);
payment.AddProduct(person2 ,car2, 3);
payment.DiscountPercentage = 15;
payment.VATPercentage = 10;

Console.WriteLine(payment.GetVoucher());
