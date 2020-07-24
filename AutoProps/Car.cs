using System;

namespace AutoProps
{
  class Car
  {

    public string PetName { get; set; }
    public int Speed { get; set; }
    public string CarColor { get; set; }


    public void DisplayStats()
    {
      Console.Write("Name: {0}\nSpeed: {1}\nColor: \n", PetName, Speed, CarColor);
    }
  }
}
