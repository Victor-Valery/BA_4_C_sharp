using System;

namespace BA_C_SHARP_4
{
    class Program
    {
        static void Main(string[] args)
        {

            // IF-ELSE -- ELSE IF

            //SORU: Veri tabanimiz olsun. Kullanici adi ve sifremiz saklansin.
            //Ekrandan kullaniciya sifre ve parola sorarak sisteme alan bir algoritma gelistirelim.


            //PSUDEO KOD YAZMA 

            //1. SABIT KULLANICI ADI VE SIFRE OLMALI  
            //2. EKRANDAN KULLANICI ADINI AL
            //3. KULLANICI ADINI STRING BIR DEGISKENE ATA
            //4. EKRANDAN PAROLAYI AL
            //5. PAROLAYI STRING BIR DEGISKENE ATA
            //6. KULLANICI ADI VE PAROLAYI KONTROL ET
            //7. DOGU VE YANLIS DURUMLAR GÖRE CIKTILAR ÜRET 


            while (true)
            {

           string kullaniciAdi = "Admin";
            string parola = "12345";

            Console.WriteLine("KullaniciAdi Adini Giriniz: ");
            string ekranKullaniciAdi = Console.ReadLine();

            Console.WriteLine("Parola Giriniz: ");
            string ekranParola = Console.ReadLine();


            if (kullaniciAdi == ekranKullaniciAdi && parola == ekranParola)
            {
                Console.WriteLine("HOSGELDINIZ");
                break;
            }

            else
            {
                Console.WriteLine("Kullanici Adi veya Sifre yanlis");
            }

            }

 





        }
    }
}
