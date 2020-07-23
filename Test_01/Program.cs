using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_01
{
  internal class Program
  {
    static void Main()
    {

      EnmType enm = EnmType.VicePresident;
      GetTypeEnm(enm);


      Console.ReadLine();
    }

    private static void GetTypeEnm(EnmType e)
    {
      switch (e)
      {
        case EnmType.VicePresident:
          Console.WriteLine($"Вы {EnmType.VicePresident}");
          break;
        case EnmType.Manager:
          Console.WriteLine($"Вы {EnmType.Manager}");
          break;
        case EnmType.Contractor:
          Console.WriteLine($"Вы {EnmType.Contractor}");
          break;
      }
    }
  }
}
