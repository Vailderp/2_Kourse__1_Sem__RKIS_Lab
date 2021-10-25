namespace ConsoleApp1
{
    class Program
    {
        //1
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
        
    }
}
