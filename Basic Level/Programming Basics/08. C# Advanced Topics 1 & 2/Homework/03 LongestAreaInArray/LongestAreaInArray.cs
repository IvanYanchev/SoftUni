using System;

class LongestAreaInArray
{
    static void Main()
    {
        // input from console
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = Console.ReadLine();
        }
        // elements count
        string repeatingElement = null;
        int countCurrent = 1;
        int countMax = 0;

        for (int i = 0; i < n - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                countCurrent++;
            }
            else
            {
                countCurrent = 1;
            }
            if (countCurrent > countMax)
            {
                countMax = countCurrent;
                repeatingElement = array[i];
            }
        }
        // output to console
        Console.WriteLine(countMax);
        for (int i = 0; i < countMax; i++)
        {
            Console.WriteLine(repeatingElement);
        }
    }
}