using System;

namespace WaitForExit
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Press CTRL+C to exit...");
            CtrlC.Wait();
        }
    }
}
