using System;

namespace Problem_3.Asynchronous_Timer
{
    class ProgramMain
    {
        static void Main()
        {
            AsynchronousTimer asynchronousTimer = new AsynchronousTimer(PrintDateTimeMilliseconds, 10, 200);
            asynchronousTimer.Run();
        }

        static void PrintDateTimeMilliseconds(DateTime nowDateTime)
        {
            Console.WriteLine(
                "{0}:{1}:{2}.{3}",
                nowDateTime.Hour,
                nowDateTime.Minute,
                nowDateTime.Second,
                nowDateTime.Millisecond);
        }
    }
}
