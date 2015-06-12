using System;

    class OddAndEvenProduct
    {
        static void Main()
        {
            string str = Console.ReadLine();
            string[] numbers = str.Split(' ');
            int productOdd = 1;
            int productEven = 1;

            for (int i = 0; i < numbers.Length; i += 2)
            {
                productOdd *= int.Parse(numbers[i]);
                if (i + 1 == numbers.Length)
                {
                    break;
                }
                productEven *= int.Parse(numbers[i + 1]);
            }

            if (productOdd == productEven)
            {
                Console.WriteLine("yes");
                Console.WriteLine("{0}", productOdd);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}", productOdd);
                Console.WriteLine("even_product = {0}", productEven);
            }
        }
    }