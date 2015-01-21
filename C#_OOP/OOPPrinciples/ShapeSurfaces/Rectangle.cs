namespace ShapeSurfaces
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            double surface = Height * Width;
            return surface;
        }
    }
}
