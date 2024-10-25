using System.Collections.Generic;
using System.Linq;

public class Bokningshantering
{
    public List<Pass> PassLista { get; set; }

    public Bokningshantering()
    {
        PassLista = new List<Pass>
        {
            new Pass("Yoga", new DateTime(2024, 10, 23, 18, 0, 0), "Yoga", 10),
            new Pass("Spinning", new DateTime(2024, 10, 23, 19, 0, 0), "Spinning", 0),
            new Pass("Pilates", new DateTime(2024, 10, 23, 20, 0, 0), "Pilates", 5),
            new Pass("Boxning", new DateTime(2024, 10, 23, 20, 0, 0), "Boxning", 4)
        };
    }

    public List<Pass> SökPass(string sökTerm)
    {
        return PassLista.Where(p => p.Namn.ToLower().Contains(sökTerm.ToLower()) ||
                                     p.Kategori.ToLower().Contains(sökTerm.ToLower())).ToList();
    }
}

