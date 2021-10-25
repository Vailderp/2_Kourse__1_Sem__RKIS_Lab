namespace ConsoleApp1
{
    class Program
    {
        //4
        static void Main(string[] args)
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
        }
    }
}
