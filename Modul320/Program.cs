namespace Modul320
{
    using System;
    using System.Linq;

    /*
    Autor: Dawud Bitterli
    Date: 03.09.2023
    */
    class Calculator
    {
        private int result; // Interner Zustand, um das Ergebnis der letzten Operation zu speichern

        // Methode für die Addition von zwei Zahlen
        public int Add(int a, int b)
        {
            result = a + b;
            return result;
        }

        // Methode für die Subtraktion von zwei Zahlen
        public int Subtract(int a, int b)
        {
            result = a - b;
            return result;
        }

        // Methode für die Multiplikation von zwei Zahlen
        public int Multiply(int a, int b)
        {
            result = a * b;
            return result;
        }

        // Methode für die Ganzzahl-Division von zwei Zahlen
        public int Divide(int a, int b)
        {
            if (b != 0)
            {
                result = a / b;
            }
            else
            {
                Console.WriteLine("Division durch Null ist nicht erlaubt.");
            }
            return result;
        }

        // Methode für die Ausgabe des aktuellen Ergebnisses
        public void DisplayResult()
        {
            Console.WriteLine($"Aktuelles Ergebnis: {result}");
        }

        static void Main()
        {
            Calculator calculator = new Calculator();

            while (true)
            {
                Console.WriteLine("Bitte wählen Sie eine Operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraktion");
                Console.WriteLine("3. Multiplikation");
                Console.WriteLine("4. Ganzzahl-Division");
                Console.WriteLine("5. Beenden");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 5)
                {
                    Console.WriteLine("Das Programm wird beendet.");
                    break;
                }

                Console.Write("Geben Sie den ersten Operanden ein: ");
                int operand1 = int.Parse(Console.ReadLine());

                if (choice != 1 && choice != 5)
                {
                    Console.Write("Geben Sie den zweiten Operanden ein: ");
                    int operand2 = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            calculator.Add(operand1, operand2);
                            break;
                        case 2:
                            calculator.Subtract(operand1, operand2);
                            break;
                        case 3:
                            calculator.Multiply(operand1, operand2);
                            break;
                        case 4:
                            calculator.Divide(operand1, operand2);
                            break;
                    }
                }
                else
                {
                    switch (choice)
                    {
                        case 1:
                            calculator.Add(calculator.result, operand1);
                            break;
                        case 2:
                            calculator.Subtract(calculator.result, operand1);
                            break;
                        case 3:
                            calculator.Multiply(calculator.result, operand1);
                            break;
                        case 4:
                            calculator.Divide(calculator.result, operand1);
                            break;
                    }
                }

                calculator.DisplayResult();
            }
        }
    }

}