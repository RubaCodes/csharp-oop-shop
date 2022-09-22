
public class SacchettoFrutta : Prodotto
{
    public int PezziRimanenti { get; set; }
    public int DimensioneSacchettoMax { get; }
    public string TipoFrutta { get; }

    public SacchettoFrutta(  int dimensioneSacchettoMax, string tipoFrutta)
    {
        DimensioneSacchettoMax = dimensioneSacchettoMax;
        PezziRimanenti = dimensioneSacchettoMax;
        TipoFrutta = tipoFrutta;
    }

    public void MangiaPezzetto() {
        if (PezziRimanenti > 0)
        {
            PezziRimanenti = PezziRimanenti - 1;
    }
}
    public override void StampaProdotto()
    {
        Console.WriteLine("---- Informazioni Sacchetto Frutta ----");
        Console.WriteLine("---- Codice Completo ----");
        Console.WriteLine($"{Codice} - {Nome}");
        Console.WriteLine("---- Tipo di Frutto e dimensione massima sacchetto ----");
        Console.WriteLine($"{TipoFrutta} - {DimensioneSacchettoMax}");
    }
}
