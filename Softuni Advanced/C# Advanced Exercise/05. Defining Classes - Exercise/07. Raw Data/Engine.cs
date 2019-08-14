using System;
using System.Collections.Generic;
using System.Text;

namespace SoftuniParking
{
    class Engine
    {
        private int engineSpeed;
        private int enginePower;

        public Engine(int engineSpeed,int enginePower)
        {
            this.engineSpeed = engineSpeed;
            this.enginePower = enginePower;
        }

        public int Power
        {
            get => this.enginePower;
            set => this.enginePower = value;
        }

        public int Speed
        {
            get => this.engineSpeed;
            set => this.engineSpeed = value;
        }
    }
}
