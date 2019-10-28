using System;
using System.Threading;

namespace MultiThread
{
    public class Program
    {
        private static int NumParam = 0;
        private static double SomaGeral = 0;

        public static void Main(string[] args)
        {
            if (!int.TryParse(args[0], out NumParam))
            {
                throw new InvalidOperationException($"Parâmetro invalido {args[0]}");
            }
            Console.WriteLine($"Parâmetro informado {NumParam}");
            TimerCallback callback = new TimerCallback(Cronometro);
            Timer stateTimer = new Timer(callback, null, 0, 1000);
            Thread thread1 = new Thread(Fatorial);
            Thread thread2 = new Thread(Fibonacci);
            thread1.Start();
            thread2.Start();
            Console.ReadKey();
        }

        //1 1 2 3 5 8 13 21
        public static void Fibonacci()
        {
            double numAtual = 1, numAnt = 0;
            for (double i = 1; i < NumParam; i++)
            {
                SomaGeral = numAtual + numAnt;
                numAnt = numAtual;
                numAtual = SomaGeral;
                Console.WriteLine($"Numero Atual Fibonacci: {numAtual}");
            }
        }

        // Método calculador do fatorial.
        public static void Fatorial()
        {
            int fatorial = NumParam;
            for (int i = NumParam - 1; i > 1; i--)
            {
                fatorial *= i;
                SomaGeral = SomaGeral + fatorial;
                Console.WriteLine($"Numero Fatorial: {fatorial}");
            }
        }

        public static void Cronometro(object stateInfo)
        {
            Console.WriteLine($"Soma Geral: {SomaGeral}");
        }
    }
}
