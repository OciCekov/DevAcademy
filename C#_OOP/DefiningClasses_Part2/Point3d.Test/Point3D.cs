namespace Point3d.Test
{

   // It is exams week so I did'nt have time for both, the university and Telerik. That's why it's only this task. Thanks for checking it out. 
    public struct Point3D
    {
        private static readonly Point3D Start = new Point3D(0, 0, 0);
        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public static Point3D StartPoint
        {
            get { return Start; }

        }
        public Point3D(double xCoordinate, double yCoordinate, double zCoordinate)
            : this()
        {
            X = xCoordinate;
            Y = yCoordinate;
            Z = zCoordinate;
        }

        public override string ToString()
        {
            return string.Format("X: {0:F2}\nY: {1:F2}\nZ: {2:F2}", X, Y, Z);
        }
    }
}
