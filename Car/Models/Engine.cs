using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Project.Models
{
    public class Engine
    {
        private bool isStarted { get; set; }
        private bool isAccelarated { get; set; }

        public int EngineHorsePower { get; set; }
        public string EngineModel { get; set; }
        public string EngineBrand { get; set; }


        public string Start()
        {
            if (!isStarted)
            {
                isStarted = true;
                return "Car is started...";
            }
            else
            {
                return "Car is already started";
            }
        }

        public string Accelarate()
        {
            if (!isStarted)
            {
                return "Please start the car first!";
            }

            if (!isAccelarated)
            {
                isAccelarated = true;
                return "Engine is accelarating...";
            }
            else
            {
                return "Engine is already in accelaration";
            }
        }
    }
}