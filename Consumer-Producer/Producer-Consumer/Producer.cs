
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Producer_Consumer
{
  public class Producer
  {
    public List<Student> LstStudents;
    public int Sequencia;
    public void CreateListStudents()
    {
      while (true)
      {
        string[] fileLines = File.ReadAllLines("../../Matriculas.txt");
        LstStudents = new List<Student>();
        foreach (string item in fileLines)
        {
          var splitInfo = item.Split(';');
          LstStudents.Add(new Student(splitInfo[0], splitInfo[1]));
        }
        Thread.Sleep(6000);
        Sequencia++; 
      }
    }
  }
}
