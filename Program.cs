using System.Drawing;
using System.IO.IsolatedStorage;

namespace SzkolaDotNet.W2L8_petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Exercise 1: liczby pierwsze
            //for (int i = 2; i < 101; i++)
            //{
            //    bool primeNumber = true;

            //    for (int j = 2; j * j <= i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            primeNumber = false;
            //            break;
            //        }
            //    }
            //    if (primeNumber)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //}
            //Console.WriteLine("\n-------------------------------------------------\n");

            //// Exercise 2: liczby parzyste
            //int a = 0;
            //do
            //{
            //    if (a % 2 == 0)
            //    {
            //        Console.Write($"{a} ");
            //    }
            //    a++;
            //}
            //while (a < 1001);
            //Console.WriteLine("\n-------------------------------------------------\n");

            //// Exercise 3: ciąg fibonacciego
            //int fibNumber = 8;
            //int fibA = 0;
            //int fibB = 1;
            //int fibResult = 0;

            //if (fibNumber > 2)
            //{
            //    Console.Write(fibA + " ");
            //    Console.Write(fibB + " ");
            //    for (int i = 2; i < fibNumber; i++)
            //    {
            //        fibResult = fibA + fibB;
            //        Console.Write(fibResult + " ");

            //        fibA = fibB;
            //        fibB = fibResult;
            //    }
            //}
            //else if (fibNumber == 1)
            //{
            //    Console.WriteLine(fibA);
            //}
            //else if (fibNumber == 2)
            //{
            //    Console.Write(fibB);
            //}
            //Console.WriteLine("\n-------------------------------------------------\n");

            //// Exercise 4: piramida z liczb
            //Console.WriteLine("Podaj liczbę: ");
            //Int32.TryParse(Console.ReadLine(), out int yourNumber);
            //int b = 1;
            //for (int i = 0; i < yourNumber; i++)
            //{
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        if (b > yourNumber)
            //            break;

            //        Console.Write($"{b} ");
            //        b++;
            //    }
            //    Console.WriteLine();
            //    if (b > yourNumber)
            //        break;
            //}

            //Console.WriteLine("\n-------------------------------------------------\n");

            //// Exercise 5:  Liczby do potęgi 3
            //for (int i = 1; i < 21; i++)
            //{
            //    Console.WriteLine($"Liczba {i} do potęgi 3, wynosi: {Math.Pow(i, 3)}");
            //}
            //Console.WriteLine("\n-------------------------------------------------\n");

            ////Exercise 6: Obliczanie liczby wg danego wzoru
            //double resultExerciseSix = 0;
            //for (double i = 1; i < 21; i++)
            //{
            //    resultExerciseSix += (1 / i);
            //}
            //Console.WriteLine($"Wynik sumy dla liczby od 0 do 20 wynosi: {resultExerciseSix}");
            //Console.WriteLine("\n-------------------------------------------------\n");

            //Exercise 6: Diamond
            int diamondSize = 7;

            int halfSize = diamondSize / 2;

            for (int i = 0; i < diamondSize; i++)
            {
                int distanceFromMiddle = Math.Abs(halfSize - i);

                int stars = diamondSize - 2 * distanceFromMiddle;

                for (int j = 0; j < distanceFromMiddle; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < stars; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n-------------------------------------------------\n");

            //// Exercise 7: Odwrócony string

            //string text = "Abcdefg";
            //Console.WriteLine($"Podana wartość: {text}");
            //char[] charText = text.ToLower().ToCharArray();
            //Array.Reverse(charText);
            //charText[0] = char.ToUpper(charText[0]);
            //string newText = new string(charText);
            //Console.WriteLine(newText);
            //Console.WriteLine("\n-------------------------------------------------\n");

            //// Exercise 9: Liczba dziesiętna na binarną
            //int number = 41;
            //Console.WriteLine($"Podana wartość: {number}");
            //string binaryNumber = "";

            //while (number > 0)
            //{
            //    int modulo = number % 2;
            //    binaryNumber = modulo.ToString() + binaryNumber;
            //    number /= 2;
            //}
            //Console.WriteLine(binaryNumber);
            //Console.WriteLine("\n-------------------------------------------------\n");

            //// Exercise 10: Najmniejsza wielokrotność dwóch liczb

            //int firstNumber = 5;
            //int secondNuber = 10;
            //Console.WriteLine($"Podane wartości: {firstNumber} i {secondNuber}");
            //int nww;
            //int min;
            //int max;

            //if (firstNumber > secondNuber)
            //{
            //    nww = firstNumber;
            //    max = firstNumber;
            //    min = secondNuber;

            //}
            //else
            //{
            //    nww = secondNuber;
            //    max = secondNuber;
            //    min = firstNumber;
            //}
            //while (nww % min != 0)
            //{
            //    nww += max;
            //}
            //Console.WriteLine(nww);
            //Console.WriteLine("\n-------------------------------------------------\n");

            Console.ReadLine();
        }
    }
}