using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando.ListarDiretorio
{
  class Program
  {
    static void Main(string[] args)
    {
      if (ValidaParametro.ValidaParametro.Validar(args, 1))
      {
        if (Directory.Exists(args[0]))
        {
          Console.WriteLine($"Lista de Arquivos do diretório {args[0]}");
          foreach (var item in Directory.GetFiles(args[0]))
          {
            Console.WriteLine($"Arquivo: {item}");
          }
        }
        else
          Console.WriteLine($"Diretório não existe!");
      }
      Console.ReadKey();
      Console.WriteLine("Encerrando...");
      System.Threading.Thread.Sleep(1000);
    }
  }
}
