using System;

namespace Problem_3.String_Disperser
{
    class ProgramMain
    {
        static void Main()
        {
            StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }

        }
    }
}