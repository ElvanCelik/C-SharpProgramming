namespace Ders2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //I/O İşlemleri
            string nickName;
            Console.Write("Lütfen kullanıcı adınızı giriniz : ");
            nickName = Console.ReadLine();
            Console.WriteLine("Kullanıcı adı : "+nickName);

            //Kullanıcıdan int veri tipinde değişken alma metodları  : int.Parse - Convert.ToInt32 - Int.TryParse
            //Eğer girdi olarak string girerseniz program size hata verir, çalışmayı durdurur.
            int sayi = Convert.ToInt32(Console.ReadLine());
            //int sayi = int.Parse(Console.ReadLine());
            //string sayininGirdisi = Console.ReadLine();
            //int sayi = int.TryParse(Console.ReadLine(), out sayi);
            Console.WriteLine("Girmiş olduğunuz sayının karesi : "+(sayi*sayi));

            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayının karesi : " + (sayi2 * sayi2));

            float sayi3 = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayı : " + sayi3);

        }
    }
}