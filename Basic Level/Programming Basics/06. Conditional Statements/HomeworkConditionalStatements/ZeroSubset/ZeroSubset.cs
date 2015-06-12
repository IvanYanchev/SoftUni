using System;

    class ZeroSubset
    {
        static void Main()
        {
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Въведете число {0}: ", i+1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                if (i < 4)
                {
                    for (int j = i + 1; j < 5; j++)
                    {
                        if (j < 4)
                        {
                            for (int k = j ; k < 5; k++)
                            {
                                if (k == j)
                                {
                                    sum = numbers[i] + numbers[j];
                                    if (sum == 0) Console.WriteLine("{0} + {1} = {2}", numbers[i], numbers[j], sum);
                                }
                                else if (k < 4)
                                {
                                    for (int l = k; l < 5; l++)
                                    {
                                        if (l == k)
                                        {
                                            sum = numbers[i] + numbers[j] + numbers[k];
                                            if (sum == 0) Console.WriteLine("{0} + {1} + {2} = {3}", numbers[i], numbers[j], numbers[k], sum);
                                        }
                                        else if (l < 4)
                                        {
                                            for (int m = l; m < 5; m++)
                                            {
                                                if (m == l)
                                                {
                                                    sum = numbers[i] + numbers[j] + numbers[k] + numbers[l];
                                                    if (sum == 0) Console.WriteLine("{0} + {1} + {2} + {3} = {4}", numbers[i], numbers[j], numbers[k], numbers[l], sum);
                                                }
                                                else
                                                {
                                                    sum = numbers[i] + numbers[j] + numbers[k] + numbers[l] + numbers[m];
                                                    if (sum == 0) Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", numbers[i], numbers[j], numbers[k], numbers[l], numbers[m], sum);
                                                }
                                                
                                            }
                                        }
                                        else
                                        {
                                            sum = numbers[i] + numbers[j] + numbers[k] + numbers[l];
                                            if (sum == 0) Console.WriteLine("{0} + {1} + {2} + {3} = {4}", numbers[i], numbers[j], numbers[k], numbers[l], sum);
                                        }
                                    }
                                }
                                else
                                {
                                    sum = numbers[i] + numbers[j] + numbers[k];
                                    if (sum == 0) Console.WriteLine("{0} + {1} + {2} = {3}", numbers[i], numbers[j], numbers[k], sum);
                                }
                            }
                        }
                        else
                        {
                            sum = numbers[i] + numbers[j];
                            if (sum == 0) Console.WriteLine("{0} + {1} = {2}", numbers[i], numbers[j], sum);
                        }
                    }
                }
            }
        }
    }