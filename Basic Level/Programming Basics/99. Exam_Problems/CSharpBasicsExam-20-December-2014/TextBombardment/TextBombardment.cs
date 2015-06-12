using System;

    class TextBombardment
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int lineWidth = int.Parse(Console.ReadLine());
            int height = text.Length / lineWidth + 1;
            if (text.Length % lineWidth == 0)
            {
                height = height - 1;
            }

            char[,] charArray = new char[height, lineWidth];
            char[] characters = text.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                int indexRow = i / lineWidth;
                int indexCol = i % lineWidth;
                charArray[indexRow, indexCol] = characters[i];
            }

            string textLinesToBeBombarded = Console.ReadLine();
            string[] linesToBeBombarded = textLinesToBeBombarded.Split(' ');
            for (int l = 0; l < linesToBeBombarded.Length; l++)
            {
                int line = int.Parse(linesToBeBombarded[l]);
                bool theCharIsNotSpace = false;
                for (int k = 0; k < height; k++)
                {
                    if (charArray[k, line] == ' ' && theCharIsNotSpace)
                    { 
                        break;
                    }
                    else if (charArray[k, line] != ' ')
                    {
                        charArray[k, line] = ' ';
                        theCharIsNotSpace = true;
                    }
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < lineWidth; j++)
                {
                    if (i * lineWidth + j > text.Length)
                    {
                        break; 
                    }
                    else
                    {
                        Console.Write(charArray[i, j]);
                    }
                }
            }

        }
    }