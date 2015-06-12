using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle :BasicShape
    {
        public Triangle(double width, double height)
            : base (width, height)
        {

        }

        public override double CalculateArea()
        {
            double area = (this.Width * this.Height) / 2;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = this.Width + this.Height + Math.Sqrt(this.Width * this.Width + this.Height * this.Height);
            return perimeter;
        }
    }
}
