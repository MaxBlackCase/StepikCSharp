using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
  class Employee
  {

    private string empName;
    private int empID;
    private float currPay;

    public Employee() { }
    public Employee(string name, int id, float pay) {

      empName = name;
      empID = id;
      currPay = pay;

    }

    public void GiveBonus(float amount)
    {
      currPay += amount;
    }

    public void DisplayStats()
    {
      Console.Write("Name: {0} ", Name);
      Console.Write("ID: {0} ", ID);
      Console.Write("Pay: {0} ", Pay);
    }

    public string Name {

      get => empName;
      set
      {
        if (value.Length > 15)
          Console.WriteLine("Error! Name length exceeds 15 characters!");
        else
          empName = value;
      }

    }
    public int ID {
      get => empID;
      set => empID = value;
    }

    public float Pay {

      get => currPay;
      set => currPay = value;
    
    }
  }
}
