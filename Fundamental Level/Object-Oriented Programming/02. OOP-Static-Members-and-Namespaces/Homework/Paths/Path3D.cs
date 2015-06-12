using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclidian3dSpace
{
    public class Path3D
    {
        static void Main(string[] args)
        {
            List<Point3D> myPath = new List<Point3D>();
            myPath.Add(new Point3D(-3, 56, 435));
            myPath.Add(new Point3D(43, -2, 948));
            myPath.Add(new Point3D(0.23, 34.45, 87));
            myPath.Add(new Point3D(65, 32, 948));
            myPath.Add(new Point3D(879, -24, 1));
            myPath.Add(new Point3D(12, 0.76, 0.8769));
            Storage.SavePath(myPath);

            List<Point3D> newPath = Storage.LoadPath("ExistPath.txt");
        }
    }
}
