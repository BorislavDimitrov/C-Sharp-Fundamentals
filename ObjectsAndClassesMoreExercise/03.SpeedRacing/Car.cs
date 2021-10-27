using System;
using System.Collections.Generic;
using System.Text;

namespace _03.SpeedRacing
{
    class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumPerKm;
        private double distanceTraveled = 0;

        public Car()
        {


        }
        public Car(string model , double fuelAmount , double fuelConsumPerKm)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumPerKm = fuelConsumPerKm;
        }

        public string Model
        {
            get => model;
            set => model = value;
        }

        public double FuelAmount
        {
            get => fuelAmount;
            set => fuelAmount = value;
        }

        public double FuelConsumPerKm
        {
            get => fuelConsumPerKm;
            set => fuelConsumPerKm = value;
        }

        public double DistanceTraveled
        {
            get => distanceTraveled;
            set => distanceTraveled = value;
        }

        public bool CheckIfFuelEnough (double distanceToTravel)
        {
            bool isEnough = false;
            double fuelNeeded = fuelConsumPerKm * distanceToTravel;

            if (FuelAmount >= fuelNeeded)
            {
                isEnough = true;
            }

            return isEnough;
        }
    }
}
