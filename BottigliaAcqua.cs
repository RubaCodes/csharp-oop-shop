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
public class BottigliaAcqua : Prodotto {
    //costante conversione litri galloni
    private const double gallon = 3.785;
    public float Litri { get; set; }
    public float Ph { get; set; }
    public string Sorgente { get;}

    public BottigliaAcqua(string sorgente) {
        Sorgente = sorgente;
    }
    //metodi
    public void Bevi(float litriDaBere) {

        //verifica se valido  min: 0;
        Litri -= litriDaBere;
    }
    public void Riempi(float litriDaBere)
    {

        //verifica se valido  max 1.5L;
        Litri += litriDaBere;
    }
    public void Svuota() {
        //verifica se valido ;
        Litri = 0 ;
    }
    //metodo statico per converione litri /galloni
    public static double convertiInGalloni(double litri) {
        return litri * gallon;
    }
    public override void StampaProdotto() {
        //stampa del prodotto
        Console.WriteLine("---- Informazioni Bottiglia Acqua ----");
        Console.WriteLine("---- Codice Completo ----");
        Console.WriteLine($"{Codice} - {Nome}");
        Console.WriteLine($"Sorgente: {Sorgente} -  PH : {Ph} -  Litri contenuti : {Litri}");

    }
}
