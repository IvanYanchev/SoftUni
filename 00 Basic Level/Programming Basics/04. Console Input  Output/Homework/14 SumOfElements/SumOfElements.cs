using System;

class SumOfElements
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        string[] elements = numbers.Split(' ');
        int elementsCount = elements.Length;
        int element;
        int sumOfAllElements = 0;
        int maxElement = int.MinValue;

        for (int i = 0; i < elementsCount; i++)
        {
            element = int.Parse(elements[i]);
            sumOfAllElements = sumOfAllElements + element;
            if (element > maxElement)
            {
                maxElement = element;
            }
        }

        if (sumOfAllElements == 2 * maxElement)
        {
            Console.WriteLine("Yes, sum={0}", maxElement);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs((sumOfAllElements - 2 * maxElement)));
        }
    }
}

