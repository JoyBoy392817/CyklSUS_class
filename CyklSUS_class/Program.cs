for (int hodne = 1; hodne <= 100; hodne++)
{
    if (hodne == 40)
    {
        continue;
    }
    if (hodne == 60)
    {
        continue;
    }
    Console.WriteLine(hodne);
}//úkol číslo 1. vypíše od 1 až do 100 kromě 40 a 60

Console.WriteLine("________________________________________________________________________________");

for (int opak = 0; opak <= 9; opak++)
{
    if (opak == 0)
    {
        Console.WriteLine("***********");
    }
    else if (opak == 9)
    {
        Console.WriteLine("***********");
    }
    else
    {
        Console.WriteLine("*         *");
    }

}//úkol číslo 2. udělá obdelník z hvězdiček

Console.WriteLine("________________________________________________________________________________");

Console.WriteLine("Napiš čísla ve formátu (9, 6, 4, 6, 3, 1 atd..)");
string moc = Console.ReadLine();
string[] pole = moc.Split(",");
if (string.IsNullOrEmpty(pole[0]))
    Console.WriteLine("0");
else
    Console.WriteLine(pole.Length);
//úkol číslo 3. zeptá se uživatele na čísla a následovně vypíše kolik jich je pokud uživatel přeskočí krok(zmáčkně enter) program vypíše 0