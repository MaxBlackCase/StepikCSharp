using System;

namespace RefTypeValTypeParams
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("/n***Новый экземпляр класса Person***/n");
      Person fred = new Person("fred", 12);
      fred.Display();

      Console.WriteLine("/n***Переопределение экземпляра класса Person***/n");
      SendAPersonByValue(fred);
      fred.Display();
      Console.WriteLine("/n***Переопределение экземпляра класса Person по ссылке (ref)***/n");
      SendAPersonByReference(ref fred);
      fred.Display();

      Console.ReadLine();
    }

    static void SendAPersonByValue(Person p)
    {
      p.personAge = 99;
      p = new Person("Andru", 99);
    }

    static void SendAPersonByReference(ref Person p)
    {
      p.personAge = 555;

      p = new Person("Nikki", 999);
    }
  }
}
