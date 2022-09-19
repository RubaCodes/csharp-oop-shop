Prodotto primoProdotto = new Prodotto(11111111);

primoProdotto.SetNome("smartphone");
primoProdotto.SetDescrizione("L'ultimo incredile smartphone");
primoProdotto.SetPrezzo(399);
primoProdotto.SetIva(20);

Console.WriteLine("---- Il tuo Prodotto----");
Console.WriteLine(primoProdotto.GetCodice());
Console.WriteLine(primoProdotto.GetNome());
Console.WriteLine(primoProdotto.GetDescrizione());
Console.WriteLine(primoProdotto.GetPrezzo());
Console.WriteLine(primoProdotto.getPrezzoConIva());
Console.WriteLine("---- Il Nome Prodotto esteso----");
Console.WriteLine(primoProdotto.GetNomeEsteso());
//codice corretto con gli zeri
Console.WriteLine("---- Codice corrento con pad left di n zeri----");
Console.WriteLine(primoProdotto.CodiceConZero());


public class Prodotto {
    //attributi
    private int codice;
    private string nome;
    private string descrizione;
    private decimal prezzo;
    private int iva;

    //costruttori
    //random codice prodotto
    public Prodotto() {
        Random r = new Random();
        this.codice = r.Next(9999999);
    }
    public Prodotto(int codice) {

        this.codice = codice;
    }
    //Getters
    //codice solo read
    public int GetCodice() {
        return this.codice;
    }
    public string GetNome() {
        return this.nome;
    }
    public string GetDescrizione() {
        return this.descrizione;
    }
    public decimal GetPrezzo() {
        return this.prezzo;
    }
    public int getIva() {
        return this.iva;
    }

    //Setters
    public void SetNome(string nome) {
        this.nome = nome;
    }
    public void SetDescrizione(string descrizione) {
        this.descrizione = descrizione;
    }
    public void SetPrezzo(decimal prezzo) {
        this.prezzo = prezzo;
    }
    public void SetIva(int iva) {
        this.iva = iva;
    }

    //metodi
    public decimal getPrezzoConIva() {
        return GetPrezzo() * (decimal) (getIva()+100)/100;
    }
    public string GetNomeEsteso() {
        return GetCodice() + GetNome();
    }

    public string CodiceConZero() {
        string codiceString = Convert.ToString(GetCodice());
        int diff = 8 - codiceString.Length;
        for (int i = 0; i < diff; i++) {
                codiceString = "0" + codiceString;
        }
        return codiceString;
    }
}