using System;
using System.Linq;
using app.BankManagers;

namespace app
{
    public class StartReflections
    {
        public void RunReflections()
        {
            Type managerType = typeof(AccountManager);

            var constructor = managerType.GetConstructor(Array.Empty<Type>());
            var properties = managerType.GetFields().ToList();
            var methods = managerType.GetMethods();

            properties.ForEach(p => Console.WriteLine(p.GetType().FullName));

            var getBalance = methods.FirstOrDefault(m => m.Name.ToLowerInvariant().Contains("balance"));
            if (getBalance != null)
            {
                var balance = getBalance.Invoke(constructor.Invoke(Array.Empty<object>()), Array.Empty<Object>());
                Console.WriteLine($"Found Balance: {balance}");
            }

        }

    }
}
