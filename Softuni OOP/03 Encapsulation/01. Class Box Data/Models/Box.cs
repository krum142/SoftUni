using System;
using System.Runtime.CompilerServices;
using System.Text;
using ClassBoxData.Exeptions;

namespace ClassBoxData.Models
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => this.length;

           private set
            {
                if (value <= 0)
                { 
                    throw  new ArgumentException(ExeptionMessiges.LenghtZeroOrNegativeExeption);
                }
                this.length = value;
            }
        }
        public double Width
        {
            get => this.width;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExeptionMessiges.WidthZeroOrNegativeExeption);
                }
                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;

            set
            {
                if (value <= 0)
                {
                    throw  new ArgumentException(ExeptionMessiges.HeightZeroOrNegativeExeption);
                }
                this.height = value;
            }
        }

        public double LeteralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * (this.Length * this.Height)
                                        + (2 * this.Width * this.Height);
            return lateralSurfaceArea;
        }

        public double SurfaceArea()
        {
            double surfaceArea = (2 * this.Length * this.Width)
                                 + this.LeteralSurfaceArea();
            return surfaceArea;
        }

        public double Volume()
        {
            double volume = this.Length * this.Height * this.Width;
            return volume;
        }
        public override string ToString()
        {
            var Sb = new StringBuilder();

            Sb.AppendLine($"Surface Area - {SurfaceArea():f2}");

            Sb.AppendLine($"Lateral Surface Area - {LeteralSurfaceArea():f2}");

            Sb.AppendLine($"Volume - {Volume():f2}");

            return Sb.ToString().TrimEnd();
        }
    }
}
