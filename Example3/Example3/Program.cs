using System.Globalization;

namespace Example3
{
    internal class Program
    {
        //Ekrana yıldızlardan baklava dilimi yazdıran program
        static void Main(string[] args)
        {
            int bosluk, yildiz, satir;
            Console.WriteLine("Kaç satır baklava dilimi yazsın = ");
            satir = Convert.ToInt32(Console.ReadLine());

            satir = satir % 2 == 0 ? satir+1: satir;
            if (satir % 2 != 0)
            {
                Console.WriteLine("Girdiğiniz sayı çift olduğundan 1 artırıldı.\n");
            }
            bosluk = satir / 2;
            yildiz = 1;
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < bosluk; j++)
                {
                    Console.Write(" ");
                }

                for (int z = 0; z < yildiz; z++)
                {
                    Console.Write("*");
                }
                if (i < satir / 2)
                {
                    bosluk--;
                    yildiz += 2;
                }
                else
                {
                    bosluk++;
                    yildiz -= 2;
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}