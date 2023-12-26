using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace kitaplik_uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            int toplamfiyat = 0;
            string secim;
            Console.WriteLine("****************************************************************************");
            Console.WriteLine();
            Console.WriteLine("**  Türkçe Kitaplar Kategorisi      **  Yabancı Kitaplar Kategorisi       **");
            Console.WriteLine();
            Console.WriteLine("** 1-Çalıkuşu:Reşat Nuri Güntekin   **  7-Tuna Klavuzu:Julnes Verne       **");
            Console.WriteLine();
            Console.WriteLine("** 2-Yaban:Yakup Kadri              **  8-Bir Kuzey Macerası:Jack London  **");
            Console.WriteLine();
            Console.WriteLine("** 3-Sinekli Bakkal:Halide Edip     **  9-Altıncı Koğuş:Anton Çahov       **");
            Console.WriteLine();
            Console.WriteLine("** 4-Tehlikeli Oyunlar:Oğuz Atay    ** 10-Kumarbaz:Dostoyevski            **");
            Console.WriteLine();
            Console.WriteLine("** 5-Geçtiğim Günlerden:H.Yücel     ** 11-İki Şehrin Hikayesi:C.Dickens   **");
            Console.WriteLine();
            Console.WriteLine("** 6-Kuyucaklı Yusuf:S.Ali          ** 12-Vişne Bahçesi:Anton Çehov       **");
            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine();
            Console.WriteLine("***** İşlemler Menüsü *****");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5-Yeni Kitap Satın Al");
            Console.WriteLine("6-Oyun");
            Console.WriteLine();
            Console.Write("Yapmak istediğiniz işlemin numarası: ");
            //işlem yapmayacağım için bellekten tasarruf amaçlı char tanımladım
            char islem;
            islem = Convert.ToChar(Console.ReadLine());

            if (islem == '1')
            {
                Console.WriteLine();
                Console.Write("Lütfen fiyatını öğrenmek istediğiniz kitabın numarasını girin: ");
                string numara;
                numara = Console.ReadLine();
                switch (numara)
                {
                    case "1": Console.Write("Çalıkuşu:200 Tl"); break;
                    case "2": Console.Write("Yaban:190 Tl"); break;
                    case "3": Console.Write("Sinekli Bakkal:180 Tl"); break;
                    case "4": Console.Write("Tehlikeli Oyunlar:170 Tl"); break;
                    case "5": Console.Write("Geçtiğim Günlerden:180 Tl"); break;
                    case "6": Console.Write("Kuyucaklı Yusuf:185 Tl"); break;
                    case "7": Console.Write("Tuna Klavuzu:200 Tl"); break;
                    case "8": Console.Write("Bir Kuzey Maacerası:230 Tl"); break;
                    case "9": Console.Write("Altıncı Koğuş:190 Tl"); break;
                    case "10": Console.Write("Kumarbaz:175 Tl"); break;
                    case "11": Console.Write("İki Şehrin Hikayesi:180 Tl"); break;
                    case "12": Console.Write("Vişne Bahçesi:150 Tl"); break;
                    default: Console.Write("Böyle bir kitap mevcut değil,numarayı kontrol edin"); break;
                }


            }
            if (islem == '2')
            {
                Console.WriteLine("*******  Yeni Okur Kaaydı *******");
                string ad, soyad, universite;
                Console.Write("Adınız: ");
                ad=Console.ReadLine();
                Console.Write("Soyadınız: ");
                soyad=Console.ReadLine();
                Console.Write("Üniversiteniz:");
                universite=Console.ReadLine();

                string dosya = @"C:\Users\merye\OneDrive\Masaüstü\kullanici.txt";
                using (StreamWriter sw = new StreamWriter(dosya, true))
                {
                    sw.WriteLine("Adınız: " + ad);
                    sw.WriteLine("Soyadınız : " + soyad);
                    sw.WriteLine("Üniversite : " + universite);
                }
                Console.WriteLine("Yeni okur kaydı başarıyla oluşturuldu.");

            }
            
            if (islem == '3')
            {
                
        {
          
                // Kitapları bir dizi içinde sakla
                string[] kitaplar = {
                "Çalıkuşu",
                "Yaban",
                "Sinekli Bakkal",
                "Tehlikeli Oyunlar",
                "Geçtiğim Günlerden",
                "Kuyucaklı Yusuf",
                "Tuna Klavuzu",
                "Bir Kuzey Macerası",
                "Altıncı Koğuş",
                "Kumarbaz",
                "İki Şehrin Hikayesi",
                "Vişne Bahçesi"
        };

                // Random sınıfını kullanarak rastgele bir indeks seç
                Random random = new Random();
                int randomIndex = random.Next(0, kitaplar.Length);

                // Seçilen indeksteki kitabı ekrana yazdır
                string gununKitabi = kitaplar[randomIndex];

                Console.WriteLine();
                Console.WriteLine("*************************************************");
                Console.WriteLine();
                Console.WriteLine($"***** Bugünün kitabı: {gununKitabi} *****");
                Console.WriteLine();
                Console.WriteLine("*************************************************");
            }
        

    }
            if (islem == '4')
            {
                Console.WriteLine();
                Console.WriteLine("************************************************ ");
                Console.WriteLine();
                FileStream fs = new FileStream(@"C:\Users\merye\OneDrive\Masaüstü\kitaplar.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin=sr.ReadLine();
                while (metin != null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                //burası kitap arşivi olacak
                Console.WriteLine();
                Console.WriteLine("**************************************************");

            }
            if (islem == '5')
            {
                for (int i = 1; i < 100; i++)
                {
                    Console.WriteLine();
                    Console.Write("Alacağın kitabın numarası: ");
                    secim = Console.ReadLine();

                    if (secim == "1")
                    {
                        toplamfiyat = toplamfiyat + 200;
                    }
                    else if (secim == "2")
                    {
                        toplamfiyat = toplamfiyat + 190;
                    }
                    else if (secim == "3")
                    {
                        toplamfiyat = toplamfiyat + 180;
                    }
                    else if (secim == "4")
                    {
                        toplamfiyat = toplamfiyat + 170;
                    }
                    else if (secim == "5")
                    {
                        toplamfiyat = toplamfiyat + 180;
                    }
                    else if (secim == "6")
                    {
                        toplamfiyat = toplamfiyat + 185;
                    }
                    else if (secim == "7")
                    {
                        toplamfiyat = toplamfiyat + 200;
                    }
                    else if (secim == "8")
                    {
                        toplamfiyat = toplamfiyat + 230;
                    }
                    else if (secim == "9")
                    {
                        toplamfiyat = toplamfiyat + 190;
                    }
                    else if (secim == "10")
                    {
                        toplamfiyat = toplamfiyat + 175;
                    }
                    else if (secim == "11")
                    {
                        toplamfiyat = toplamfiyat + 180;
                    }
                    else if (secim == "12")
                    {
                        toplamfiyat = toplamfiyat + 150;
                    }
                    else
                    
                        Console.WriteLine("Böyle bir kitap numarası yok");
                        Console.WriteLine();
                        Console.WriteLine("Başka bir kitap almak ister misiniz?HAYIR(H)/EVET(E)");
                        string cevap=Console.ReadLine();
                    if (cevap == "h" || cevap == "H")
                        break;

                }
                Console.WriteLine("Toplam tutar:" + toplamfiyat);
            }
            if (islem == '6')
            {
                Console.WriteLine();
                int tahmin = 0;
                Random rnd = new Random();
                int sayi = rnd.Next(1, 100);
                while (sayi != tahmin)
                {
                    Console.Write("sayi giriniz:");
                    tahmin=Convert.ToInt32(Console.ReadLine());
                    if(tahmin>sayi)
                    {
                        Console.Write("Daha Küçük");
                    }
                    if (tahmin < sayi)
                    {
                        Console.Write("Daha büyük");
                    }
                    if (tahmin == sayi)
                    {
                        Console.Write("Bildiniz");
                        break;
                    }

                }



            }



            Console.Read();
        }
    }
}
