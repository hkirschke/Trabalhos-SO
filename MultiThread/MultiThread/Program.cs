using System;
using System.Threading;

namespace MultiThread
{
  public class Program
  {
    private static int NumParam = 0;
    private static double SomaGeral = 0;
    private static Thread thread1;
    private static Thread thread2;
    static Semaphore _pool;
    public static void Main(string[] args)
    {
      if (args.Length > 0)
      {
        if (!int.TryParse(args[0], out NumParam))
        {
          Console.WriteLine($"Parâmetro invalido {args[0]}");
          Console.ReadKey();
        }
        _pool = new Semaphore(3, 3);
        Console.WriteLine($"Parâmetro informado {NumParam}");
        TimerCallback callback = new TimerCallback(Cronometro);
        Timer stateTimer = new Timer(callback, null, 0, 2000);
        thread1 = new Thread(Fatorial);
        thread2 = new Thread(Fibonacci);
        thread1.Start();
        thread2.Start();
        Console.ReadKey();
      }
      else
      {
        Console.WriteLine($"Parâmetro não informado.");
        Console.ReadKey();
      } 
    }

    //1 1 2 3 5 8 13 21
    public static void Fibonacci()
    {
      double numAtual = 1, numAnt = 0;
      for (double i = 1; i < NumParam; i++)
      {
        numAnt = numAtual;
        numAtual = SomaGeral;
        Thread.Sleep(10000);
        Console.WriteLine($"Soma Geral:{SomaGeral} Somando {numAtual} + {numAnt}");
        SomaGeral += numAtual + numAnt;
        Console.WriteLine($"Numero Atual Fibonacci: {numAtual}");
      }
      Console.WriteLine($"Final Fibonnaci: Soma Geral: {SomaGeral}");
      Thread.Sleep(15000);
    }

    // Método calculador do fatorial.
    public static void Fatorial()
    {
      int fatorial = NumParam;
      for (int i = NumParam - 1; i > 1; i--)
      {
        fatorial *= i;
        Thread.Sleep(6000);
        Console.WriteLine($"Soma Geral:{SomaGeral} Somando {SomaGeral} + {fatorial}");
        SomaGeral += fatorial;
        Console.WriteLine($"Numero Fatorial: {fatorial}");
      }
      Console.WriteLine($"Final Fatorial: Soma Geral: {SomaGeral}");
      Thread.Sleep(15000);
    }

    public static void Cronometro(object stateInfo)
    {
      Console.WriteLine($"Soma Geral: {SomaGeral}");
    }
  }
}
