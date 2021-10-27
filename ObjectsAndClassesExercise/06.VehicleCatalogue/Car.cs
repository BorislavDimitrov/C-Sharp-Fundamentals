using System;
using System.Collections.Generic;
using System.Text;

namespace _06.VehicleCatalogue
{
    public class Car
    {
        public string VehicleType { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public Car(string vehicleType , string model , string color , int horsepower)
        {
            VehicleType = vehicleType;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }
    }
}
