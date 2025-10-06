namespace GestionePersone
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int AnnoNascita { get; set; }

        public Persona() { }

        public Persona(string nome, string cognome, int annoNascita)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoNascita = annoNascita;
        }
    }
}
