using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando.CopiarArquivo
{
  class Program
  {
    static void Main(string[] args)
    {
      if (ValidaParametro.ValidaParametro.Validar(args, 2))
      {
        if (File.Exists(args[0]) && File.Exists(args[1]))
        {
          File.Copy(args[0], args[1]);
          Console.WriteLine("Arquivo copiado com sucesso.");
        }
        else
          Console.WriteLine($"Arquivo(s) não existe!");
      }
      Console.ReadKey();
      Console.WriteLine("Encerrando...");
      System.Threading.Thread.Sleep(1000);
    }
  }
}

