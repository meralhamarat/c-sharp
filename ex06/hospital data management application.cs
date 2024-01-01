using System;
using System.Collections.Generic;
namespace sağlıkproje
{
    // Hasta sınıfı
    public class Hasta
    {
        public long? TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Hasta? Onceki { get; set; }
        public Hasta? Sonraki { get; set; }
        public List<Ilac> AlmasıGerekenIlaclar { get; set; }
        public List<Doktor> GittigiDoktor { get; set; }
        public List<Hastalik> Hastaligi { get; set; }


        public override string ToString()
        {
            return $"{TC}. {Ad} {Soyad}";
        }
    }


    // Ilaç sınıfı
    public class Ilac
    {
        public long? TC { get; set; }
        public string Ad { get; set; }
        public Ilac? Onceki { get; set; }
        public Ilac? Sonraki { get; set; }

        public override string ToString()
        {
            return $"{TC}. {Ad}";
        }
    }

    // Doktor sınıfı
    public class Doktor
    {
        public long TC { get; set; }
        public string Ad { get; set; }
        public string Brans { get; set; }
        public Doktor? Onceki { get; set; }
        public Doktor? Sonraki { get; set; }

        public override string ToString()
        {
            return $"{TC}. {Ad} ({Brans})";
        }
    }

    // Hastalık sınıfı
    public class Hastalik
    {
        public long TC { get; set; }
        public string Ad { get; set; }
        public Hastalik? Onceki { get; set; }
        public Hastalik? Sonraki { get; set; }

        public override string ToString()
        {
            return $"{TC}. {Ad}";
        }
    }

    // Çift bağlı dairesel liste sınıfı
    public class Node<T>
    {
        public T? TC { get; set; }
        public Node<T>? Onceki { get; set; }
        public Node<T>? Sonraki { get; set; }
    }

    public class CiftBagliDaireselListe<T>
    {
        private Node<T>? Bas;

        public void Ekle(T eleman)
        {
            Node<T> newNode = new Node<T> { TC = eleman };

            if (Bas == null)
            {
                Bas = newNode;
                Bas.Onceki = Bas;
                Bas.Sonraki = Bas;
            }
            else
            {
                newNode.Onceki = Bas.Onceki;
                newNode.Sonraki = Bas;
                Bas.Onceki!.Sonraki = newNode;
                Bas.Onceki = newNode;
            }
        }

        public T? KimlikleSorgula(Func<T, bool> sorgu)
        {
            if (Bas == null)
                return default;

            Node<T> current = Bas;
            do
            {
                if (sorgu(current.TC!))
                    return current.TC;

                current = current.Sonraki!;
            } while (current != Bas);

            return default;
        }
    }


