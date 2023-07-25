namespace Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 1;
            int sayi2 = 1;
            while (sayi1 <= 10)
            {
                while (sayi2 <= 10)
                {
                    Console.WriteLine(sayi1 + " x " + sayi2 + " = " + (sayi1 * sayi2));
                    sayi2++;
                }
                sayi1++;
                sayi2 = 1;
            }
            Console.ReadLine();
        }
    }
}