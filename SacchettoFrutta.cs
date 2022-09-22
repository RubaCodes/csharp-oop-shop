#region vecchio esercizio
//Prodotto primoProdotto = new Prodotto();

//primoProdotto.SetNome("smartphone");
//primoProdotto.SetDescrizione("L'ultimo incredile smartphone");
//primoProdotto.SetPrezzo(399);
//primoProdotto.SetIva(20);

//Console.WriteLine("---- Il tuo Prodotto----");
//Console.WriteLine(primoProdotto.GetCodice());
//Console.WriteLine(primoProdotto.GetNome());
//Console.WriteLine(primoProdotto.GetDescrizione());
//Console.WriteLine(primoProdotto.GetPrezzo());
//Console.WriteLine(primoProdotto.getPrezzoConIva());
//Console.WriteLine("---- Il Nome Prodotto esteso----");
//Console.WriteLine(primoProdotto.GetNomeEsteso());
////codice corretto con gli zeri
//Console.WriteLine("---- Codice corretto con pad left di n zeri----");
//Console.WriteLine(primoProdotto.CodiceConZero());
#endregion




public class SacchettoFrutta : Prodotto
{
    public static int pezziRimanenti;
    public int DimensioneSacchettoMax { get; }
    public string TipoFrutta { get; }

    public SacchettoFrutta(  int dimensioneSacchettoMax, string tipoFrutta)
    {
        DimensioneSacchettoMax = dimensioneSacchettoMax;
        pezziRimanenti = dimensioneSacchettoMax;
        TipoFrutta = tipoFrutta;
    }

    public void MangiaPezzetto() {
        if (pezziRimanenti > 0) {
            pezziRimanenti--;
        }
    }
    public int PezziRimanenti() {
        return pezziRimanenti;
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
