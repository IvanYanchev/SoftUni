using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCables
{
    class StudentCables
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int usableLenght = 0; // in centimeters
            int discardLenght = 0;
            int usablePieces = n;
            for (int i = 0; i < n; i++)
            {
                int lenght = int.Parse(Console.ReadLine());
                string measure = Console.ReadLine();
                if (measure == "centimeters" && lenght < 20)
                {
                    usablePieces--;
                    // discardLenght += lenght;
                }
                else
                {
                    switch (measure)
                    {
                        case "centimeters": usableLenght += lenght; break;
                        case "meters": usableLenght += 100 * lenght; break;
                    }
                }
            }
            usableLenght = usableLenght - 3 * (usablePieces - 1);
            int studentCables = usableLenght / 504;
            discardLenght += usableLenght % 504;

            Console.WriteLine(studentCables);
            Console.WriteLine(discardLenght);
        }
    }
}
