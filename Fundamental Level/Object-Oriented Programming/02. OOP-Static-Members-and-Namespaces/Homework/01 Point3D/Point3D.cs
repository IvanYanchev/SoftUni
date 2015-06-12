using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclidian3dSpace
{
    public class Point3D
    {
        private static double startX = 0;
        private static double startY = 0;
        private static double startZ = 0;

        private double x = 0;
        private double y = 0;
        private double z = 0;

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public Point3D()
        {

        }

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static string GetStartingCoordinates()
        {
            return string.Format("{{{0}, {1}, {2}}}", startX, startY, startZ);
        }

        public override string ToString()
        {
            return string.Format("{{{0}, {1}, {2}}}", this.x, this.y, this.z);
        }
    }
}
