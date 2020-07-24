using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
  class Program
  {
    static void Main(string[] args)
    {

      Employee emp = new Employee();
      emp.GiveBonus(1000);
      emp.DisplayStats();

      emp.Name = "Marvin";
      Console.WriteLine("Emplotee is named: {0}", emp.Name);

      Console.ReadLine();

      

    }
  }
}
