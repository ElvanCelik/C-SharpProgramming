namespace Example_2
{
    internal class Program
    {
        //1 ile N arasındaki sayıları konsola yazdıran program;
        static void Main(string[] args)
        {
            int kacaKadar, aralik;
            Console.WriteLine("Lütfen kaça kadar yazdırmak istediğinizi giriniz : ");
            kacaKadar = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen sayıları kaçar kaçar artırmak istediğinizi giriniz : ");
            aralik = int.Parse(Console.ReadLine());
            for (int i = 0; i <= kacaKadar;i+= aralik)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}