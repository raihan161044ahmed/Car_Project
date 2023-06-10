// See https://aka.ms/new-console-template for more information

using Car_Project.Models;


var engine = new Engine()
{

    EngineModel = "H932klsd",
    EngineBrand = "Lamborghini",
    EngineHorsePower = 6000

};

var car = new Car(engine);

var agency = new Agency("Raihan", "Ahmed", "Dhaka")
{
    Contact = double.Parse("120015")
};
Console.WriteLine(agency.Contact);

string carInfo = "";
Console.WriteLine("Start Car...");
carInfo = car.Start();
Console.WriteLine(carInfo);


Console.WriteLine("Innitiate Accelaration...");
carInfo = car.Accelarate();
Console.WriteLine(carInfo);

Console.WriteLine("Checking Agency service.....");


carInfo = agency.Service();
Console.WriteLine(agency.FullName + ", " + carInfo + "Your Location:" + agency.location);