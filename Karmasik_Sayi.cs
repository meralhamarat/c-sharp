public class KarmasikSayi
{
    private int x;
    private int y;

    // Default constructor
    public KarmasikSayi()
    {
        x = 0; y = 0;
    }

    // Parametreli constructor
    public KarmasikSayi(int m, int n)
    {
        x = m; y = n;
    }

    // Property
    public string Yazdir
    {
        get { return x + "i" + (y >= 0 ? "+" : "") + y; }
    }

    // İki karmaşık sayıyı çıkarma
    public static KarmasikSayi operator -(KarmasikSayi c1, KarmasikSayi c2)
    {
        KarmasikSayi temp = new KarmasikSayi();
        temp.x = c1.x - c2.x;
        temp.y = c1.y - c2.y;
        return temp;
    }
}