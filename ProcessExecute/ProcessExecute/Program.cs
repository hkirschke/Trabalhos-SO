using System;
using System.Threading;
using System.Threading.Tasks;

namespace ProcessExecute
{
  public static class Program
  {
    static void Main(string[] args)
    {
      try
      {
        Thread.CurrentThread.Name = "Principal - Program.cs - ProcessExecute";
        Console.WriteLine($"Thread principal iniciada {Thread.CurrentThread.Name}");
        if (args.Length > 1)
        {
          Task.Factory.StartNew(() =>
          {
            ProcessExecuter.Execute(args[0], args[1]);
          });
          Console.WriteLine($"Thread: {Thread.CurrentThread.Name}");
          Console.WriteLine($"Processo em paralelo será iniciado em {args[1]} segundos");
          TimerCallback callback = new TimerCallback(Cronometro);
          Timer stateTimer = new Timer(callback, null, 0, 1000); 
          Console.ReadKey();
        }
        else
        {
          Console.WriteLine("Deve ser informado o aplicativo a ser executa e tempo para iniciar Ex: Calc.exe 20");
          Console.ReadKey();
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.StackTrace);
      }
    }
    static public void Cronometro(object stateInfo)
    {
      Console.WriteLine("Hora: {0}", DateTime.Now.ToString("hh:mm:ss"));
    }
  }
}
