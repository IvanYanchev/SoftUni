﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Euclidian3dSpace
{
    public static class Storage
    {
        public static List<Point3D> LoadPath(string fileName)
        {
            List<Point3D> path3D = new List<Point3D>();
            string fileNamePath = string.Format("{0}{1}", "../../", fileName);

            if (File.Exists(fileNamePath))
            {
                using (var reader = new StreamReader(fileNamePath))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        double[] coordinates = line.Split(new char[] { '{', '}', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                        path3D.Add(new Point3D(coordinates[0], coordinates[1], coordinates[2]));
                        line = reader.ReadLine();
                    }
                }
            }
            else
	        {
                Console.WriteLine("The source file not found. Path was not loaded.");
                path3D = null;
	        }

            return path3D;
        }

        public static void SavePath(List<Point3D> path3D)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            using (var writer = new StreamWriter("../../NewPath.txt"))
            {
                foreach (var point in path3D)
                {
                    writer.WriteLine(point);
                }
            }
        }
    }
}