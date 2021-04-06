using System;
namespace app.BankManagers
{
    public class AccountManager : IAccountManager
    {
        public string _fiName { get; set; }
        private double _balance = 100.00;

        public AccountManager()
        {
            _fiName = "Amber FCU";
        }

        
        public double AddTotal(double deposit)
        {
            return _balance += deposit;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}
