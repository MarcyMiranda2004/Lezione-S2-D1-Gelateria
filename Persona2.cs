namespace GestionePersona2;

public class Persona2
{
    public string Nome { get; set; }
    public int Eta { get; set; }

    public override string ToString()
    {
        return $"Nome: {Nome}, Età: {Eta}";
    }
}