using System;

class MagicStrings
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());

        string[] letters = { "k", "n", "p", "s" };
        int[] numbers = { 1, 4, 5, 3 };
        bool isNotFoundMagicString = true;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    for (int l = 0; l < 4; l++)
                    {
                        for (int m = 0; m < 4; m++)
                        {
                            for (int n = 0; n < 4; n++)
                            {
                                for (int o = 0; o < 4; o++)
                                {
                                    for (int p = 0; p < 4; p++)
                                    {
                                        if (Math.Abs(numbers[i] + numbers[j] + numbers[k] + numbers[l] - (numbers[m] + numbers[n] + numbers[o] + numbers[p])) == diff)
                                        {
                                            Console.WriteLine(letters[i] + letters[j] + letters[k] + letters[l] + letters[m] + letters[n] + letters[o] + letters[p]);
                                            isNotFoundMagicString = false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (isNotFoundMagicString) Console.WriteLine("No");
    }
}