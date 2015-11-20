using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclidian3dSpace
{
    class ProgramMain
    {
        static void Main()
        {
            Path3D myPath = new Path3D(new Point3D(-3, 56, 435), new Point3D(43, -2, 948), new Point3D(43, -2, 948), new Point3D(0.23, 34.45, 87));

            myPath.AddPoint(new Point3D(65, 32, 948));
            myPath.AddPoint(new Point3D(879, -24, 1));
            myPath.AddPoint(new Point3D(12, 0.76, 0.8769));


            Storage.SavePath(myPath);

            Path3D newPath = Storage.LoadPath("ExistPath.txt");
        }
    }
}
