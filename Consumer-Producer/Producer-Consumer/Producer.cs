using Producer_Consumer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Producer_Consumer
{
  public class Producer
  {
    public List<Student> LstStudents;
    public int Sequencia;

    public Producer()
    {
      string[] fileLines = File.ReadAllLines("../../Matriculas.txt");
      LstStudents = new List<Student>();
      foreach (string item in fileLines)
      {
        var splitInfo = item.Split(';');
        LstStudents.Add(new Student(splitInfo[0], splitInfo[1]));
      } 
    }
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
        Sequencia++;
      }
    }

    public void CreateListStudentsMonitor()
    {
      while (true)
      {
        Monitor.Enter(this);
        string[] fileLines = File.ReadAllLines("../../Matriculas.txt");
        LstStudents = new List<Student>();
        foreach (string item in fileLines)
        {
          var splitInfo = item.Split(';');
          LstStudents.Add(new Student(splitInfo[0], splitInfo[1]));
        }
        Sequencia++;
        Monitor.Exit(this);
      }
    }
  }
}
