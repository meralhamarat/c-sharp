// Aşağıdaki C# kodu, kullanıcıdan başlangıç tarihini ve gün sayısını alır, ardından belirtilen gün sayısı kadar gün ekleyerek veya çıkararak yeni tarihi hesaplar ve ekrana yazdırır.

/* ************************************************************************** */
/*                                                                            */
/*                                                                            */
/*   Tarih_Hesaplama.cs                                                       */
/*                                                                            */
/*   By: meralhamarat24@gmail.com                                             */
/*                                                                            */
/* ************************************************************************** */

using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan başlangıç tarihini ve gün sayısını al
        Console.Write("Başlangıç tarihini girin (GG.AA.YYYY): ");
        string baslangicTarihiStr = Console.ReadLine();

        Console.Write("Gün eklemek için (E) veya gün çıkarmak için (C) seçin: ");
        char ekleCikarSecimi = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine(); // Yeni satıra geç

        if (ekleCikarSecimi == 'E')
        {
            Console.Write("Kaç gün eklemek istiyorsunuz: ");
        }
        else if (ekleCikarSecimi == 'C')
        {
            Console.Write("Kaç gün çıkarmak istiyorsunuz: ");
        }
        else
        {
            Console.WriteLine("Geçersiz seçim. Program sonlandırılıyor.");
            Console.ReadLine();
            return;
        }

        int gunSayisi = Convert.ToInt32(Console.ReadLine());

        // Tarih hesaplama fonksiyonunu çağır
        string yeniTarih = TarihHesapla(baslangicTarihiStr, ekleCikarSecimi, gunSayisi);

        // Sonucu ekrana yazdır
        Console.WriteLine($"Yeni tarih: {yeniTarih}");

        // Uygulama kapatma
        Console.ReadLine();
    }

    static string TarihHesapla(string baslangicTarihi, char ekleCikarSecimi, int gunSayisi)
    {
        // Başlangıç tarihini DateTime nesnesine çevir
        DateTime baslangicTarihiObj = DateTime.ParseExact(baslangicTarihi, "dd.MM.yyyy", null);

        // Belirtilen gün sayısı kadar gün ekleyerek veya çıkararak yeni tarihi bul
        DateTime yeniTarihObj = ekleCikarSecimi == 'E' ? baslangicTarihiObj.AddDays(gunSayisi) : baslangicTarihiObj.AddDays(-gunSayisi);

        // Yeni tarihi formatlı bir şekilde döndür
        return yeniTarihObj.ToString("dd.MM.yyyy");
    }
}
