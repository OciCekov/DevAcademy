using System;

namespace ShapeSurfaces
{
    class ShapesTest
    {
        static void Main()
        {
            var testRectangle = new Rectangle(2, 2);
            double rectangleSurface = testRectangle.CalculateSurface();
           // Console.WriteLine(rectangleSurface);

            var testTriangle = new Triangle(2, 2);

            double triangleSurface =  testTriangle.CalculateSurface();
          //  Console.WriteLine(triangleSurface);

            var testCircle = new Circle(2.5);

            Shape[] array = { testCircle, testTriangle, testRectangle};
            foreach (var shape in array)
            {
                Console.WriteLine("{0:F1}",shape.CalculateSurface());
            }
        }

       
    }
}
