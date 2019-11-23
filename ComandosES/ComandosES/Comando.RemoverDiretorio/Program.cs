using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando.RemoverDiretorio
{
  class Program
  {
    static void Main(string[] args)
    {
      if (ValidaParametro.ValidaParametro.Validar(args,1))
      {
        if (Directory.Exists(args[0]))
        {
          Directory.Delete(args[0]);
          Console.WriteLine("Diretório excluído com sucesso.");
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
