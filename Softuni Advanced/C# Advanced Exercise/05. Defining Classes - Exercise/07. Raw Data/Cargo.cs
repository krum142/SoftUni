using System;
using System.Collections.Generic;
using System.Text;

namespace SoftuniParking
{
    class Cargo
    {
        private int cargoWeigh;
        private string cargoType;

        public Cargo(int cargoWeigh, string cargoType)
        {
            this.cargoType = cargoType;
            this.cargoWeigh = cargoWeigh;
        }

        public int Weigh
        {
            get => this.cargoWeigh;
            set => this.cargoWeigh = value;
        }
        public string Type
        {
            get => this.cargoType;
            set => this.cargoType = value;
        }
    }
}
