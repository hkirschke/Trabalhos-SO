﻿using System;

namespace Calculator
{
  public static class Sum
  {
    public static double DoOperation(string num1, string num2)
    {
      double resNum1 = 0, resNum2 = 0;
      if (!double.TryParse(num1, out resNum1) && !double.TryParse(num2, out resNum2))
        throw new InvalidOperationException("Numeros informados não são validos!");
      return resNum1 + resNum2;
    }
  }
}
