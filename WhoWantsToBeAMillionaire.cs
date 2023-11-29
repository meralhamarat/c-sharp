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

        string[] dogruCevaplar = {
            "Ankara",
            "Dünya",
            "Kırmızı",
            "1923",
            "1",
            "Oksijen",
            "1452",
            "Ağrı Dağı",
            "Yılan",
            "Neptün"
        };

        int barajSorusu = 4; // 4. soru baraj sorusu
        int barajPuanı = 35000; // 35,000 TL baraj puanı

        int puan = 0;

        for (int i = 0; i < sorular.Length; i++)
        {
            Console.WriteLine(sorular[i]);

            Console.Write("Cevabınız: ");
            string kullaniciCevabi = Console.ReadLine();

            if (kullaniciCevabi.ToLower() == dogruCevaplar[i].ToLower())
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
