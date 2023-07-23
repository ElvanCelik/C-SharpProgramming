using System.Runtime.InteropServices;

namespace Ders1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //.NET Framework:
            // CLR(Common Language Runtime): Ortak Dil Çalışma platformudur. Derleme Süresini azaltır.
            // .NET Class Library
            char karakter = 'k'; //2 byte tek tırnak ('') kullanılır
            string name = "elvan"; //karakter başı 2byte'dan hesaplanır
            int tamSayi = 5; //4byte
            float kesirliSayi = 3.1f; //4byte f harfi kullanılır.
            double buyukKesirliSayi = 3.5; //8byte
            bool flag = true;
            int kesirliSayininBoyutu = Marshal.SizeOf(kesirliSayi);
            //int stringinBoyutu = Marshal.SizeOf(name);
            //int karakterBoyutu = System.Text.ASCIIEncoding.Unicode.GetByteCount(karakter);
            Console.WriteLine(sizeof(char));
            Console.WriteLine(name.Length * sizeof(char));
            Console.WriteLine(kesirliSayininBoyutu);
            //Console.WriteLine(stringinBoyutu);
            //Console.WriteLine(karakterBoyutu);
            Console.WriteLine(karakter +" "+ name + " "+tamSayi + " " +kesirliSayi + " " +buyukKesirliSayi + " " +flag);
            Console.WriteLine(" tamsayi = {0}", tamSayi); //Python'daki format değişkeni gibi düşünülebilir
            

            Console.ReadLine();
        }
    }
}