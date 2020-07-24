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
    private int empAge;
    public string Name
    {

      get => empName;
      set
      {
        if (value.Length > 15)
          Console.WriteLine("Error! Name length exceeds 15 characters!");
        else
          empName = value;
      }

    }
    public int Age {

      get => empAge;
      set => empAge = value;

    }
    public int ID
    {
      get => empID;
      set => empID = value;
    }

    public float Pay
    {

      get => currPay;
      set => currPay = value;

    }

    public Employee() { }
    public Employee(string name, int id, float pay) 
      : this(name, 0, id, pay) { }
    public Employee(string name, int age, int id, float pay)
    {
      empName = name;
      empID = id;
      empAge = age;
      currPay = pay;
    }
    public void GiveBonus(float amount)
    {
      currPay += amount;
    }

    public void DisplayStats()
    {
      Console.Write("Name: {0} ", empName);
      Console.Write("ID: {0} ", empID);
      Console.Write("Age: {0} ", empAge);
      Console.Write("Pay: {0} ", currPay);
    }

   
  }
}
