using System;
namespace app.BankManagers
{
    public interface IAccountManager
    {
        double GetBalance();

        /// <summary>
        /// Add deposit to the balance total
        /// </summary>
        /// <returns>New Balance</returns>
        double AddTotal(double deposit);
    }
}
