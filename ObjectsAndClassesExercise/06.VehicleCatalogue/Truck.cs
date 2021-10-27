using System;
using System.Collections.Generic;
using System.Text;

namespace _06.VehicleCatalogue
{
    class Truck
    {
        public string VehicleType { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public Truck(string vehicleType , string model , string color , int horsepower)
        {
            VehicleType = vehicleType;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }
    }
}