    class Program
    {
        public class Eczacilik
        {
            public Hasta? HastaBilgileriniGetir(long TC, CiftBagliDaireselListe<Hasta> hastaListesi, CiftBagliDaireselListe<Doktor> doktorListesi, CiftBagliDaireselListe<Hastalik> hastalikListesi, CiftBagliDaireselListe<Ilac> ilacListesi)
            {
                return hastaListesi.KimlikleSorgula(h => h.TC == TC);
            }
        }
        static void Main(string[] args)
        {
            // Çift bağlı dairesel listeler
            CiftBagliDaireselListe<Hasta> hastaListesi = new CiftBagliDaireselListe<Hasta>();
            CiftBagliDaireselListe<Ilac> ilacListesi = new CiftBagliDaireselListe<Ilac>();
            CiftBagliDaireselListe<Doktor> doktorListesi = new CiftBagliDaireselListe<Doktor>();
            CiftBagliDaireselListe<Hastalik> hastalikListesi = new CiftBagliDaireselListe<Hastalik>();

           
            hastaListesi.Ekle(new Hasta { TC = 46573806740, Ad = "Hiranur", Soyad = "Sazak" });
            hastaListesi.Ekle(new Hasta { TC = 23746982347, Ad = "Nisa Nur", Soyad = "Özdal" });
            hastaListesi.Ekle(new Hasta { TC = 89374938243, Ad = "Nisa Gül", Soyad = "Ünal" });
            hastaListesi.Ekle(new Hasta { TC = 98723424674, Ad = "Berfin", Soyad = "Geleş" });

            ilacListesi.Ekle(new Ilac { TC = 46573806740, Ad = "Theraflu Forte" });
            ilacListesi.Ekle(new Ilac { TC = 46573806740, Ad = "Ketober %1.6 Gargara" });
            ilacListesi.Ekle(new Ilac { TC = 46573806740, Ad = "Aferin Sinüs" });
            ilacListesi.Ekle(new Ilac { TC = 23746982347, Ad = "Paraflex 20 Komprime" });
            ilacListesi.Ekle(new Ilac { TC = 23746982347, Ad = "Sul jel %3 30 gr Jel" });
            ilacListesi.Ekle(new Ilac { TC = 23746982347, Ad = "Edolar 500 mg 14 ftb" });
            ilacListesi.Ekle(new Ilac { TC = 89374938243, Ad = "Laksafenol" });
            ilacListesi.Ekle(new Ilac { TC = 89374938243, Ad = "Axeparin" });
            ilacListesi.Ekle(new Ilac { TC = 89374938243, Ad = "Cynacal" });
            ilacListesi.Ekle(new Ilac { TC = 98723424674, Ad = "BlefariTTO Göz Jeli 20 ml" });
            ilacListesi.Ekle(new Ilac { TC = 98723424674, Ad = "LOTEBRA %0.5 + %0.3 göz damlası" });
            ilacListesi.Ekle(new Ilac { TC = 98723424674, Ad = "TERRAMYCIN 5 mg/ 10.000 IU göz merhemi" });

            doktorListesi.Ekle(new Doktor{ TC = 46573806740, Ad = "Dr. Ömer Kaplan", Brans = "Kulak, Burun, Boğaz" });
            doktorListesi.Ekle(new Doktor { TC = 23746982347, Ad = "Dr. Ali Nazmican Güröz ", Brans = "Ortopedi" });
            doktorListesi.Ekle(new Doktor { TC = 89374938243, Ad = "Dr. Bekir Borazan", Brans = "Dahiliye" });
            doktorListesi.Ekle(new Doktor { TC = 98723424674, Ad = "Dr. Pınar İnan", Brans = "Göz Hastalıkları" });

            hastalikListesi.Ekle(new Hastalik { TC = 46573806740, Ad = "Nezle" });
            hastalikListesi.Ekle(new Hastalik { TC = 46573806740, Ad = "Farenjit" });
            hastalikListesi.Ekle(new Hastalik { TC = 46573806740, Ad = "Sinüzit" });
            hastalikListesi.Ekle(new Hastalik { TC = 23746982347, Ad = "Menisküs Yırtığı" });
            hastalikListesi.Ekle(new Hastalik { TC = 89374938243, Ad = "Gastroenteroloji" });
            hastalikListesi.Ekle(new Hastalik { TC = 89374938243, Ad = "Hematoloji" });
            hastalikListesi.Ekle(new Hastalik { TC = 89374938243, Ad = "Nefroloji" });
            hastalikListesi.Ekle(new Hastalik { TC = 98723424674, Ad = "Göz Enfeksiyonu" });
            Eczacilik eczacilik = new Eczacilik();

            Console.WriteLine("\n...Kimlikle Sorgulama...");

            Console.Write("Lütfen TC kimlik numarasını giriniz: ");
            if (long.TryParse(Console.ReadLine(), out long TC))
            {
                Hasta? hasta = eczacilik.HastaBilgileriniGetir(TC,hastaListesi,doktorListesi, hastalikListesi, ilacListesi);

                if (hasta != null)
                {
                    Console.WriteLine($"Hasta Bilgileri:\nAd: {hasta.Ad} {hasta.Soyad}\n"+
                                      $"Doktor: {hasta.GittigiDoktor}\n"+
                                      $"Hastalık: {hasta.Hastaligi}\n"+
                                      $"Alması Gereken İlaçlar: {hasta.AlmasıGerekenIlaclar}");
                  
                }
                else
                {
                    Console.WriteLine("Hasta bulunamadı.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz TC kimlik numarası girdiniz.");
            }
            Console.ReadKey();
        }

    }
}
