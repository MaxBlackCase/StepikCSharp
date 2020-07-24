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

      Employee joe = new Employee("Joe", 15, 178);

      joe.Age++;

      Console.WriteLine("Name: {0}, Age: {1}, Pay: {2}", joe.Name, joe.Age, joe.Pay);

      Console.ReadLine();

      

    }
  }
}
