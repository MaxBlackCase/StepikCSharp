using System;

namespace Struct
{
  internal struct PointRef
  {



    public int X;
    public int Y;

    public PointRef(int XPos, int YPos)
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
