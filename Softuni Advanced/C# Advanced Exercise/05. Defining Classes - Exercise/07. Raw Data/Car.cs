using System;
using System.Collections.Generic;
using System.Text;

namespace SoftuniParking
{
    class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tires = tires;
        }

        public string Model
        {
            get => this.model;
            private set => this.model = value;
        }
        public Engine Engine
        {
            get => this.engine;
           private set => this.engine = value;
        }
        public Cargo Cargo
        {
            get => this.cargo;
            private set => this.cargo = value;
        }
        public List<Tire> Tire
        {
            get => this.tires;
            private set => this.tires = value;

        }
    }
}
