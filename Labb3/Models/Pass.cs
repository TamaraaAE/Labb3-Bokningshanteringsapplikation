public class Pass
{
    public string Namn { get; set; }
    public DateTime Tid { get; set; }
    public string Kategori { get; set; }
    public int AntalPlatser { get; set; }
    public bool Fullbokat => AntalPlatser <= 0;

    public Pass(string namn, DateTime tid, string kategori, int antalPlatser)
    {
        Namn = namn;
        Tid = tid;
        Kategori = kategori;
        AntalPlatser = antalPlatser;
    }
}

