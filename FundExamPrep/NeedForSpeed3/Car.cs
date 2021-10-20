using System;
using System.Collections.Generic;
using System.Text;

namespace _09.NeedForSpeed3
{
    class Car
    {
        private string name;
        private double mileage;
        private double fuel;

        public Car()
        {

        }

        public Car(string name)
        {
            this.name = name;
        }

        public Car(string name , double mileage , double fuel)
        {
            this.name = name;
            this.mileage = mileage;
            this.fuel = fuel;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public double Mileage
        {
            get => mileage;
            set => mileage = value;
        }

        public double Fuel
        {
            get => fuel;
            set => fuel = value;
        }
    }
}
