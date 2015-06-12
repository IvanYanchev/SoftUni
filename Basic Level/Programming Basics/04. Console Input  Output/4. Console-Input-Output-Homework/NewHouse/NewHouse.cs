using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int i = 1;

        do
        {
            string roofEnd = new string('-', (n - i) / 2);
            string roofMiddle = new string('*', i);
            string roofLine = roofEnd + roofMiddle + roofEnd;
            Console.WriteLine(roofLine);
            i = i + 2;
        } while (i <= n);

        string floorEnd = "|";
        string floorMiddle = new string('*', n - 2);
        string floorLine = floorEnd + floorMiddle + floorEnd;
        for (int j = 1; j <= n; j++)
        {
            Console.WriteLine(floorLine);
        }
    }
}