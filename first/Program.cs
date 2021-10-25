using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //1
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            SayHello(name);
            Console.ReadKey();
        }
        static void SayHello(string name)
        {
            Console.WriteLine("Здравствуй, " + name);
        }
        */

        //2
        
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
        

        //3
        /*static void Main(string[] args)
        {
            int[] arr = { 1,3,5,7,4,2,1};
            int min = GetMin(arr);
            Console.WriteLine("Минимальный элемент массива = " + min);
            Console.ReadKey();
        }

        static int GetMin(int[] arr)
        {
            int min = arr[0];
            foreach(int el in arr)
                if (el < min)
                    min = el;
            return min;
        }*/

        //4
        /*static void Main(string[] args)
        {
            int[] mas = { 2, 5, 6, 1, -9 };
            int multiMas = GetMulti(mas);
            Console.Write("Произведение элементов массива равно: " + multiMas);
            Console.ReadKey();
        }
        static int GetMulti(int[] mas)
        {
            int multi = 1;
            foreach(int el in mas)           
                multi *= el;
            return multi;
        }*/

        //5
        /*static Random rand = new Random();
         static void Main(string[] args)
         {
             int[] arr = new int[10];
             Fill(arr, -1, 4);
             foreach(int num in arr)
                 Console.Write(num + ", ");
             Console.ReadKey();
         }

         static void Fill(int[] arr, int left, int right)
         {
            for(int i = 0; i < arr.Length; i++)
                 arr[i] = rand.Next(left, right);
         }*/

        //6
        /*static void Main(string[] args)
        {
            int[] arr = {1, 3, 5, 6, 7, 9};
            int target = int.Parse(Console.ReadLine());
            Console.Write($"Под индексом [{GetIdx(arr, target)}] могло бы стоять число {target}");
            Console.ReadKey();
        }
        static int GetIdx(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                if (arr[i + 1] >= target)
                    return i;
            return arr.Length;
        }*/

        //7
        /*static void Main(string[] args)
        {
            int[] arr = { -2, 3, -1, 4, 8, 10 };
            int sum = GetSum(arr);
            Console.WriteLine("Сумма всех чисел массива равна " + sum);
            Console.ReadKey();
        }

        static int GetSum(int[] arr)
        {
            int sum = 0;
            foreach(int num in arr)
                if (num > 0 && num % 2 == 0)
                    sum += num;
            return sum;
        }*/

        //8
        /*
        static void Main(string[] args)
        {
            int[,] matrix = { 
                { -2, 3, -1, 4, 8, 10 },
                { 1, 2, 3, 14, 45, 16 }
            };
            string[] str = { "Было:", "Стало:" };
            for (int f = 0; f < 2; f++)
            {
                Console.WriteLine(str[f]);
                for (int d = 0; d < 2; d++)
                {
                    for (int i = 0; i < matrix.GetLength(1); i++)
                        Console.Write(matrix[d, i] + ", ");
                    Console.Write("\n");
                }
                replace(matrix);
            }

            Console.ReadKey();
        }

        static void replace(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int num = matrix[0, i];
                matrix[0, i] = matrix[1, i];
                matrix[1, i] = num;
            }
        }*/

        //9
        /*
         * static void Main(string[] args)
        {
            int[,] matrix = {
                { -2, -3, -1},
                { 3, 2, 3},
                { 3, 4, 3}
            };

            int[] max = GatMaxArr(matrix);
            Console.Write("Максимальные значения:");
            foreach (int num in max)
                Console.Write(num + ", ");

            Console.ReadKey();
        }
        static int[] GatMaxArr(int[,] matrix)
        {
            int[] maxArr = new int[matrix.GetLength(0)];
            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                maxArr[y] = matrix[y, 0];
                for (int x = 0; x < matrix.GetLength(1); x++)
                    if (matrix[y, x] > maxArr[y])
                        maxArr[y] = matrix[y, x];
            }
            return maxArr;
        }
        */

        //10
        /*static void Main(string[] args)
        {
            int[] arr = { 0, 0, 1, 2, 2, 2, 2, 4, 5, 6, 7, 8, 9, 9, 9, 9, 9 };
            DoublesToNulls(arr);
            Console.WriteLine("Элементы массива: ");
            foreach (int num in arr)
                Console.Write(num + ", ");
            Console.ReadKey();
        }

        static void DoublesToNulls(int[] arr)
        {
            int last = arr[0];
            for(int i = 0; i < arr.Length; i++)
                if (last == arr[i])
                    arr[i] = 0;
                else
                    last = arr[i];
        }*/

    }
}
