using System;
using System.Collections.Generic;
using System.Text;

namespace SoftuniParking
{
    class Tire
    {
        private double tirePressure;
        private int tireAge;

        public Tire(double tirePressure,int tireAge)
        {
            this.tireAge = tireAge;
            this.tirePressure = tirePressure;
        }
        public double Pressure
        {
            get => this.tirePressure;
            set => this.tirePressure = value;
        }
        public int Age
        {
            get => this.tireAge;
            set => this.tireAge = value;
        }
    }
}
