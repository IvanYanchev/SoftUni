using System;

    class Headphones
    {
        static void Main()
        {
            int diameter = int.Parse(Console.ReadLine());

            string diademTopEnd = new string('-', diameter / 2);
            string diademTopMiddle = new string('*', (2 * diameter + 1) - (diameter / 2) - (diameter /2));
            Console.WriteLine("{0}{1}{0}", diademTopEnd, diademTopMiddle);

            for (int i = 0; i < diameter - 1; i++)
            {
                string diademDashEnd = new string('-', diameter / 2);
                string diademDashMiddle = new string('-', (2 * diameter + 1) - (diameter / 2) - (diameter / 2) - 2);
                Console.WriteLine("{0}{1}{2}{1}{0}", diademDashEnd, '*', diademDashMiddle);
            }

            for (int i = 0; i < diameter / 2; i++)
            {
                string speakerDasheEnd = new string('-', (diameter / 2) - i);
                string speaker = new string('*', 2 * i + 1);
                string speakerDashMiddle = new string('-', (2 * diameter + 1) - 2 * ((diameter / 2) - i) - 2 * (2 * i + 1));
                Console.WriteLine("{0}{1}{2}{1}{0}", speakerDasheEnd, speaker, speakerDashMiddle);
            }

            string speakerMiddleLine = new string('*', diameter);
            Console.WriteLine("{0}{1}{0}", speakerMiddleLine, '-');

            for (int i = diameter / 2 - 1; i >= 0; i--)
            {
                string speakerDasheEnd = new string('-', (diameter / 2) - i);
                string speaker = new string('*', 2 * i + 1);
                string speakerDashMiddle = new string('-', (2 * diameter + 1) - 2 * ((diameter / 2) - i) - 2 * (2 * i + 1));
                Console.WriteLine("{0}{1}{2}{1}{0}", speakerDasheEnd, speaker, speakerDashMiddle);
            }
        }
    }