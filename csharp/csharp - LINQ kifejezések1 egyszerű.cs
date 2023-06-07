// LINQ műveletek/kifejezések

List<int> szamok = new List<int> { 10, 5, -3, 0, 32, 25, -12 };
List<string> szavak = new List<string> { "kis", "nagy", "szögletes", "kerek", "kemény", "puha" };

// Számok átlaga
double atlag = szamok.Average();

// Számok összege
int osszeg = szamok.Sum();

// Számok maximuma
int max = szamok.Max();

// Számok minimuma
int min = szamok.Min();

// Elemek száma a szamok listában
int szamokSzama = szamok.Count;

// Számok növekvő sorrendben rendezése
szamok.Sort();

// Lista elemek betűrendbe rendezése
szavak.Sort();

// Számok lista megfordítása
szamok.Reverse();

// Számok csökkenő sorrendben rendezése
    // a)
    szamok.Sort((a, b) => b.CompareTo(a));
    // b)
    szamok.Sort();
    szamok.Reverse();

// Lista elemeinek megfordítása
List<int> megforditottSzamok = szamok.Reverse().ToList();


// Szavak egyesítése egyetlen sztringgé
string egyesitettSzavak = string.Join(", ", szavak);

// Kiválasztás az index alapján
string elem = szavak[2];

// Megkeresés a szavak listában
List<string> talalatok = szavak.FindAll(szo => szo.Contains("k"));

// Egy elem megtalálása a szavak listában
string talalat = szavak.Find(szo => szo.Contains("k")); // az első elem, amit talál
string eredmeny = (talalat == null) ? "Nincs találat" : talalat; // null ellenőrzés

// Index megtalálása
int index = szavak.IndexOf("kerek");

// Eldöntés, hogy egy érték szerepel-e a listában
bool megtalalhato = szavak.Contains("puha");

// Szavak konverziója kisbetűssé
List<string> kisbetusSzavak = szavak.Select(szo => szo.ToLower()).ToList();

// Számok szűrése páros értékekre
List<int> parosSzamok = szamok.Where(szam => szam % 2 == 0).ToList();

// Lista elemeinek egyedi elemekre szűrése
List<int> egyediSzamok = szamok.Distinct().ToList();

// Conditional Operator
// (feltétel) ? igaz : hamis


// ---------

// -- Select: Egy új listát hoz létre a forrás lista elemek módosított változataiból.
// Számok összes elemének duplázása
List<int> duplazottSzamok = szamok.Select(szam => szam * 2).ToList();

// Szavak lista elemeinek hossza
List<int> szavakHossza = szavak.Select(szo => szo.Length).ToList();

// Szavak lista elemeinek visszafelé írt változata
List<string> forditottSzavak = szavak.Select(szo => new string(szo.Reverse().ToArray())).ToList();

// -- Where
// Számok szűrése pozitív értékekre
List<int> pozitivSzamok = szamok.Where(szam => szam > 0).ToList();

// Szavak szűrése adott hosszúságúakra
int hossz = 4;
List<string> hosszuSzavak = szavak.Where(szo => szo.Length >= hossz).ToList();

// Adott érték elhagyása a szamok listából
int elhagyniKivantSzam = 5;
List<int> elhagyottSzamok = szamok.Where(szam => szam != elhagyniKivantSzam).ToList();

// Számok összege csak a pozitív értékekből
int pozitivOsszeg = szamok.Where(szam => szam > 0).Sum();

// Számok párosítása a hozzájuk tartozó szavakkal egy új listában
List<string> parositottLista = szamok.Zip(szavak, (szam, szo) => $"{szam}-{szo}").ToList();

// Szavak szűrése kezdőbetű alapján
char kezdoBetu = 'k';
List<string> kezdodoKBetuvelSzavak = szavak.Where(szo => szo.StartsWith(kezdoBetu.ToString())).ToList();

// Lista elemeinek csoportosítása hossz alapján
var csoportositottSzavak = szavak.GroupBy(szo => szo.Length);

// Számok összege a csoportosítás alapján
var osszesitettSzamok = szamok.GroupBy(szam => szam % 2 == 0 ? "Páros" : "Páratlan").Select(group => new { Csoport = group.Key, Osszeg = group.Sum() });

// Szavak törlése adott feltétel alapján
szavak.RemoveAll(szo => szo.Length < 5);

// Számok átlaga csak a pozitív értékek között
double pozitivAtlag = szamok.Where(szam => szam > 0).Average();


// Számok szűrése feltétel alapján
int alsoHatar = 0;
int felsoHatar = 20;
List<int> szurtSzamok = szamok.Where(szam => szam > alsoHatar && szam < felsoHatar).ToList();

// Szavak mappelése új értékekkel 
List<string> ujSzavak = szavak.Select(szo => $"[{szo}]").ToList(); 
// A "mappelés" lehetővé teszi, hogy a meglévő kollekció elemein végezz változtatásokat vagy átalakításokat, és az eredményt egy új kollekció formájában kapd vissza. Egyik példa a "Select" művelet.

// Számok összege csak a negatív értékekből
int negativOsszeg = szamok.Where(szam => szam < 0).Sum();

// Szavak rendezése hossz alapján csökkenő sorrendben
List<string> csokkenoSorrend = szavak.OrderByDescending(szo => szo.Length).ToList();

// Számok lista rendezése
    // a)
    List<int> rendezettLista = szamok.OrderBy(szam => szam).ToList();
    // b)
    egyediSzam.Sort();

// Számok megszámlálása adott feltétel alapján
int negativSzamokSzama = szamok.Count(szam => szam < 0);

// Szavak elemek cseréje
szavak[szavak.IndexOf("nagy")] = "kicsi";

// Lista elemek véletlenszerű keverése
szamok.Shuffle();


