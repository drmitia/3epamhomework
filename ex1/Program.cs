namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть число А");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть число В(менше за А)");
            int B = Convert.ToInt32(Console.ReadLine());
            while (A >= B) 
            {
                Console.WriteLine(A);
                A--;
            }
        }
    }
}