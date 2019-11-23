using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando.CopiarDiretorio
{
  class Program
  {
    static string fileName;
    static string destFile;
    static void Main(string[] args)
    {
      if (ValidaParametro.ValidaParametro.Validar(args, 2))
      {
        if (Directory.Exists(args[0]))
        { 
          if (!Directory.Exists(args[1])) { Directory.CreateDirectory(args[1]); }
          foreach (var item in Directory.GetFiles(args[0]))
          {
            fileName = Path.GetFileName(item);
            destFile = Path.Combine(args[1], fileName);
            File.Copy(item, destFile, true);
          }
          Console.WriteLine("Arquivo(s) copiado com sucesso.");
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
