using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    class Engine
    {
        private string model;
        private int power;
        private int? displacement;
        private string efficiency;
        public Engine(string model , int power)
        {
            this.Model = model;
            this.Power = power;
        }
        public Engine(string model, int power,int? displacement)
            :this(model,power)
        {
            this.Displacement = displacement;
        }
        public Engine(string model, int power, string efficiency)
            : this(model,power)
        {
            this.Efficiency = efficiency;
        }
        public Engine(string model, int power,int? displacement ,string efficiency)
            : this(model, power)
        {
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }
        public string Model
        {
            get => this.model;
           private set => this.model = value;
        }
        public int Power
        {
            get => this.power;
            private set => this.power = value;
        }
        public int? Displacement
        {
            get => this.displacement;
            private set => this.displacement = value;
        }
        public string Efficiency
        {
            get => this.efficiency;
           private set => this.efficiency = value;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"  {Model} {(char)58} ");
            builder.AppendLine($"    Power: {Power} {(char)58} ");
            builder.AppendLine($"    Displacement: {(Displacement == null ? "n/a" : Displacement.ToString())} {(char)58} ");
            builder.AppendLine($"    Efficiency: {(Efficiency == null ? "n/a" : Efficiency.ToString())} {(char)58} ");

            return builder.ToString();
        }

    }
}
