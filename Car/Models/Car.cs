using Car_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Project.Models
{
    public class Car
    {
        public string color { get; set; }
        public string brand { get; set; }
       public double price { get; set; }

        public Car(Engine engine) 
        {
            this.CarEngine = engine;
        }
        public Car()
        {        
        }

        public string Model
        {
            get; set;
        }

        public string Color { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }

        private Engine CarEngine { get; set; }

        public string Start()
        {
            return CarEngine.Start();
        }

        public string Accelarate()
        {
            return CarEngine.Accelarate();
        }

    }
}