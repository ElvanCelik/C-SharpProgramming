namespace LokantaMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Adana 40.00TL
            //2) Beyti 45.00TL
            //3) Salata 10.00TL
            //4) Tatlı 20.00TL
            //5) İçecek 8.00TL
            //6) Çıkış
            double toplam = 0;
            int secim;

            do
            {
                Console.WriteLine("1) Adana 40.00TL");
                Console.WriteLine("2) Beyti 45.50TL");
                Console.WriteLine("3) Salata 10.00TL");
                Console.WriteLine("4) Tatlı 20.75TL");
                Console.WriteLine("5) İçecek 8.00TL");
                Console.WriteLine("6) Çıkış");
                Console.WriteLine("Lütfen bir seçim yapınız : ");
                secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        toplam += 40.00;
                        Console.WriteLine("Şu an ki hesap : " + toplam);
                        break;
                    case 2:
                        toplam += 45.50;
                        Console.WriteLine("Şu an ki hesap : " + toplam);
                        break;
                    case 3:
                        toplam += 10.00;
                        Console.WriteLine("Şu an ki hesap : " + toplam);
                        break;
                    case 4:
                        toplam += 20.75;
                        Console.WriteLine("Şu an ki hesap : " + toplam);
                        break;
                    case 5:
                        toplam += 8.00;
                        Console.WriteLine("Şu an ki hesap : " + toplam);
                        break;
                    case 6:
                        Console.WriteLine("Hesabınız tamamlandı.");
                        break;
                    default:
                        Console.WriteLine("Lütfen 1-6 arasında bir seçim yapınız. ");
                        break;
                }
            } while (secim != 6);

            Console.WriteLine("Toplam Hesap :  " + toplam+"TL");
            Console.ReadLine();

                




            



            

            }
        }
    }