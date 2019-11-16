using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer_Consumer
{
  class Program
  {
    static void Main(string[] args)
    {
      var producer = new Producer();
      while (true)
      {
        if (Console.KeyAvailable)
        {
          if (Console.ReadKey().Key == ConsoleKey.T)
            break;
        }

      }
    }
  }
}
