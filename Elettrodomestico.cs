public class Elettrodomestico : Prodotto
{
    public string Marca { get; }
    public string ClasseEnergetica { get; set; }

    public string Categoria { get; set; }
    public bool Status { get; set; } = false;

    // metodi di accensione/ spegnimento
    public void Accensione() {
        Status = true;
    }
    public void Spegnimento() {
        Status = false;
    }
    public override void StampaProdotto()
    {
        Console.WriteLine("---- Informazioni Elettrodomestico ----");
        Console.WriteLine("---- Codice Completo ----");
        Console.WriteLine($"{Codice} - {Nome}");
        Console.WriteLine($"Marca: {Marca} -  Classe energetica: {ClasseEnergetica}");
    }
}
