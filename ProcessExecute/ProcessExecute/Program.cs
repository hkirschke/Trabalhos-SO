using System;
using System.Diagnostics;
using System.Threading;

namespace ProcessExecute
{
  class Program
  {
    private static Thread _thread;
    static void Main(string[] args)
    {
      try
      {
        Console.WriteLine("Gerando nova thread para execução em paralelo");
        Console.WriteLine("Thread principal iniciada");
        Thread.CurrentThread.Name = "Principal - Program.cs - ProcessExecute"; 
        if (args.Length > 1)
        {
          _thread = new Thread(() =>
          {
            Console.WriteLine("Executando segunda thread");
            Execute(args[0], args[1]);
            //Código que será executado em paralelo ao resto do código
          });
          _thread.Name = "Início da segunda thread";
          _thread.Start();
          Console.WriteLine($"Thread: {Thread.CurrentThread.Name}");
          Console.WriteLine($"Processo em paralelo será encerrado em {args[1]}");
          Console.ReadKey();
        }
        else
        {
          _thread = new Thread(() =>
          {
            Console.WriteLine("Executando segunda thread");
            Execute(args[0]);
            //Código que será executado em paralelo ao resto do código
          });
          
          _thread.Name = "Início da segunda thread";
          _thread.Start();
          Console.WriteLine($"Thread: {Thread.CurrentThread.Name} - Em espera...");
          Console.ReadKey();
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.StackTrace);
      }
    }
    static void Execute(string pathExec, string strTimeKill)
    {
      Process _process = Process.Start(pathExec);
      if (int.TryParse(strTimeKill, out int killTime))
      {
        _process.WaitForExit((killTime * 1000)); 
        _process.Kill();
      }
    }
    static void Execute(string pathExec)
    {
      Process.Start(pathExec);
    }
  }
}
