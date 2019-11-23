using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidaParametro;

namespace Comando.CriaDiretorio
{
  class Program
  {
    static void Main(string[] args)
    {
      if (ValidaParametro.ValidaParametro.Validar(args, 1))
      {
        if (!Directory.Exists(args[0]))
        {
          Directory.CreateDirectory(args[0]);
          Console.WriteLine("Diretório criado.");
        }
        else
        {
          Console.WriteLine("Diretório já existe;");
        }
      }
      Console.ReadKey();
      Console.WriteLine("Encerrando...");
      System.Threading.Thread.Sleep(1000);
    }
  }
}
