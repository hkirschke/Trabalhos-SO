using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer_Producer
{
  public class Consumer
  {
   public void Consume(Student student)
    {
      Console.WriteLine($"Matrícula: {student.Registration} - Nome: {student.Name}");
    }
  }
}
