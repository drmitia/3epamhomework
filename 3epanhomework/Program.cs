namespace _3epanhomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть ваше число");
            int our_number = Convert.ToInt32(Console.ReadLine());
            string numberString = our_number.ToString();
            int length = numberString.Length;
            int summa = 0;
            while (length > 0)
            {
                int k = our_number % 10;
                our_number /= 10;
                summa =summa + k;
                length--;               
            }
            Console.WriteLine(summa);
        }
    }
}