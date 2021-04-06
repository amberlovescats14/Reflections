using System;
namespace app
{
    public interface IAccountManager
    {
        public string FIName { get; set; }

        double GetBalance();

        double AddTotal(double deposit);

    }
}
