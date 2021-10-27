using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;

        public Car(string model , Engine engine , Cargo cargo)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
        }

        public string Model
        {
            get => model;
            set => model = value;
        }

        public Engine Engine
        {
            get => engine;
            set => engine = value;
        }

        public Cargo Cargo
        {
            get => cargo;
            set => cargo = value;
        }
    }
}
