using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите действие (*, /, +, -): ");
            string action = Console.ReadLine();
            switch (action)
            {
                case "*" :
                    Console.WriteLine($"Результат умножения {a} на {b} = {multiply(a, b)}");
                    break;
                case "/":
                    Console.WriteLine($"Результат деления {a} на {b} = {split(a, b)}");
                    break;
                case "+":
                    Console.WriteLine($"Результат сложения {a} и {b} = {add(a, b)}");
                    break;
                case "-":
                    Console.WriteLine($"Результат разности {a} и {b} = {minus(a, b)}");
                    break;
            }
            Console.ReadKey();
        }
        
        static int add(int a, int b) => a + b;
        static int minus(int a, int b) => a - b;
        static int multiply(int a, int b) => a * b;
        static float split(int a, int b) => (float)a / b;
        
    }
}
