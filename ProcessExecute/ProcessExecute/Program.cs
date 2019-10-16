using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProcessExecute
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {

        Console.WriteLine("Gerando nova thread para execução em paralelo");
        Console.WriteLine("Thread principal iniciada");
        Thread.CurrentThread.Name = "Principal - Program.cs - ProcessExecute";
        Thread t2;
        ProcessExecuter processExecuter;
        //if (args.Length > 1)
        //{
        //  t2 = new Thread(new ThreadStart(new ProcessExecuter(args[0], args[1]).Execute()));
          
        //}
        //else
        //{
        //  t2 = new Thread(new ThreadStart(st)); 
        //}
        //t2.Name = "Secundária - ";
        //t2.Start();

      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.StackTrace);
      }
    }
  }
}
