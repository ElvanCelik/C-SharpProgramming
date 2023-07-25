namespace Selection_Bubble_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] selection_sort = { 7, 45, 4, 12, 22, 555, 1, 2, 999, 7 };
            int[] bubble_sort = { 22, 3, 77, 16, 777, 6, 9, 43, 899, 7 };
            Console.WriteLine("Seçme Sıralama Algoritmasını kullanarak işletilecek orijinal dizi:");
            for (int i = 0; i < selection_sort.Length; i++)
            {
                Console.Write("  " + selection_sort[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Seçme Sıralama Algoritması uygulandıktan sonra dizi:");
            SelectionSort(selection_sort);
            Console.WriteLine("");
            Console.WriteLine("Kabarcık Sıralama Algoritmasını kullanarak işletilecek orijinal dizi:");
            for (int i = 0; i < bubble_sort.Length; i++)
            {
                Console.Write("  " + bubble_sort[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Kabarcık Sıralama Algoritması uygulandıktan sonra dizi:");
            BubbleSort(bubble_sort);
            for (int i = 0; i < bubble_sort.Length; i++)
            {
                Console.Write("  " + bubble_sort[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Programdan çıkmak için herhangi bir tuşa basın ...");
            Console.ReadKey(true);
        }

        /*
            Bu algoritmanın zaman karmaşıklığını (veya Büyük O gösterimini) O(n^2) olarak tanımlarız,
            çünkü iç içe iki döngü bulunmaktadır. Kabarcık sıralamadan daha avantajlı olan nokta,
            maksimum O(n) takas işlemi yapmasıdır. Bu nedenle, takas işlemi sırasında belleğe yazılan
            veri miktarı daha azdır.
        */
        static void SelectionSort(int[] ss_dizi)
        {
            // min_position, mevcut en düşük değere sahip elemanın konumunu tutmak için kullanılır
            int min_position;
            // temp, Seçme Sıralama Algoritmasında takas işlemi yapmak için kullanılır
            int temp;

            for (int i = 0; i < ss_dizi.Length; i++)
            {
                // min_position, şu anki dizinin diziniyle başlatılır
                min_position = i;
                // min_position'dan sonraki elemanın daha küçük olup olmadığını kontrol etmek için döngü kullanılır
                for (int x = i + 1; x < ss_dizi.Length; x++)
                {
                    // Eğer şu anki min_position'dan sonraki eleman daha küçükse, yeni min_position olarak güncellenir
                    if (ss_dizi[x] < ss_dizi[min_position])
                    {
                        // Bir takas yapıldığında min_position, min değerin konumunu tutacaktır, bu takas işlemi gerçekleştiğinde gereklidir
                        min_position = x;
                    }
                } // İçteki döngünün sonu

                // Eğer min_position, döngüde değerlendirilen mevcut elemanla aynı değilse,
                // o zaman takas işlemi yapılır. En küçük değeri mevcut elemanla yer değiştirir.
                if (min_position != i)
                {
                    temp = ss_dizi[i];
                    ss_dizi[i] = ss_dizi[min_position];
                    ss_dizi[min_position] = temp;
                }
                Console.Write("  " + ss_dizi[i]);
            } // Dıştaki döngünün sonu
        } // SecmeSiralama metodunun sonu

        // Bu metod, Kabarcık Sıralama Algoritmasını uygular ve en kötü durumda O(n^2) zaman karmaşıklığına sahiptir.
        static void BubbleSort(int[] bs_dizi)
        {
            // For döngüsü, dizi küçükten büyüğe sıralandığında devam eder.
            // Kabarcık Sıralama, her döngüde dizinin başından başlar ve bir sonraki elemanın değerini kontrol eder,
            // eğer bir sonraki eleman değeri mevcut elemandan küçükse takas eder.
            for (int i = 0; i < bs_dizi.Length - 1; i++)
            {
                for (int x = 0; x < bs_dizi.Length - i - 1; x++)
                {
                    // Her iç içe döngü iterasyonunda, bir sonraki elemanın değerinin mevcut elemandan daha düşük olup olmadığı kontrol edilir,
                    // Eğer bir sonraki elemanın değeri daha küçükse, takas işlemi yapılır
                    if (bs_dizi[x] > bs_dizi[x + 1])
                    {
                        // Burada temp ve ks_dizi[x] takas yapılır
                        // temp değişkeni, mevcut elemanın değerini geçici olarak tutmak için kullanılır, böylece takas yapılabilir
                        int temp = bs_dizi[x];
                        bs_dizi[x] = bs_dizi[x + 1];
                        bs_dizi[x + 1] = temp;
                    } // if bloğunun sonu
                } // İçteki for döngüsünün sonu
            } // Dıştaki for döngüsünün sonu
        }
    }
  }
