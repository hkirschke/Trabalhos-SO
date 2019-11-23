using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando.RenomearDiretorio
{
  class Program
  {
    static void Main(string[] args)
    {
      if (ValidaParametro.ValidaParametro.Validar(args, 2))
      {
        string basePath = Path.GetDirectoryName(args[0]);
        if (Directory.Exists(args[0]))
        {
          Directory.Move(args[0], Path.Combine(basePath, args[1]));
          Console.WriteLine("Diretório renomeado com sucesso.");
        }
        else
          Console.WriteLine($"Diretório origem não existe!");
      }
      Console.ReadKey();
      Console.WriteLine("Encerrando...");
      System.Threading.Thread.Sleep(1000);
    }
  }
}
