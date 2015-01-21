namespace Point3d.Test
{
    using System.Collections.Generic;
    public class Path
    {
        private List<Point3D> pointsPath = new List<Point3D>();

        public List<Point3D> PointPath
        {
            get { return this.pointsPath; }
            set { this.pointsPath = value; } 
        }

        public void AddPaths(Point3D newPoint)
        {
            pointsPath.Add(newPoint);
        }
    }
}
