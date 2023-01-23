using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yanlis_Carpma_Sorusu
{
    internal class Program
    {

        static void Main(string[] args)
        {
            KarsilamaMesaji();
            Console.WriteLine($"işlemin sonucu : {YanlisIslemiYap(BirinciSayiAl(), IkinciSayiAl())}");
            Console.ReadLine();
        }
        private static double YanlisIslemiYap(int sayi1, int sayi2)
        {
            int sayac = 0, sayiTut, mod;
            double toplam = 0;
            sayiTut = sayi1;
            while (sayiTut > 0)
            {
                mod = sayiTut % 10;
                sayiTut /= 10;
                toplam += ((mod * sayi2) % 10) * Math.Pow(10, sayac);
                sayac++;
            }
            return toplam;
        }
        private static int IkinciSayiAl()
        {
            int ikinciSayi, sayiTut = 0, modToplam = 0, mod;
        tekrardanGit:
            try
            {
                do
                {
                    Console.WriteLine("Lütfen max 3 basamaklı bir sayı giriniz");
                    ikinciSayi = Convert.ToInt32(Console.ReadLine());
                    if (ikinciSayi > 999)
                    {
                        Console.WriteLine("Girdiğiniz sayı max 3 basamaklı olmalıdır. Tekrar deneyiniz");
                    }
                } while (ikinciSayi > 999);
                sayiTut = ikinciSayi;
                while (sayiTut > 0)
                {
                    mod = sayiTut % 10;
                    sayiTut /= 10;
                    modToplam += mod;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Lütfen sayısal değer giriniz");
                goto tekrardanGit;
            }
            return modToplam % 10;
        }
        private static int BirinciSayiAl()
        {
            int birinciSayi;
        tekrardanGit1:
            try
            {
                Console.WriteLine("\nLütfen bir sayı giriniz");
                birinciSayi = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Lütfen sayısal değer giriniz");
                goto tekrardanGit1;
            }
            return birinciSayi;
        }
        private static void KarsilamaMesaji()
        {
            Console.WriteLine("Bu program girilen iki sayının çarpım işlemini yanlış yapmaktadır. Çarpma yapılırken basamak değerlerine bakılmaksızın sayılar sola kaydırılmadan alt alta toplanılır ve herhangi bir toplama işlemi için hiçbir zaman sonraki basamağa elde eklenmemektedir");
        }

    }
}
