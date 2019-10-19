using System;
using System.Diagnostics;
using System.Threading;

namespace ProcessExecute
{
  public static class ProcessExecuter
  {
    public static void Execute(string pathExec, string timeStart)
    {
      Thread.CurrentThread.Name = $"Segundo Processo: {pathExec}";
      if (int.TryParse(timeStart, out int waitTime))
      {
        Console.WriteLine($"Thread em parelo: {Thread.CurrentThread.Name}");
        Thread.Sleep(waitTime * 1000);
      }
      ExecNewProcess(pathExec);
    }
    private static void ExecNewProcess(string pathExec)
    {
      ProcessStartInfo processStartInfo = new ProcessStartInfo
      {
        FileName = pathExec
      };
      Process process = new Process
      {
        StartInfo = processStartInfo
      };
      process.Start();
      Console.WriteLine($"Novo processo iniciado com sucesso PCID:{process.Id}");
    }
  }
}
