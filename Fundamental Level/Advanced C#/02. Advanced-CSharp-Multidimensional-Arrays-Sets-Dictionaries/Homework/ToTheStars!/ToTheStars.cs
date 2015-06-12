using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToTheStars_
{
    class ToTheStars
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> stars = new Dictionary<string, double[]>();

            for (int i = 0; i < 3; i++)
            {
                string starInput = Console.ReadLine();
                string starName = starInput.Split(' ')[0];
                double starXcoord = double.Parse(starInput.Split(' ')[1]);
                double starYcoord = double.Parse(starInput.Split(' ')[2]);
                stars.Add(starName, new double[] { starXcoord, starYcoord });
            }

            string shipInitialCoordinates = Console.ReadLine();
            double shipXcoord = double.Parse(shipInitialCoordinates.Split(' ')[0]);
            double shipYcoord = double.Parse(shipInitialCoordinates.Split(' ')[1]);

            int numberOfMoves = int.Parse(Console.ReadLine());

            for (int n = 0; n <= numberOfMoves; n++)
            {
                string location = "space";
                foreach (var star in stars)
                {
                    if (shipXcoord >= star.Value[0] - 1 && shipXcoord <= star.Value[0] + 1 &&
                        shipYcoord >= star.Value[1] - 1 && shipYcoord <= star.Value[1] + 1)
                    {
                        location = star.Key.ToLower();
                    }
                }
                Console.WriteLine(location);
                shipYcoord++;
            }
        }
    }
}
