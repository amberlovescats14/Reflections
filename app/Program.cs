using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var _balance = 0;

            Type manager = typeof(AccountManager);
            var methods = manager.GetMethods();
            foreach (var item in methods)
            {
                Console.WriteLine(item);
                if (item.Name.ToLowerInvariant().Contains("balance"))
                {
                    Console.WriteLine("Found Balance");
                }
                    
            }
            Console.WriteLine("Hello World!");
        }
    }
}
