using System;

namespace Struct
{
  internal class Program
  {
    static void Main(string[] args)
    {

      PointRef _p1 = new PointRef(10, 10);
      PointRef _p2 = _p1;

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
