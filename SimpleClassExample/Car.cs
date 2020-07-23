using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{

  class Car
  {

    public string petName;
    public int currSpeed;

    public Car()
    {
      currSpeed = 10;
      petName = "Chuck";
    }
    public Car(string pn)
    {
      petName = pn;
      currSpeed = 10;
    }
    public Car(string pn, int cs)
    {
      petName = pn;
      currSpeed = cs;
    }

    public void PrintState() { for (var i = 0; i < 10; i++) { Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed += 5); }; }
    public void SpeedUp(int delta) => currSpeed += delta;
  }
}
