using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Producer_Consumer
{
  class Program
  {
    private static Semaphore Pool;
    private static Producer producer;
    private static Thread t1;
    private static Thread t2;
    static void Main(string[] args)
    {
      producer = new Producer();
      ThreadSemaphoro();

      //var consumer = new Consumer(producer);
      //Thread tA = new Thread(producer.CreateListStudents);
      //Thread tB = new Thread(consumer.ConsumeMonitor);
      //tA.Start();
      //tB.Start();

      if (Console.ReadKey().Key == ConsoleKey.T)
      {
        Console.Clear();
        t1.Abort();
        t2.Abort();
        ProgramFinalize();
      }
    }
    private static void ProgramFinalize()
    {
      Console.Clear();
      Console.WriteLine("Programa finalizando...");
      Thread.Sleep(2000);
    }
    private static void ThreadSemaphoro()
    {
      Pool = new Semaphore(1, 1); 
      t1 = new Thread(new ThreadStart(CreateListStudentsSemaphoro))
      {
        Name = "SemaphoroThread_CreateListStudents"
      }; 
      t2 = new Thread(new ThreadStart(ConsumeSemaphoro))
      {
        Name = "SemaphoroThread_ConsumeSemaphoro"
      }; 
      t1.Start();
      t2.Start();
    }
    public static void CreateListStudentsSemaphoro()
    {
      while (true)
      {
        string[] fileLines = File.ReadAllLines("../../Matriculas.txt");
        producer.LstStudents = new List<Student>();
        Pool.WaitOne();
        foreach (string item in fileLines)
        {
          var splitInfo = item.Split(';');
          producer.LstStudents.Add(new Student(splitInfo[0], splitInfo[1]));
        } 
        Pool.Release();
        producer.Sequencia++;
      }
    }
    public static void ConsumeSemaphoro()
    {
      try
      {
        while (true)
        {
          Pool.WaitOne();
          foreach (var student in producer.LstStudents)
          {
            Console.WriteLine($"Matrícula: {student.Registration} - Nome: {student.Name} - Sequencia {producer.Sequencia.ToString()}");
            Thread.Sleep(500);
          }
         Pool.Release();
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
