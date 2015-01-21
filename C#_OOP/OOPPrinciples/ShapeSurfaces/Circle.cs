using System;

namespace ShapeSurfaces
{
    public class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Wrong radius parameter");
                }
                this.radius = value;
            }
        }

        public Circle(double radius)
            : base(radius, radius)
        {
            this.Radius = radius;
        }

        public override double CalculateSurface()
        {
            double surface = Math.PI * (radius * radius);
            return surface;
        }
    }
}
