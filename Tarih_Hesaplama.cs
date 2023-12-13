// Aşağıdaki C# kodu, kullanıcıdan başlangıç tarihini ve gün sayısını alır, ardından belirtilen gün sayısı kadar gün ekleyerek yeni tarihi hesaplar ve ekrana yazdırır.

using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan başlangıç tarihini ve gün sayısını al
        Console.Write("Başlangıç tarihini girin (GG.AA.YYYY): ");
        string baslangicTarihiStr = Console.ReadLine();

        Console.Write("Kaç gün eklemek istiyorsunuz: ");
        int gunSayisi = Convert.ToInt32(Console.ReadLine());

        // Tarih hesaplama fonksiyonunu çağır
        string yeniTarih = TarihHesapla(baslangicTarihiStr, gunSayisi);

        // Sonucu ekrana yazdır
        Console.WriteLine($"Yeni tarih: {yeniTarih}");

        // Uygulama kapatma
        Console.ReadLine();
    }

    static string TarihHesapla(string baslangicTarihi, int gunSayisi)
    {
        // Başlangıç tarihini DateTime nesnesine çevir
        DateTime baslangicTarihiObj = DateTime.ParseExact(baslangicTarihi, "dd.MM.yyyy", null);

        // Belirtilen gün sayısı kadar gün ekleyerek yeni tarihi bul
        DateTime yeniTarihObj = baslangicTarihiObj.AddDays(gunSayisi);

        // Yeni tarihi formatlı bir şekilde döndür
        return yeniTarihObj.ToString("dd.MM.yyyy");
    }
}
