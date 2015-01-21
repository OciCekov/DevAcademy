namespace Point3d.Test
{
    using System;
    public static class DistanceBetweenPoints
    {
        public static double DistanceInSpace(Point3D first, Point3D second)
        {
            //This looks like it's working but... my math is not at 100% so there is some doubt about it. 
            return Math.Sqrt(((first.X - second.X) * (first.X - second.X)) + ((first.Y - second.Y) * (first.Y - second.Y)) + ((first.Z - second.Z) * (first.Z - second.Z)));
        }
    }
}
