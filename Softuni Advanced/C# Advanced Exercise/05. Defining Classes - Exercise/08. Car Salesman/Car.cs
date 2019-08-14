using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    class Car
    {
        private string model;
        private Engine engine;
        private int? weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }
        public Car(string model,Engine engine, int? weight)
            :this(model,engine)
        {
            this.Weight = weight;
        }
        public Car(string model,Engine engine,string color)
            :this(model,engine)
        {
            this.Color = color;
        }
        public Car(string model,Engine engine,string color,int? weigh)
            :this(model,engine)
        {
            this.Weight = weigh;
            this.Color = color;
        }
        public string Model
        {
            get => this.model;
            set => this.model = value;
        }
        public Engine Engine
        {
            get => this.engine;
            private set => this.engine = value;
        }
        public int? Weight
        {
            get => this.weight;
            set => this.weight = value;
        }
        public string Color
        {
            get => this.color;
            set => this.color = value;
        }
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"{Model} {(char)58} ");
            builder.Append(Engine);
            builder.AppendLine($"  Weight: {(Weight == null ? "n/a" : Weight.ToString())}");
            builder.Append($"  Color: {(Color == null ? "n/a" : Color)}");

            return builder.ToString();
        }
    }
}
