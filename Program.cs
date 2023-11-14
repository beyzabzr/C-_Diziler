using System;
namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanimlama 
            string[] renkler = new string[5];
            string[] hayvanlar = { "kedi", "kopek", "kus", "maymun" };
            int[] dizi;
            dizi = new int[5];

            //dizilere deger atama ve erisim
            renkler[0] = "Mavi";
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            Console.WriteLine("*****");
            //dongulerle dizi kullanimi
            // Klavyeden girilen n tane sayinin toplamini alan program

            Console.WriteLine("Lütfen dizinin eleman sayisini giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayisi giriniz: ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            { toplam += sayi; }
            Console.WriteLine("Ortalama: " + toplam / diziUzunlugu);

        }
    }
}