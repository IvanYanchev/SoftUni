using System;

    class PaintBall
    {
        static void Main()
        {
            int[] canvas = new int[10];
            for (int i = 0; i < 10; i++)
            {
                canvas[i] = 1023;
            }
            int paint = -1; // 1 for white; -1 for black
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                else
                {
                    string[] shots = input.Split(' ');
                    int row = int.Parse(shots[0]);
                    int col = int.Parse(shots[1]);
                    int rad = int.Parse(shots[2]);
                    for (int i = row - rad; i <= row + rad; i++)
                    {
                        for (int j = col - rad; j <= col + rad; j++)
                        {
                            if (i >=0 && i <= 9 && j >= 0 && j <= 9)
                            {
                                switch (paint)
                                {
                                    case -1: canvas[i] = canvas[i] & ~(1 << j); break;
                                    case 1: canvas[i] = canvas[i] | (1 << j); break;
                                } 
                            }
                        }
                    }
                    paint = -paint;
                }
            }
            int sum = 0;
            for (int i = 0; i < canvas.Length; i++)
            {
                sum += canvas[i];
            }
            Console.WriteLine(sum);
        }
    }