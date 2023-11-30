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
            "1. Turkiye'nin baskenti nedir?",
            "2. Hangi gezegen Gunes Sistemi'nde ucuncu siradadir?",
            "3. Hangi renk gokkusaginin ilk rengidir?",
            "4. Hangi yil Turkiye'de Cumhuriyet ilan edilmistir?",
            "5. Insan vucudunda kac adet kalp bulunur?",
            "6. Hangi elementin simgesi 'O' harfi ile gosterilir?",
            "7. Hangi yil Leonardo da Vinci dogmustur?",
            "8. Turkiye'nin en yuksek dagi hangisidir?",
            "9. Hangi hayvan memeli degildir?",
            "10. Hangi gezegen 'Akrep Kuyrugu'na sahiptir?"
        };

        string[][] cevaplar = {
            new string[] {"A) Istanbul", "B) Ankara", "C) Izmir", "D) Bursa"},
            new string[] {"A) Mars", "B) Venus", "C) Dunya", "D) Jupiter"},
            new string[] {"A) Kirmizi", "B) Mavi", "C) Sari", "D) Yesil"},
            new string[] {"A) 1920", "B) 1921", "C) 1922", "D) 1923"},
            new string[] {"A) 1", "B) 2", "C) 4", "D) 6"},
            new string[] {"A) Hidrojen", "B) Oksijen", "C) Karbon", "D) Azot"},
            new string[] {"A) 1400", "B) 1452", "C) 1500", "D) 1550"},
            new string[] {"A) Agri Dagi", "B) Erciyes", "C) Cilo Dagi", "D) Suphan Dagi"},
            new string[] {"A) Fil", "B) Kartal", "C) Yilan", "D) Kopek"},
            new string[] {"A) Jupiter", "B) Mars", "C) Neptun", "D) Uranus"}
        };

        string[] dogruCevaplar = {"B", "C", "A", "D", "A", "B", "B", "A", "C", "C"};

        int barajSoru1 = 2; // 2. soru baraj sorusu
        int barajSoru2 = 5; // 5. soru baraj sorusu
        int barajPuan1 = 0; // 0 TL baraj puanı
        int barajPuan2 = 20000; // 20,000 TL baraj puanı

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
                puan += 10000;
                Console.WriteLine($"Dogru! Kazandiniz tutar: {puan} TL\n");

                // Baraj sorularini kontrol et ve devam et
                if ((i + 1 == barajSoru1 || i + 1 == barajSoru2) && puan >= barajPuan1)
                {
                    if (i + 1 == barajSoru1)
                    {
                        barajPuan1 = puan; // Baraj sorusunu dogru bildiyse kazandigi parayi baraj puanina esitle
                        Console.WriteLine($"Tebrikler! {barajSoru1}. soruyu dogru bildiniz ve {barajPuan1} TL kazandiniz.");
                    }

                    if (i + 1 == barajSoru2)
                    {
                        barajPuan2 = puan; // Baraj sorusunu dogru bildiyse kazandigi parayi baraj puanina esitle
                        Console.WriteLine($"Tebrikler! {barajSoru2}. soruyu dogru bildiniz ve {barajPuan2} TL kazandiniz.");
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
