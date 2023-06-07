List<Valami> valamik = new List<Valami>();

// Megszámlálás
int szamlalas = valamik.Count;

// Átlag
double atlag = valamik.Average(a => a.Szam);

// Összegzés
int osszeg = valamik.Sum(a => a.Szam);

// Minimum és maximum
int minimum = valamik.Min(a => a.Szam);
int maximum = valamik.Max(a => a.Szam);



// Kiválasztás
    // a)
    Valami kivalasztott = valamik.FirstOrDefault(a => a.Nev.Equals("Valami neve")); //ha nincs találat null-t ad
    string neve = (kivalasztott == null) ? "Nincs találat" : kivalasztott.Nev;

    // b)
    Valami kivalasztott = valamik.Find(a => a.Nev.Equals("Valami neve"));
    string neve = (kivalasztott == null) ? "Nincs találat" : kivalasztott.Nev;


// Eldöntés
bool vanValami = valamik.Any(a => a.Szam > 10);

// Keresés
Valami talalt = valamik.Find(a => a.Id == 123);
int szam = (talalt == null) ? 0 : talalt.Szam;

// Rendezés
    // a)
    List<int> rendezettLista = szamok.OrderBy(szam => szam).ToList();
    // b)
    egyediSzam.Sort();

// Rendezés növekvő sorrendben (születési év szerint növekvő)
List<Valami> rendezettNovelo = valamik.OrderBy(a => a.Datum).ToList();

// Rendezés csökkenő sorrendben (születési év szerint csökkenő)
List<Valami> rendezettCsokkeno = valamik.OrderByDescending(a => a.Nev).ToList();

// Lista megfordítása
List<Valami> megforditott = valamik.Reverse().ToList();

// Szűrés
    //szám
    List<Valami> szurtValamik = valamik.Where(a => a.Szam > 100).ToList();
    //szöveg
    List<Valami> szurtValamik = valamik.Where(a => a.Nev.Contains("Valami neve")).ToList();


// Legidősebb valami megtalálása
Valami legidosebbValami = valamik.OrderBy(a => a.Datum).FirstOrDefault();

// Legfiatalabb valami megtalálása
Valami legfiatalabbValami = valamik.OrderByDescending(a => a.Datum).FirstOrDefault();





// Az összes elem lekérése egy listába
List<Valami> osszesElem = valamik.ToList();

// Összes valami nevének lekérése listában
List<string> nevek = valamik.Select(a => a.Nev).ToList();


// Egyező névű valamik megtalálása
List<Valami> szurtValamik = valamik.Where(a => a.Nev.Equals("Valami neve")).ToList();
Valami egyezoNevuValami = valamik.FirstOrDefault(a => a.Nev.Equals("Valami neve"));

// Egyedi valami nevek
List<string> egyediNevek = valamik.Select(a => a.Nev).Distinct().ToList();



// "Kiss" vezetéknévű valamik listája
List<Valami> kissVezeteknevuValamik = valamik.Where(a => a.Vezeteknev.Equals("Kiss")).ToList();

// Van-e "Kiss Ádám" nevű valami
bool vanKissAdam = valamik.Any(a => a.Nev.Equals("Kiss Ádám"));

// "Nagy Éva" nevű valami hanyadik indexen van
int nagyEvaIndex = valamik.FindIndex(a => a.Nev.Equals("Nagy Éva"));

// Összes valami neve kisbetűssé alakítva
List<string> kisbetusNevek = valamik.Select(a => a.Nev.ToLower()).ToList();



// --------------------------------------------------------------------------------

// Index alapján történő kiválasztás
int index = 3;
Valami valamiIndexAlapjan = valamik.ElementAtOrDefault(index);
// Valami valamiIndexAlapjan = valamik[index];

// Elemek kihagyása és kiválasztása
List<Valami> kihagyottValamik = valamik.Skip(5).Take(10).ToList();

// Az első vagy az alapértelmezett elem kiválasztása
Valami elsoValami = valamik.FirstOrDefault();
Valami elsoVagyAlapertelmezett = valamik.FirstOrDefault(a => a.Szam > 10) ?? new Valami();

// Az utolsó vagy az alapértelmezett elem kiválasztása
Valami utolsoValami = valamik.LastOrDefault();
Valami utolsoVagyAlapertelmezett = valamik.LastOrDefault(a => a.Szam > 10) ?? new Valami();

// Első vagy egyetlen elem kiválasztása vagy hiba kezelése
Valami elsoElem = valamik.Single();
Valami egyetlenElem = valamik.SingleOrDefault();

// Csoportosítás
var csoportositottValamik = valamik.GroupBy(a => a.Nev);
// IEnumerable<IGrouping<string, Valami>> csoportositottValamik = valamik.GroupBy(a => a.Nev);