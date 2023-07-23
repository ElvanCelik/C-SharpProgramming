using System.Transactions;

namespace Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan ismini yaşını ve boyunu(metre) cinsinden alıp ekrana yazdıran program;
            string isim;
            int yas;
            float boy;

            Console.WriteLine("Lütfen adınızı giriniz : ");
            isim = Console.ReadLine();
            Console.WriteLine("Lütfen yaşınızı giriniz : ");
            yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen boyunuzu metre cinsinden giriniz : ");
            boy = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İsim : " + isim + "\nYaş : " + yas + "\nBoy : " + boy);
            Console.ReadLine();
        }
    }
}