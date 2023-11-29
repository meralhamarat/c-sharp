using System;

class MilyonerUygulamasi
{
    static void Main()
    {
        Console.WriteLine("Milyoner Yarışması'na Hoş Geldiniz!");

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

        int barajSorusu = 4; // 4. soru baraj sorusu
        int barajPuanı = 35000; // 35,000 TL baraj puanı

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
                Console.WriteLine("Doğru!\n");
                puan++;

                // Baraj sorusu kontrolü
                if (i == barajSorusu - 1 && puan >= barajPuanı)
                {
                    Console.WriteLine($"Tebrikler! Barajı geçtiniz ve {barajPuanı} TL kazandınız.");
                    break;
                }
            }
            else
            {
                Console.WriteLine($"Yanlış. Doğru cevap: {dogruCevaplar[i]}.\n");
                Console.WriteLine($"Yarışma sona erdi. Kazandığınız tutar: {puan * 10000} TL");
                break;
            }
        }

        // Konsol penceresini kapatmadan önce kullanıcı girişini beklet
        Console.ReadLine();
    }
}
