using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
   internal class Program
  {
    static void Main()
    {

      Rectangle r1 = new Rectangle("First Rectangle", 10, 25, 10, 25);

      Rectangle r2 = r1;

      r2.RectInfo.InfoString = "New Rect Info";
      r2.RectBottom = 4444;

      r1.DisplayView();
      r2.DisplayView();

      Console.ReadLine();
    }
  }
}
