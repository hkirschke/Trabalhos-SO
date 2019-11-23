using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando.RenomearArquivo
{
  class Program
  {
    static void Main(string[] args)
    {
      if (ValidaParametro.ValidaParametro.Validar(args, 2))
      {
        string basePath = Path.GetDirectoryName(args[0]);
        if (File.Exists(args[0]))
        {
          File.Move(args[0], Path.Combine(basePath, args[1]));
          Console.WriteLine("Arquivo renomeado com sucesso.");
        }
        else
          Console.WriteLine($"Arquivo de origem não existe!");
      }
      Console.ReadKey();
      Console.WriteLine("Encerrando...");
      System.Threading.Thread.Sleep(1000);
    }
  }
}
