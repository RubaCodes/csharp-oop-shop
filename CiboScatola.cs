public class CiboScatola : Prodotto
{
    public static int pesoCorrente;
    private const double Oz = 0.0353;

    public CiboScatola(string marca, int pesoScatolaMax)
    {
        Marca = marca;
        if (pesoScatolaMax > 300)
        {
            //throw errore
        }
        else
        {
            PesoScatolaMax = pesoScatolaMax;
            pesoCorrente = pesoScatolaMax;
        }
    }

    public string Marca { get; }
    public int PesoScatolaMax { get; }

    public void MangiaUnBoccone(int grammi) {
        if (pesoCorrente - grammi > 0)
        {
            pesoCorrente -= grammi;
        }
    }
    public int CiboRimanente() {
        return pesoCorrente;
    }
    //grammi to once
    public static double GramsToOz(int grams) {
        return grams * Oz;
    }
    public override void StampaProdotto()
    {
        Console.WriteLine("---- Informazioni Cibo in scatola ----");
        Console.WriteLine("---- Codice Completo ----");
        Console.WriteLine($"{Codice} - {Nome}");
        Console.WriteLine($"Marca: {Marca} -  Peso Netto: {PesoScatolaMax}");
    }
}