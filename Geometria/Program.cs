// See https://aka.ms/new-console-template for more information

Console.WriteLine("Inserisci base");
int baseRettangolo = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci altezza");
int altezzaRettangolo = int.Parse(Console.ReadLine());
Console.WriteLine("------Ecco l'area del rettangolo -------:  " +baseRettangolo*altezzaRettangolo + "cm^2");
Console.WriteLine("------Ecco il perimetro del rettangolo-------:  " + (baseRettangolo + altezzaRettangolo)*2 + "cm");