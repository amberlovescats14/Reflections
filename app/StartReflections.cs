using System;
using System.Linq;
namespace app
{
    public static class StartReflections
    {
        public static void RunReflections()
        {
            Type manager = typeof(BankManagers.AccountManager);

            var properties = manager.GetFields();
            var methods = manager.GetMethods();

            properties.ToList().ForEach(p => Console.WriteLine(p.Name));

            var getBalance = methods.FirstOrDefault(m => m.Name.ToLowerInvariant().Contains("balance"));
            if (getBalance != null)
            {
                // will invoke
                Console.WriteLine("Found Balance");
            }

        }

    }
}
