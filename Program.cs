using System.Security.Cryptography.X509Certificates;
using GestioneGelateria;
using GestionePersone;
using GestionePersona2;
using GestioneOperazioni;
using GestioneProdotto;

class Program
{
    public static void Main(string[] args)
    {
        int sceltaEss;

        do
        {
            Console.WriteLine("Che esercizio vuoi vedere ?");
            Console.WriteLine("1: Gelateria");
            Console.WriteLine("2: Studente");
            Console.WriteLine("3: Operazioni");
            Console.WriteLine("0: Esci");

            if (!int.TryParse(Console.ReadLine(), out sceltaEss))
            {
                Console.WriteLine("Inserisci un numero valido!");
                continue;
            }

            switch (sceltaEss)
            {
                case 1:
                    Ess1();
                    break;

                case 2:
                    Ess2();
                    break;

                case 3:
                    Ess3();
                    break;

                case 4:
                    Ess4();
                    break;

                case 5:
                    Ess5();
                    break;

                case 6:
                    Ess6();
                    break;

                case 0:
                    Console.WriteLine("Termine programma...");
                    break;

                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        } while (sceltaEss != 0);
    }

    public static void Ess1()
    {
        Console.WriteLine("Benvenuto alla Gelateria Dolce Gelo!");
        Console.WriteLine("(Con una spesa superiore ai 1€ hai diritto a un 10% di sconto)");

        string[] gusti = { "Cioccolato", "Nocciola", "Caffè", "Pistacchio", "Zuppa Inglese" };
        double[] prezzi = { 0.11, 0.12, 0.15, 0.20, 0.18 };
        Gelateria.StampaMenu(gusti, prezzi);

        int[] gustiScelti = new int[20];
        int count = 0;
        int scelta;

        do
        {
            Console.Write("Inserisci il numero del gusto (0 per terminare): ");
            if (!int.TryParse(Console.ReadLine(), out scelta))
            {
                Console.WriteLine("Inserisci un numero valido!");
                continue;
            }

            if (scelta < 1 || scelta > gusti.Length)
            {
                Console.WriteLine("Scelta non valida, riprova.");
            }
            else
            {
                gustiScelti[count] = scelta - 1;
                count++;
                Console.WriteLine($"Gusto {gusti[scelta - 1]} aggiunto al cono!");
            }

        } while (scelta != 0);

        GestioneGelateria.Gelateria.StampaMenu(gusti, prezzi);
        double totale = GestioneGelateria.Gelateria.CalcolaTotale(gustiScelti, count, prezzi);


        if (totale > 1)
        {
            Console.WriteLine("Hai diritto a uno sconto del 10%!");
            totale *= 0.9;
        }

        Console.WriteLine("\n--- Riepilogo Ordine ---");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{gusti[gustiScelti[i]]} - {prezzi[gustiScelti[i]]}€");
        }

        Console.WriteLine($"Totale da pagare: {totale}€");
        Console.WriteLine("Grazie per aver scelto Dolce Gelo!");
    }

    public static void Ess2()
    {
        Persona p1 = new Persona("Mario", "Rossi", 1990);
        Persona p2 = new Persona("Luca", "Bianchi", 2000);


        Console.WriteLine($"{p1.Nome} {p1.Cognome} è nato nel {p1.AnnoNascita}");
        Console.WriteLine($"{p2.Nome} {p2.Cognome} è nato nel {p2.AnnoNascita}");
    }

    public static void Ess3()
    {
        Console.WriteLine("Inserisci due numeri da usare per le operazioni:");

        if (!int.TryParse(Console.ReadLine(), out int n1) ||
            !int.TryParse(Console.ReadLine(), out int n2))
        {
            Console.WriteLine("Input non valido!");
            return;
        }

        Operazioni op = new Operazioni();
        op.Somma(n1, n2);
        op.Moltiplica(n1, n2);
    }

    public static void Ess4()
    {
        Persona2 p = new Persona2 { Nome = "Luca", Eta = 25 };
        Console.WriteLine(p);
    }

    public static void Ess5() { }

    public static void Ess6()
    {
        Prodotto p1 = new Prodotto { Nome = "Penna", Prezzo = 1.50 };
        Prodotto p2 = new Prodotto { Nome = "penna", Prezzo = 1.50 };

        Console.WriteLine(p1.GetHashCode());
        Console.WriteLine(p2.GetHashCode());
    }
}
