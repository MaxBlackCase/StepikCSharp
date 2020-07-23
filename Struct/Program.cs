using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
  internal class Program
  {
    static void Main(string[] args)
    {

      Point _p1 = new Point(10, 10);
      Point _p2 = _p1;

      _p1.Display();
      _p2.Display();

      _p1.X = 100;

      Console.WriteLine("\nChanges _p1.X\n");
      _p1.Display();
      _p2.Display();

      Console.ReadLine();

    }
  }
}
