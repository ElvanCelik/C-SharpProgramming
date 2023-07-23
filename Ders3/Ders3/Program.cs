namespace Ders3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# programlama dilinde var değişkeni, bir değişkenin türünü belirtmek yerine, derleyicinin değişkenin türünü otomatik olarak çıkarmasını sağlayan bir anahtar sözcüktür. 
            var x = 5;
            var isim = "Elvan";
            var kesirliSayi = 3.14;
            var flag = true;
            var karakter = 'E';

            Console.WriteLine(x +" "+ isim + " " + kesirliSayi + " " + flag + " " + karakter);
            Console.ReadLine();

            //Const: Constant Kelimesinden gelir. const, sabit değerleri tanımlamak için kullanılan bir anahtar sözcüktür. Bir değişkenin değerinin programın çalışma süresi boyunca değiştirilmemesi gerektiğinde, const anahtar kelimesi kullanılarak bu tür değişkenler tanımlanır.
            const double PI = 3.14;
            Console.WriteLine(PI);

        }
    }
}