using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        switch (n)
        {
            case 1:
                {
                    Console.WriteLine("0");
                    break;
                }
            case 2:
                {
                    Console.WriteLine("0, 1");
                    break;
                }
            default:
                {
                    int[] fiboNumbers = new int[n];
                    fiboNumbers[0] = 0;
                    fiboNumbers[1] = 1;
                    for (int i = 2; i < (n); i++)
                    {
                        fiboNumbers[i] = fiboNumbers[i - 2] + fiboNumbers[i - 1];
                    }
                    Console.WriteLine(string.Join(", ", fiboNumbers));
                    break;
                }
        }
    }
}