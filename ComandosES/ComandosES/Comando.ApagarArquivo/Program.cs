using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando.ApagarArquivo
{
  class Program
  {
    static void Main(string[] args)
    {
      if (ValidaParametro.ValidaParametro.Validar(args, 1))
      {
        if (File.Exists(args[0]))
        {
          File.Delete(args[0]);
          Console.WriteLine("Arquivo excluído com sucesso.");
        }
        else
          Console.WriteLine($"Arquivo não existe!");
      }
      Console.ReadKey();
      Console.WriteLine("Encerrando...");
      System.Threading.Thread.Sleep(1000);
    }
  }
}
