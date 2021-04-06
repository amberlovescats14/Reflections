using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Activator.CreateInstance<StartReflections>().RunReflections();
            Console.WriteLine("Hello World!");
        }

    }
}
