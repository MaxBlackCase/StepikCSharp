using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
  class Program
  {
    static void Main(string[] args)
    {

      Car c = new Car();

      c.PetName = "BMW";
      c.Speed = 120;

      c.DisplayStats();


      Console.ReadLine();
    }
  }
}
