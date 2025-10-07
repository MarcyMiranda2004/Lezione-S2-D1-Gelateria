namespace GestioneProdotto
{
    public class Prodotto
    {
        public string Nome;
        public double Prezzo;

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Prezzo);
        }
    }
}

