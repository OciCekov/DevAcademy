namespace Point3d.Test
{
    using System;
    public class Point3DTest
    {
        static void Main()
        {
            var test = new Point3D(5.5, 6, 6);
            Console.WriteLine(test);
            var second = new Point3D(6, 2, 8);
            Console.WriteLine(second);
        }
    }
}
