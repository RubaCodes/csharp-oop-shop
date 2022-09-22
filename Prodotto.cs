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
public class Prodotto {
	//attributi
	public int Codice { get; }
	public string Nome { get; set; }
	public string Descrizione { get; set; }
	public decimal Prezzo { get; set; }
	public int Iva { get; set; }

	//costruttori
	//random codice prodotto
	public Prodotto() {
		Codice = new Random().Next(9999999);
	}
	public Prodotto(int codice) {

		Codice = codice;
	}

	//metodi
	public decimal getPrezzoConIva() {
		return Prezzo * (decimal) (Iva+100)/100;
	}
	public string GetNomeEsteso() {
		return Codice + Nome;
	}

	public string CodiceConZero() {
		string codiceString = Convert.ToString(Codice);
		int diff = 8 - codiceString.Length;
		for (int i = 0; i < diff; i++) {
			 codiceString = "0" + codiceString;
		}
		return codiceString;
	}
}