
using Class1;



Rettangolo rettangolo1 = new Rettangolo();
Rettangolo rettangoloutente = new Rettangolo();

rettangolo1.Baserettangolo = 20;
rettangolo1.AreaRettangolo = 10;
rettangolo1.PerimetroRettangolo = 2 * rettangolo1.Baserettangolo + 2 * rettangolo1.AltezzaRettangolo;
rettangolo1.AreaRettangolo = rettangolo1.Baserettangolo * rettangolo1.AreaRettangolo;

rettangolo1.StampaRettangolo();

/*
Console.WriteLine("Inserire Base Rettangolo: ");
int baseutente = int.Parse(Console.ReadLine());

Console.WriteLine("Inserire Altezza Rettangolo: ");
int altezzautente = int.Parse(Console.ReadLine());  
*/

rettangoloutente.Baserettangolo = int.Parse(Console.ReadLine());
rettangoloutente.AltezzaRettangolo = int.Parse(Console.ReadLine());
rettangoloutente.PerimetroRettangolo = 2 * rettangoloutente.Baserettangolo + 2 * rettangoloutente.AltezzaRettangolo;
rettangoloutente.AreaRettangolo = rettangoloutente.Baserettangolo * rettangoloutente.AltezzaRettangolo;

rettangoloutente.StampaRettangolo();