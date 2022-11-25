// See https://aka.ms/new-console-template for more information

using Geometria;

Rettangolo rettangoloPC = new Rettangolo();
rettangoloPC.nomeRettangolo = "Mio Rettangolo";
rettangoloPC.altezzaRettangolo = 20;
rettangoloPC.baseRettangolo = 10;

Console.WriteLine("Creiamo assieme un rettangolo:");
Console.WriteLine("Inserisci la base del tuo rettangolo: ");
int baseRettangolo=int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci l'altezza del tuo rettangolo: ");
int altezzaRettangolo = int.Parse(Console.ReadLine());
Console.WriteLine("Sto creando il tuo rettangolo: ");
Rettangolo rettangoloUtente = new Rettangolo();
Console.WriteLine("Rettangolo inizializzato, procedo settando i tuoi valori: ");
rettangoloUtente.nomeRettangolo = "Tuo Rettangolo";
rettangoloUtente.baseRettangolo=baseRettangolo;
rettangoloUtente.altezzaRettangolo=altezzaRettangolo;
Console.WriteLine("Rettangolo completato: ");
rettangoloUtente.StampaRettangolo();
rettangoloUtente.DisegnaRettangolo();

Console.WriteLine("Questo invece è il mio: ");
rettangoloPC.StampaRettangolo();
rettangoloPC.DisegnaRettangolo();








