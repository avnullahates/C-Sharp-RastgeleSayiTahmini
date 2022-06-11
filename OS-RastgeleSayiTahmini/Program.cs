using System;

namespace OS_RastgeleSayiTahmini
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 1;

            Random rnd = new Random(); // Instance almak (Ornek almak): rnd isimli nesne Random sinifini ozelliklerini alir.
            int tutulanSayi = rnd.Next(1, 101); // Max value nun bir altindaki degere kadar rastgele sayi uretir.
            Console.WriteLine("****************Sayi Tahmini Oyunu************");

        yeniTahmin: Console.Write("Bir sayi giriniz: ");
            int tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());




            if (sayac <= 10)
            {
                if (tahminEdilenSayi > tutulanSayi)
                {
                    Console.WriteLine("Buyuk bir sayi girdiniz. Tekrar giriniz.");
                    sayac++;
                    goto yeniTahmin;
                }
                else if (tahminEdilenSayi < tutulanSayi)
                {
                    Console.WriteLine("Kucuk bir sayi girdiniz. Tekrar giriniz.");
                    sayac++;
                    goto yeniTahmin;
                }
                else if (tahminEdilenSayi == tutulanSayi)
                {
                    Console.WriteLine($"Tebrikler. {sayac}. tahminde bildiniz. ");
                }

            }
            else
            {
                Console.WriteLine("10 tahminde bilemediniz. Oyun bitmistir.");
            }

            Console.WriteLine("Girdiginiz Sayi: " + tahminEdilenSayi);
            Console.WriteLine("Tahmin ettiginiz sayi: " + tutulanSayi);
            Console.ReadLine();



        }
    }
}
