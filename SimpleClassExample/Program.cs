using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
  class Program
  {
    static void Main(string[] args)
    {

      Car myCar = new Car("Rolls Royce");

      myCar.PrintState();

      Console.ReadLine();
    }
  }
}
