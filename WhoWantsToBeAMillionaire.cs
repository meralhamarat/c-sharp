/* ************************************************************************** */
/*                                                                            */
/*                                                                            */
/*   WhoWantsToBeAMillionaire.cs                                              */
/*                                                                            */
/*   By: meralhamarat24@gmail.com                                             */
/*                                                                            */
/* ************************************************************************** */

using System;

class MilyonerUygulamasi
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔══════════════════════════════════════════════════════╗");
        Console.WriteLine("║                 M I L Y O N E R                      ║");
        Console.WriteLine("║                  Y A R I S M A S I                   ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine("Milyoner Yarismasina hos geldiniz!");
        Console.WriteLine("Toplamda 10 soru bulunmaktadir. Her soru icin 4 secenek vardir ve");
        Console.WriteLine("dogru secenegi buldugunuzda odul miktariniz artar. Ancak dikkatli olun,");
        Console.WriteLine("yanlis bir cevap verdiginizde elenebilir ve kazandiginiz miktarı kaybedebilirsiniz.");
        Console.WriteLine("Basarilar dileriz!\n");

        string[] sorular = {
            "1. Hangi gezegen Gunes Sistemi'nde en büyük boyuta sahiptir?",
            "2. Kimyasal sembolü 'Hg' olan element nedir?",
            "3. Hangi yıl Albert Einstein Nobel Fizik Ödülü'nü kazanmıştır?",
            "4. Hangi ünlü ressam 'Yıldızlı Gece' tablosunu yapmıştır?",
            "5. Edebiyat tarihinde 'Divan-i Hikmet' adlı eseri ile tanınan kimdir?",
            "6. En hızlı hayvan hangisidir?",
            "7. Hangi element doğada tek başına diğer elementlerle bileşik yapmaz?",
            "8. Tarihteki ilk bilinen yazılı eser hangisidir?",
            "9. Hangi ülkenin bayrağında sadece bir renk vardır?",
            "10. İnsan vücudundaki en büyük iç organ hangisidir?"
        };

        string[][] cevaplar = {
            new string[] {"A) Mars", "B) Jupiter", "C) Venus", "D) Neptune"},
            new string[] {"A) Mercury", "B) Hydrogen", "C) Silver", "D) Lead"},
            new string[] {"A) 1915", "B) 1921", "C) 1927", "D) 1935"},
            new string[] {"A) Leonardo da Vinci", "B) Michelangelo", "C) Vincent van Gogh", "D) Pablo Picasso"},
            new string[] {"A) Yunus Emre", "B) Mevlana", "C) Hafez", "D) Fuzuli"},
            new string[] {"A) Cheetah", "B) Leopard", "C) Eagle", "D) Cheetah"},
            new string[] {"A) Oxygen", "B) Nitrogen", "C) Gold", "D) Radium"},
            new string[] {"A) Epic of Gilgamesh", "B) Iliad", "C) Mahabharata", "D) Oedipus Rex"},
            new string[] {"A) Libya", "B) Monaco", "C) Maldives", "D) Jamaica"},
            new string[] {"A) Heart", "B) Liver", "C) Lung", "D) Brain"}
        };

        string[] dogruCevaplar = {"B", "A", "C", "C", "B", "B", "A", "A", "B", "B"};

        int barajSoru1 = 3; // 3. soru baraj sorusu
        int barajSoru2 = 7; // 7. soru baraj sorusu
        int barajPuan1 = 0; // 0 TL baraj puanı
        int barajPuan2 = 50000; // 50,000 TL baraj puanı

        int puan = 0;

        for (int i = 0; i < sorular.Length; i++)
        {
            Console.WriteLine(sorular[i]);

            // Secenekleri yazdir
            for (int j = 0; j < cevaplar[i].Length; j++)
            {
                Console.WriteLine(cevaplar[i][j]);
            }

            Console.Write("Cevabinizi girin (A, B, C veya D): ");
            string kullaniciCevabi = Console.ReadLine().ToUpper(); // Kucuk veya buyuk harf girisine karsi duyarli degil

            if (kullaniciCevabi == dogruCevaplar[i])
            {
                // Soruyu dogru cevaplayinca puani guncelle
                puan += 20000;
                Console.WriteLine($"Dogru! Kazandiniz tutar: {puan} TL\n");

                // Baraj sorularini kontrol et ve devam et
                if (i + 1 == barajSoru1 || i + 1 == barajSoru2)
                {
                    if (puan >= barajPuan1 && i + 1 == barajSoru1)
                    {
                        barajPuan1 = puan; // Baraj sorusunu dogru bildiyse kazandigi parayi baraj puanina esitle
                        Console.WriteLine($"Tebrikler! {barajSoru1}. soruyu dogru bildiniz ve {barajPuan1} TL kazandiniz.");
                    }

                    if (puan >= barajPuan2 && i + 1 == barajSoru2)
                    {
                        barajPuan2 = puan; // Baraj sorusunu dogru bildiyse kazandigi parayi baraj puanina esitle
                        Console.WriteLine($"Tebrikler! {barajSoru2}. soruyu dogru bildiniz ve {barajPuan2} TL kazandiniz.");
                    }

                    Console.Write("Devam etmek istiyor musunuz? (Evet/Hayir): ");
                    string devamEt = Console.ReadLine().ToLower();

                    if (devamEt != "evet")
                    {
                        Console.WriteLine($"Yarisma sona erdi. Kazandiniz tutar: {puan} TL");
                        break;
                    }
                }
            }
            else
            {
                // Yanlis cevap durumunda oyunu bitir ve baraj paralarini kontrol et
                Console.WriteLine($"Yanlis. Dogru cevap: {dogruCevaplar[i]}.\n");

                if (i + 1 == barajSoru1 || i + 1 == barajSoru2)
                {
                    Console.WriteLine($"Yarisma sona erdi. Kazandiniz tutar: {puan} TL");
                    break;
                }
            }

            // Yanlis cevap durumunda oyunu bitir
            if (kullaniciCevabi != dogruCevaplar[i])
            {
                Console.WriteLine($"Yarisma sona erdi. Kazandiniz tutar: {puan} TL");
                break;
            }
        }

        // Konsol penceresini kapatmadan once kullanicinin girisini beklet
        Console.ReadLine();
    }
}
