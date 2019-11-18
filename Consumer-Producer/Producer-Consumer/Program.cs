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
    private static Consumer consumer;
    private static Thread t1;
    private static Thread t2;
    static void Main(string[] args)
    {
      producer = new Producer();
      consumer = new Consumer();
      //ThreadSemaphoro();
      ThreadMonitor();

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
    private static void ThreadMonitor()
    {
      t1 = new Thread(producer.CreateListStudentsMonitor);
      t2 = new Thread(consumer.ConsumeMonitor);
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
    internal class Consumer
    {
      public void ConsumeMonitor()
      {
        while (true)
        {
          lock (producer)
          {
            lock (consumer)
            {
              foreach (var student in producer.LstStudents)
              {
                Console.WriteLine($"Matrícula: {student.Registration} - Nome: {student.Name} : Sequencia {producer.Sequencia.ToString()}");
                Thread.Sleep(1000);
              }
            }
          }
        }
      }
    }

    internal class Producer
    {
      public List<Student> LstStudents;
      public int Sequencia;
      public Producer()
      {
        AddStudents();
      }

      private void AddStudents()
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
          AddStudents();
          Sequencia++;
        }
      }
      public void CreateListStudentsMonitor()
      {
        while (true)
        {
          lock (producer)
          {
            lock (consumer)
            {
              AddStudents();
              Sequencia++;
            }
          }
        }
      }
    }
  }
}
