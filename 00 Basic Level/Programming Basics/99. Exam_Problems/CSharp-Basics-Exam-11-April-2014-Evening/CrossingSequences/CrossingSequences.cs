using System;
using System.Collections.Generic;

    class CrossingSequences
    {
        static void Main()
        {
            int triboFirst = int.Parse(Console.ReadLine());
            int triboSecond = int.Parse(Console.ReadLine());
            int triboThird = int.Parse(Console.ReadLine());
            int spiralFirst = int.Parse(Console.ReadLine());
            int spiralStep = int.Parse(Console.ReadLine());

            int spiralNext = 0; ;
            int triboNext = 0;
            int i = 1;
            int j = 3;
            int z = 1;

            List<int> spiral = new List<int>();
            spiral.Add(spiralFirst);
            List<int> tribo = new List<int>();
            tribo.Add(triboFirst);
            tribo.Add(triboSecond);
            tribo.Add(triboThird);

            while (spiralNext <= 1000000)
            {
                spiralNext = spiral[i-1] + z * spiralStep;
                spiral.Add(spiralNext);
                i++;
                spiralNext = spiral[i-1] + z * spiralStep;
                spiral.Add(spiralNext);
                i++;
                z++;
            }

            while (triboNext <= 1000000)
            {
                triboNext = tribo[j - 1] + tribo[j - 2] + tribo[j - 3];
                tribo.Add(triboNext);
                j++;
            }

            for (int k = 0; k < spiral.Count; k++)
            {
                for (int l = 0; l < tribo.Count; l++)
                {
                    if (spiral[k] == tribo[l])
                    {
                        Console.WriteLine(spiral[k]);
                        return;
                    }
                }
            }
            Console.WriteLine("No");
        }
    }