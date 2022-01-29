    using System;

    namespace _11._Math_operations
    {
        class Program
        {
            static void Main(string[] args)
            {
                int firstNumber = int.Parse(Console.ReadLine());
                string operation = Console.ReadLine();
                int secondNumber = int.Parse(Console.ReadLine());

                Console.WriteLine(Calculator(firstNumber,operation,secondNumber));

                static double Calculator(int a, string function, int b)
                {
                    
                    switch (function)
                    {
                        case "/":
                            return a / b;
                            break;

                        case "*":
                            return a * b;
                            break;

                        case "+":
                            return a + b;
                            break;

                        case "-":
                            return a - b;
                            break;


                        default:
                            break;
                    }

                    return 0;
                }
            }
        }
    }
