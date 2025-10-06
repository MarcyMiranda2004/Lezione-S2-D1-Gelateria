namespace GestioneOperazioni;

public class Operazioni
{
    public int Somma(int a, int b)
    {
        int somma = a + b;
        Risultato("Somma", somma);
        return somma;
    }

    public int Moltiplica(int a, int b)
    {
        int prodotto = a * b;
        Risultato("Moltiplicazione", prodotto);
        return prodotto;
    }

    public void Risultato(string operazione, int risultato)
    {
        Console.WriteLine($"Il risultato della {operazione} è: {risultato}");
    }
}