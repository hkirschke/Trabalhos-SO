using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Producer_Consumer
{
  class Program
  {
    static void Main(string[] args)
    {
      var producer = new Producer();
      var consumer = new Consumer(producer);

      Thread t1 = new Thread(producer.CreateListStudents);
      Thread t2 = new Thread(consumer.ConsumeMonitor);
      t1.Start();
      t2.Start();
      if (Console.ReadKey().Key == ConsoleKey.T)
      {
        Console.Clear();
        t1.Abort();
        t2.Abort();
        Console.WriteLine("Programa finalizando...");
        Thread.Sleep(2000);
      }
    }
  }
}
