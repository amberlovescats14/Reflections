using System;
namespace app.BankManagers
{
    public interface IAccountManager
    {
        double GetBalance();

        double AddTotal(double deposit);

    }
}
