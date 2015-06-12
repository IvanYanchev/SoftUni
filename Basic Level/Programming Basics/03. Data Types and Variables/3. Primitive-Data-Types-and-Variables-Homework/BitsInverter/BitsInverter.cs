using System;

class BitsInverter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int totalBitsLength = n * 8;
        int numberOfSteps = (totalBitsLength - 1) / step;

        for (int i = 0; i <= numberOfSteps; i++)
        {
            int bitPositionLeftToRight = 1 + i * step;
            int currentElement = bitPositionLeftToRight / 8;
            if (bitPositionLeftToRight % 8 == 0)
            {
                currentElement -= 1;
            }
            int bitPositionRightToLeft = (currentElement + 1) * 8 - bitPositionLeftToRight;

            int bitAtPosition = ((1 << bitPositionRightToLeft) & numbers[currentElement]) >> bitPositionRightToLeft;

            if (bitAtPosition == 0)
            {
                numbers[currentElement] = numbers[currentElement] | 1 << bitPositionRightToLeft;
            }
            else
            {
                numbers[currentElement] = numbers[currentElement] & ~(1 << bitPositionRightToLeft);
            }
        }

        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}