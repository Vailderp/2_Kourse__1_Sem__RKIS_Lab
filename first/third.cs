namespace ConsoleApp1
{
    class Program
    {
        //3
        static void Main(string[] args)
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
        }
    }
}
