using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer_Producer
{
  public class Student
  {
    /// <summary>
    /// Matrícula
    /// </summary>
    private string _registration;
    private string _name;
    public string Registration { get => _registration; set => _registration = value; }
    public string Name { get => _name; set => _name = value; }

    public Student(string reg, string name)
    {
      Registration = reg;
      Name = name;
    }
  }
}
