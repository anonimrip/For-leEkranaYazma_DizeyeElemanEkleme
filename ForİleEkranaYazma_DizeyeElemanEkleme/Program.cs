using System;

namespace nothesaplama
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] yazili_notlari = { 100, 100, 100 };

            Console.WriteLine("1. Yazılı Notunuz: " + yazili_notlari[0]);
            Console.WriteLine("2. Yazılı Notunuz: " + yazili_notlari[1]);
            Console.WriteLine("3. Yazılı Notunuz: " + yazili_notlari[2]);


            int hesapla = (yazili_notlari[0] + yazili_notlari[1] + yazili_notlari[2]) / 3;
            Console.WriteLine(hesapla);


            int[] sayilar = new int[5];
            int sayi = 10;
            for (int sayac1 = 0; sayac1 < 5; sayac1++)// dizeye eleman ekleme
            {
                sayi++;
                sayilar[sayac1] = sayi;
            }

            for (int sayac = 0; sayac < 5; sayac++)// ekrana yazdırma
            {
                Console.WriteLine(sayilar[sayac]);
            }


        }
    }
}