using System;
namespace app
{
    public class AccountManager : IAccountManager
    {
        private string _fiName { get; set; }
        private double _balance = 100.00;

        string IAccountManager.FIName { get => _fiName; set => _fiName = value; }

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
