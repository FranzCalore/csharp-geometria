// See https://aka.ms/new-console-template for more information

using Geometria;

Rettangolo rettangolo1= new Rettangolo();
rettangolo1.baseRettangolo = 20;
rettangolo1.altezzaRettangolo = 10;

Console.WriteLine(rettangolo1.calcolaArea());
Console.WriteLine(rettangolo1.calcolaPerimetro());


StampaRettangolo(rettangolo1);











// ---------- FUNCTIONS -----------


void StampaRettangolo(Rettangolo rettangologenerico)
{
    Console.WriteLine("----------" + rettangologenerico + "----------");
}