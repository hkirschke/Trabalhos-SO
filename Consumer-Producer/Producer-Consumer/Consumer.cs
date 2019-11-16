using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Producer_Consumer
{
  public class Consumer
  {
    private Producer _producer;

    public Producer Producer { get => _producer; set => _producer = value; }

    public Consumer(Producer prod)
    {
      Producer = prod;
    }
    public void ConsumeMonitor()
    {
      try
      {
        Thread.Sleep(1000);
        while (true)
        {
          Monitor.Enter(_producer); 
          foreach (var student in _producer.LstStudents)
          {
            Console.WriteLine($"Matrícula: {student.Registration} - Nome: {student.Name} : Sequencia {_producer.Sequencia.ToString()}");
            Thread.Sleep(1000);
          }
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      finally
      {
        Monitor.Exit(_producer);
      }
    }

    public void ConsumeSemaphoro()
    {
      try
      {
        Semaphore semaphore = new Semaphore(1, 1);
        Thread.Sleep(1000);
        while (true)
        {
          semaphore.WaitOne();
          //Monitor.Enter(_producer);
          foreach (var student in _producer.LstStudents)
          {
            Console.WriteLine($"Matrícula: {student.Registration} - Nome: {student.Name} - Sequencia {_producer.Sequencia.ToString()}");
            //Thread.Sleep(1000);
          }
          semaphore.Release();
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
