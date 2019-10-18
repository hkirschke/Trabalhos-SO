using System;

namespace Calculator
{
  public static class Division 
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="num1">Numerador</param>
    /// <param name="num2">Denominador</param>
    /// <returns></returns>
    public static double DoOperation(string num1, string num2)
    {
      if (num2.Equals("0"))
       throw new DivideByZeroException("Divisão por zero não pode ser feita");
      double resNum2 = 1;
      if (!double.TryParse(num1, out double resNum1) && !double.TryParse(num2, out resNum2))
        throw new InvalidOperationException("Numeros informados não são validos!");
      return resNum1 / resNum2;
    }
  }
}
