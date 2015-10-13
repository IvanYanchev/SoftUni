using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBoxInBox
{
    class FitBoxInBox
    {
        static void Main(string[] args)
        {
            List<int[]> box = new List<int[]>();
            int[] box1 = new int[3];
            box1[0] = int.Parse(Console.ReadLine());
            box1[1] = int.Parse(Console.ReadLine());
            box1[2] = int.Parse(Console.ReadLine());
            box.Add(box1);

            int[] box2 = new int[3];
            box2[0] = int.Parse(Console.ReadLine());
            box2[1] = int.Parse(Console.ReadLine());
            box2[2] = int.Parse(Console.ReadLine());
            box.Add(box2);

            int smaller = 0;
            int bigger = 1;
            if (box[1][0] + box[1][1] + box[1][2] < box[0][0] + box[0][1] + box[0][2])
            {
                smaller = 1;
                bigger = 0;
            }

            if (box[smaller][0] < box[bigger][0] && box[smaller][1] < box[bigger][1] && box[smaller][2] < box[bigger][2])
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", box[smaller][0], box[smaller][1], box[smaller][2], box[bigger][0], box[bigger][1], box[bigger][2]);
            }
        }
    }
}
