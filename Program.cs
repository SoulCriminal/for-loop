using System;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan sayı girmesini istiyoruz
            Console.WriteLine("Lütfen bir sayı giriniz! ");
            int sayi = int.Parse(Console.ReadLine());// kullanıcının girdiği sayıyı sayi isminde değişkene atıyoruz atamadan önce int türüne dönüştürüyoruz
            // kullanıcının girdiği sayıyı döngüye length olarak atama yapıyoruz
            for (int i = 0 ; i <= sayi; i++){
                if (i%2 == 1){// mod alarak tek mi çift mi kontrol ediyoruz.
                    Console.WriteLine("0 dan girdiğiniz sayıya kadar olan tek sayılar: "+i); // girilen sayıya kadar olan tek sayılar
                }else {
                    Console.WriteLine("0 dan girdiğiniz sayıya kadar olan çift sayılar: "+i);// girilen sayıya kadar olan çift sayılar

                }
            }


            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i  = 0 ; i< 500; i++){
                if (i%2 ==  1){
                    tekToplam += i;
                }else {
                    ciftToplam += i;
                }
                Console.WriteLine("Tek Sayıların Toplamı: "+tekToplam);
                Console.WriteLine("Çift Sayıların Toplamı: "+ciftToplam);
            }

            
        }
    }
}
