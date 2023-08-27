namespace Modul320
{
    using System;
    using System.Linq;

    class MyMath
    {
        public static int Calc_ggT(int a, int b) => b == 0 ? a : Calc_ggT(b, a % b);
        public static int Calc_kgV(int a, int b) => (a * b) / Calc_ggT(a, b);

        public static int ReadInt(string prompt) => Enumerable.Range(1, int.MaxValue).Select(_ => { Console.Write(prompt); return int.Parse(Console.ReadLine()); }).First();
        public static void ShowResult(string operation, int a, int b, int result) => Console.WriteLine($"{operation} von {a} und {b} ist {result}");

        public static double CalcArithmeticMean(int[] numbers) => numbers.Average();
        public static int FindSmallestValue(int[] numbers) => numbers.Min();
        public static int FindLargestValue(int[] numbers) => numbers.Max();

        public static void Swap(ref int a, ref int b) => (a, b) = (b, a);

        public static void ReverseArray(int[] array) => array.Reverse();
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. ggT berechnen");
                Console.WriteLine("2. kgV berechnen");
                Console.WriteLine("3. Array-Funktionen");
                Console.WriteLine("4. Beenden");
                Console.Write("Option wählen: ");

                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    int a = MyMath.ReadInt("Geben Sie die erste Zahl ein: ");
                    int b = MyMath.ReadInt("Geben Sie die zweite Zahl ein: ");
                    int result = MyMath.Calc_ggT(a, b);
                    MyMath.ShowResult("ggT", a, b, result);
                }
                else if (option == 2)
                {
                    int a = MyMath.ReadInt("Geben Sie die erste Zahl ein: ");
                    int b = MyMath.ReadInt("Geben Sie die zweite Zahl ein: ");
                    int result = MyMath.Calc_kgV(a, b);
                    MyMath.ShowResult("kgV", a, b, result);
                }
                else if (option == 3)
                {
                    int arraySize = MyMath.ReadInt("Geben Sie die Größe des Arrays ein: ");
                    int[] numbers = Enumerable.Range(1, arraySize).Select(_ => MyMath.ReadInt($"Geben Sie die Zahl an Index {_} ein: ")).ToArray();

                    Console.WriteLine($"Arithmetischer Mittelwert: {MyMath.CalcArithmeticMean(numbers)}");
                    Console.WriteLine($"Kleinster Wert: {MyMath.FindSmallestValue(numbers)}");
                    Console.WriteLine($"Größter Wert: {MyMath.FindLargestValue(numbers)}");

                    MyMath.ReverseArray(numbers);
                    Console.WriteLine("Umgekehrtes Array:");
                    Console.WriteLine(string.Join(" ", numbers));
                }
                else if (option == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ungültige Option!");
                }

                Console.WriteLine();
            }
        }
    }
}