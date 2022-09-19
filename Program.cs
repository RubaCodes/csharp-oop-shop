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
        this.codice = r.Next();
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
}