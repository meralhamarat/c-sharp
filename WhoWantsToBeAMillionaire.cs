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
        Console.WriteLine("║                 M İ L Y O N E R                      ║");
        Console.WriteLine("║                  Y A R I Ş M A S I                   ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine("Milyoner Yarismasina hos geldiniz!");
        Console.WriteLine("Toplamda 10 soru bulunmaktadir. Her soru icin 4 secenek vardir ve");
        Console.WriteLine("dogru secenegi buldugunuzda odul miktariniz artar. Ancak dikkatli olun,");
        Console.WriteLine("yanlis bir cevap verdiginizde elenebilir ve kazandiginiz miktarı kaybedebilirsiniz.");
        Console.WriteLine("Basarilar dileriz!\n");

        string[] sorular = {
            "1. Türkiye'nin başkenti nedir?",
            "2. Hangi gezegen Güneş Sistemi'nde üçüncü sıradadır?",
            "3. Hangi renk gökkuşağının ilk rengidir?",
            "4. Hangi yıl Türkiye'de Cumhuriyet ilan edilmiştir?",
            "5. İnsan vücudunda kaç adet kalp bulunur?",
            "6. Hangi elementin simgesi 'O' harfi ile gösterilir?",
            "7. Hangi yıl Leonardo da Vinci doğmuştur?",
            "8. Türkiye'nin en yüksek dağı hangisidir?",
            "9. Hangi hayvan memeli değildir?",
            "10. Hangi gezegen 'Akrep Kuyruğu'na sahiptir?"
        };

        string[][] cevaplar = {
            new string[] {"A) İstanbul", "B) Ankara", "C) İzmir", "D) Bursa"},
            new string[] {"A) Mars", "B) Venüs", "C) Dünya", "D) Jüpiter"},
            new string[] {"A) Kırmızı", "B) Mavi", "C) Sarı", "D) Yeşil"},
            new string[] {"A) 1920", "B) 1921", "C) 1922", "D) 1923"},
            new string[] {"A) 1", "B) 2", "C) 4", "D) 6"},
            new string[] {"A) Hidrojen", "B) Oksijen", "C) Karbon", "D) Azot"},
            new string[] {"A) 1400", "B) 1452", "C) 1500", "D) 1550"},
            new string[] {"A) Ağrı Dağı", "B) Erciyes", "C) Cilo Dağı", "D) Süphan Dağı"},
            new string[] {"A) Fil", "B) Kartal", "C) Yılan", "D) Köpek"},
            new string[] {"A) Jüpiter", "B) Mars", "C) Neptün", "D) Uranüs"}
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

            // Seçenekleri yazdır
            for (int j = 0; j < cevaplar[i].Length; j++)
            {
                Console.WriteLine(cevaplar[i][j]);
            }

            Console.Write("Cevabınızı girin (A, B, C veya D): ");
            string kullaniciCevabi = Console.ReadLine().ToUpper(); // Küçük veya büyük harf girişine karşı duyarlı değil

            if (kullaniciCevabi == dogruCevaplar[i])
            {
                // Soruyu doğru cevaplayınca puanı güncelle
                puan += 10000;
                Console.WriteLine($"Doğru! Kazandığınız tutar: {puan} TL\n");

                // Baraj sorularını kontrol et ve devam et
                if ((i + 1 == barajSoru1 || i + 1 == barajSoru2) && puan >= barajPuan1)
                {
                    if (i + 1 == barajSoru1)
                    {
                        barajPuan1 = puan; // Baraj sorusunu doğru bildiyse kazandığı parayı baraj puanına eşitle
                        Console.WriteLine($"Tebrikler! {barajSoru1}. soruyu doğru bildiniz ve {barajPuan1} TL kazandınız.");
                    }

                    if (i + 1 == barajSoru2)
                    {
                        barajPuan2 = puan; // Baraj sorusunu doğru bildiyse kazandığı parayı baraj puanına eşitle
                        Console.WriteLine($"Tebrikler! {barajSoru2}. soruyu doğru bildiniz ve {barajPuan2} TL kazandınız.");
                    }
                }
            }
            else
            {
                // Yanlış cevap durumunda oyunu bitir ve baraj paralarını kontrol et
                Console.WriteLine($"Yanlış. Doğru cevap: {dogruCevaplar[i]}.\n");

                if (i + 1 == barajSoru1 || i + 1 == barajSoru2)
                {
                    Console.WriteLine($"Yarışma sona erdi. Kazandığınız tutar: {puan} TL");
                    break;
                }
            }

            // Yanlış cevap durumunda oyunu bitir
            if (kullaniciCevabi != dogruCevaplar[i])
            {
                Console.WriteLine($"Yarışma sona erdi. Kazandığınız tutar: {puan} TL");
                break;
            }
        }

        // Konsol penceresini kapatmadan önce kullanıcı girişini beklet
        Console.ReadLine();
    }
}
