using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Euclidian3dSpace
{
    class ProgramMain
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            Console.WriteLine(Point3D.StartingPoint);

            Point3D np = new Point3D(1.2, 8.4, - 2.5);
            Console.WriteLine(np);
        }
    }
}
