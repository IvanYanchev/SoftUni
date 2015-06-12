using System;

class OddAndEvenJumps
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());
        inputString = inputString.ToLower();
        char[] ch = inputString.ToCharArray();
        int letterIndex = 1;
        long sumOdd = 0L;
        long sumEven = 0L;
        int indexOdd = 1;
        int indexEven = 1;

        for (int i = 0; i < ch.Length; i++)
        {
            if (ch[i] >= 'a' && ch[i] <= 'z')
            {
                if (letterIndex % 2 == 0)
                {
                    if (indexEven < evenJump)
                    {
                        sumEven = sumEven + ch[i];
                        indexEven++;
                    }
                    else
                    {
                        sumEven = sumEven * ch[i];
                        indexEven = 1;
                    }
                }
                else
                {
                    if (indexOdd < oddJump)
                    {
                        sumOdd = sumOdd + ch[i];
                        indexOdd++;
                    }
                    else
                    {
                        sumOdd = sumOdd * ch[i];
                        indexOdd = 1;
                    }
                }
                letterIndex++;
            }
        }
        Console.WriteLine("Odd: {0}", sumOdd.ToString("X"));
        Console.WriteLine("Even: {0}", sumEven.ToString("X"));
    }
}
