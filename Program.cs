using System.IO.IsolatedStorage;

namespace SzkolaDotNet.W2L8_petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1: liczby pierwsze
            for (int i = 2; i < 101; i++)
            {
                bool primeNumber = true;

                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        primeNumber = false;
                        break;
                    }
                }
                if (primeNumber)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine("\n-------------------------------------------------\n");

            // Exercise 2: liczby parzyste
            int a = 0;
            do
            {
                if (a % 2 == 0)
                {
                    Console.Write($"{a} ");
                }
                a++;
            }
            while (a < 1001);
            Console.WriteLine("\n-------------------------------------------------\n");

            // Exercise 3: ciąg fibonacciego
            int fibNumber = 8;
            int fibA = 0;
            int fibB = 1;
            int fibResult = 0;

            if (fibNumber > 2)
            {
                Console.Write(fibA + " ");
                Console.Write(fibB + " ");
                for (int i = 2; i < fibNumber; i++)
                {
                    fibResult = fibA + fibB;
                    Console.Write(fibResult + " ");

                    fibA = fibB;
                    fibB = fibResult;
                }
            }
            else if (fibNumber == 1)
            {
                Console.WriteLine(fibA);
            }
            else if (fibNumber == 2)
            {
                Console.Write(fibB);
            }
            Console.WriteLine("\n-------------------------------------------------\n");

            // Exercise 4: piramida z liczb
            Console.WriteLine("Podaj liczbę: ");
            Int32.TryParse( Console.ReadLine(), out int yourNumber);
            int b = 1;
            for (int i = 0; i < yourNumber; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write($"{b} ");
                    b++;
                }
                Console.WriteLine();
            }





            Console.ReadLine();
        }
    }
}