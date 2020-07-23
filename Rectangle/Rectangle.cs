using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
  internal struct Rectangle
  {
    public ShapeInfo RectInfo;
    public int RectLeft, RectTop, RectRight, RectBottom;

    public Rectangle(string info, int left, int top, int right, int bottom)
    {

      RectInfo = new ShapeInfo(info);
      RectLeft = left; RectTop = top;
      RectRight = right; RectBottom = bottom;

    }

    public void DisplayView()
    {
      Console.WriteLine("String: {0} Left: {1} Top: {2} Right: {3} Bottom: {4}",RectInfo.InfoString, RectLeft, RectTop, RectRight, RectBottom);
    }
  }
}
