using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Engine
    {
        private int speed;
        private int power;

        public Engine(int speed , int power)
        {
            this.speed = speed;
            this.power = power;
        }
        public Engine()
        {

        }

        public int Speed
        {
            get => speed;
            set => speed = value;
        }

        public int Power
        {
            get => power;
            set => power = value;
        }
    }
}
