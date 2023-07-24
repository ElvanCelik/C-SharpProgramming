using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, sonuc = 0;
            char islem;

            Console.WriteLine("Birinci sayıyı giriniz : ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz : ");
            sayi2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz --> +  -  *  /  %  ");
            islem = Convert.ToChar(Console.ReadLine());

            if (islem == '+')
            {
                sonuc = sayi1 + sayi2;
            }
            else if (islem == '-')
            {
                sonuc = sayi1 - sayi2;
            }
            else if (islem == '*')
            {
                sonuc = sayi1 * sayi2;
            }
            else if (islem == '/')
            {
                if (sayi2 == 0)
                {
                    Console.WriteLine("ikinci sayı 0 olamaz!");
                    return; // Stop the program from executing further
                }
                else 
                {
                    sonuc = sayi1 / sayi2;
                }
                
            }
            else if (islem == '%')
            {
                sonuc = sayi1 % sayi2;
            }

            Console.WriteLine("{0} {1} {2} = {3}", sayi1, islem, sayi2, sonuc);
            Console.ReadLine();
        }
    }
}
