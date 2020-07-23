using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
  internal struct Point
  {



    public int X;
    public int Y;

    public Point(int XPos, int YPos)
    {
      X = XPos;
      Y = YPos;
    }

    public void Increment()
    {
      X++; Y++;
    }

    public void Decrement()
    {
      X--; Y--;
    }

    public void Display()
    {
      Console.WriteLine("X: {0}, Y: {1}", X, Y);
    }

  }
}
