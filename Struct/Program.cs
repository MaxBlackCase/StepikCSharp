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

      Point _point;
      _point.X = 15;
      _point.Y = 562;

      _point.Display();
      _point.Decrement();
      _point.Display();

      Console.ReadLine();

    }
  }
}
