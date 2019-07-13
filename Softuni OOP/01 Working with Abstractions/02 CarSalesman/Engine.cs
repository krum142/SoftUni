using System.Text;

namespace P02_CarsSalesman
{
    public class Engine
    {
        private const string offset = "  ";

        public string model;
        public int power;
        public int displacement;
        public string efficiency;

        public Engine(string model, int power)
        {
            this.model = model;
            this.power = power;
            this.displacement = -1;
            this.efficiency = "n/a";
        }

        public Engine(string model, int power, int displacement)
            :this(model,power)
        {
            this.displacement = displacement;
        }

        public Engine(string model, int power, string efficiency)
            :this(model,power)
        {
            this.efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement, string efficiency)
            :this(model,power)
        {
            this.displacement = displacement;
            this.efficiency = efficiency;
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{offset}{this.model}:");

            sb.AppendLine($"{offset}{offset}Power: {this.power}");

            sb.AppendLine($"{offset}{offset}Displacement: {(this.displacement == -1 ? "n/a" : this.displacement.ToString())}");

            sb.AppendLine($"{offset}{offset}Efficiency: {this.efficiency}");

            return sb.ToString().TrimEnd();
        }
    }
}