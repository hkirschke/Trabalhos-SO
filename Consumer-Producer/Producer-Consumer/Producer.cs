using Consumer_Producer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Producer_Consumer
{
  public class Producer
  {
    public List<Student> LstStudents;
    public Producer()
    {
      string[] fileLines = File.ReadAllLines("../../Matrículas");
      LstStudents = new List<Student>();
      foreach (string item in fileLines)
      {
        var splitInfo = item.Split(';');
        LstStudents.Add(new Student(splitInfo[0], splitInfo[1]));
      }
    }
  }
}
