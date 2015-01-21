namespace ShapeSurfaces
{
    using System;
    public abstract class Shape
    {
        // It sayed it needs to be field, otherwise this two should be autoproperties
        private double width;

        private double height;

        public Shape(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Wrong width parameter");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Wrong height parameter");
                }
                this.height = value;
            }
        }
        public abstract double CalculateSurface();
    }
}
