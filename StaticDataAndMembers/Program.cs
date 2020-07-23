using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
  class Program
  {
    static void Main(string[] args)
    {
      SavingsAccount s1 = new SavingsAccount(50);

      Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRest());

      SavingsAccount.SetInterestRest(0.08);

      SavingsAccount s2 = new SavingsAccount(100);

      Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRest());


      Console.ReadLine();
    }
  }
}
