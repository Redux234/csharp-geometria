
using Class1;



Rettangolo rettangolo1 = new Rettangolo();
Rettangolo rettangoloutente = new Rettangolo();

rettangolo1.Baserettangolo = 20;
rettangolo1.AreaRettangolo = 10;
rettangolo1.PerimetroRettangolo = 2 * rettangolo1.Baserettangolo + 2 * rettangolo1.AltezzaRettangolo;
rettangolo1.AreaRettangolo = rettangolo1.Baserettangolo * rettangolo1.AreaRettangolo;


Console.WriteLine("--Rettangolobase--");
Console.WriteLine("base: " + rettangolo1.Baserettangolo + " cm");
Console.WriteLine("altezza: " + rettangolo1.AltezzaRettangolo + " cm");
Console.WriteLine("perimetro:" + rettangolo1.PerimetroRettangolo + " cm");
Console.WriteLine("area: " + rettangolo1.AreaRettangolo + " cm2");

Console.WriteLine("Inserire Base Rettangolo: ");
int baseutente = int.Parse(Console.ReadLine());

Console.WriteLine("Inserire Altezza Rettangolo: ");
int altezzautente = int.Parse(Console.ReadLine());  

rettangoloutente.Baserettangolo = baseutente;
rettangoloutente.AreaRettangolo = altezzautente;
rettangoloutente.PerimetroRettangolo = 2 * rettangoloutente.Baserettangolo + 2 * rettangoloutente.AltezzaRettangolo;
rettangoloutente.AreaRettangolo = rettangoloutente.Baserettangolo * rettangoloutente.AltezzaRettangolo;


Console.WriteLine("--Rettangoutente--");
Console.WriteLine("base: " + rettangoloutente.Baserettangolo + " cm");
Console.WriteLine("altezza: " + rettangoloutente.AltezzaRettangolo + " cm");
Console.WriteLine("perimetro:" + rettangoloutente.PerimetroRettangolo + " cm");
Console.WriteLine("area: " + rettangoloutente.AreaRettangolo + " cm2");