

namespace Point3d.Test
{
    using System;
    using System.IO;
    public static class PathsStorage
    {
        public static void Save(Path path)
        {
            var writePoints = new StreamWriter(@"../../Points.txt");
            using (writePoints)
            {
                foreach (var point in path.PointPath)
                {
                    writePoints.WriteLine("{0}*{1}*{2}", point.X, point.Y, point.Z);
                    writePoints.Flush();
                }
            }
        }

        public static Path Load()
        {
            var loaded = new Path();

            var readPoints = new StreamReader(@"../../Points.txt");
            using (readPoints)
            {
                while (readPoints.Peek()>=0)
                {
                    string line = readPoints.ReadLine();
                    string[] splitted = line.Split(new[] {'*'}, StringSplitOptions.RemoveEmptyEntries);
                    loaded.AddPaths(new Point3D(double.Parse(splitted[0]), double.Parse(splitted[1]),double.Parse(splitted[2])));

                }
            }
            return loaded;
        }
    }
}
