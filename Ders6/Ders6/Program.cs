namespace Ders6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Artırma ve azlatma operatörleri- Increment Decrement
            int x = 5;
            Console.WriteLine(x);
            x = x + 1;
            Console.WriteLine(x);
            x += 1;
            Console.WriteLine(x);
            x++; //postfix: Sayıyı artırdıktan sonra eşitler.
            Console.WriteLine(x);
            ++x;//prefix: Sayıyı önce artırıp sonra eşitler.
            Console.WriteLine(x);
            Console.ReadLine();


        }
    }
}