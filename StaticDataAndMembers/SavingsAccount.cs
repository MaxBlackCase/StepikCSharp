using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
  class SavingsAccount
  {
    public double currBalance;
    public static double currInterestRate;

    public SavingsAccount(double balance)
    {
      currBalance = balance;
    }

    static SavingsAccount()
    {
      Console.WriteLine("Is static ctor!");
      currInterestRate = 0.04;
    }
    public static void SetInterestRest(double newRate) => currInterestRate = newRate;

    public static double GetInterestRest() => currInterestRate;

  }
}
