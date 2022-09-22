
public class BottigliaAcqua : Prodotto {
    //costante conversione litri galloni
    private const double gallon = 3.785;
    public float litriMax { get; }
    public float Litri { get; set; }
    public float Ph { get; set; }
    public string Sorgente { get;}

    public BottigliaAcqua(float litri, string sorgente)
    {
        if (litri > 1.5)
        {
            //throw errore
        }
        else { 
        litriMax = litri;
        Litri = litri;
        Sorgente = sorgente;
        }
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
        Console.WriteLine('\n'+"---- Informazioni Bottiglia Acqua ----");
        Console.WriteLine("---- Codice Completo ----");
        Console.WriteLine($"{Codice} - {Nome}");
        Console.WriteLine($"Sorgente: {Sorgente} -  PH : {Ph} -  Litri contenuti : {Litri}"+'\n');

    }
}
