using System;

namespace Calculator
{
  static class Program
  {
    static void Main(string[] args)
    {
      if (args.Length < 3)
      { 
        Console.WriteLine("Numeros informados não são validos!");
        Console.ReadKey();
        return;
      }
      
      switch (args[0])
      {
        case var op when op.Equals("+") || op.Equals("sum") || op.Equals("soma"):
          Console.WriteLine(Sum.DoOperation(args[1], args[2]));
          break;
        case var op when op.Equals("-") || op.Equals("sub") || op.Equals("subtracao"):
          Console.WriteLine(Subtraction.DoOperation(args[1], args[2]));
          break;
        case var op when op.Equals("/") || op.Equals("div") || op.Equals("divisao"):
          Console.WriteLine(Division.DoOperation(args[1], args[2]));
          break;
        case var op when op.Equals("*") || op.Equals("mult") || op.Equals("multiplicacao") || op.Equals("x"):
          Console.WriteLine(Multiplication.DoOperation(args[1], args[2]));
          break;
        default:
          Console.WriteLine("Operação inválida");
          Console.ReadKey();
          break;
      }
    }
  }
}
