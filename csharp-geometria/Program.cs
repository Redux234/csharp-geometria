
using Class1;



Rettangolo rettangolo1 = new Rettangolo();
Rettangolo rettangoloutente = new Rettangolo();

rettangolo1.Base = 20;
rettangolo1.Area = 10;
rettangolo1.Perimetro = 2 * rettangolo1.Base + 2 * rettangolo1.Altezza;
rettangolo1.Area = rettangolo1.Base * rettangolo1.Area;

rettangolo1.StampaRettangolo();


Console.WriteLine("Inserire Base Rettangolo: ");
int baseutente = int.Parse(Console.ReadLine());

Console.WriteLine("Inserire Altezza Rettangolo: ");
int altezzautente = int.Parse(Console.ReadLine());  


rettangoloutente.Base = baseutente;
rettangoloutente.Altezza = altezzautente;
rettangoloutente.Perimetro = 2 * rettangoloutente.Base + 2 * rettangoloutente.Altezza;
rettangoloutente.Area = rettangoloutente.Base * rettangoloutente.Altezza;

rettangoloutente.StampaRettangolo();