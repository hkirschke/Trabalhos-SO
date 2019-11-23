using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaParametro
{
  public static class ValidaParametro
  {
    public static bool Validar(string[] args, int qtdParams)
    {
      if (args != null || args.Length < qtdParams)
      {
        Console.WriteLine($"Parametro Informados: ");
        for (int i = 0; i < args.Length; i++)
        {
          Console.WriteLine($"{i} - {args[i]}");
        }
        return true;
      }
      else
      {
        Console.WriteLine("Parâmetro(s) não informado(s) ou insuficiente(s)");
        return false;
      } 
    }
  }
}
