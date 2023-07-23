namespace Ders4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 5;
            int sayi2 = 4;
            //string isim = "elvan";
            //Console.WriteLine(isim + sayi1 + sayi2); bu satırın çıktısı : 54elvan olur çünkü console writeline integer değerleri stringe çevirir.
            Console.WriteLine(sayi1 + sayi2);
            Console.WriteLine(sayi1 - sayi2);
            Console.WriteLine(sayi1 * sayi2);
            Console.WriteLine((double)sayi1 / (double)sayi2);
            Console.WriteLine(sayi1 % sayi2);

        }
    }
}