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


Console.WriteLine("Nuovo esercizio");
//test bottiglia
BottigliaAcqua nuovaBottiglia = new BottigliaAcqua("Carnia");
//metodo statico
double litriConvertiti = BottigliaAcqua.convertiInGalloni(2);

Console.WriteLine(litriConvertiti);
nuovaBottiglia.StampaProdotto();

//public class Elettrodomestico : Prodotto
//{
//    public override void StampaProdotto()
//    {
//        throw new NotImplementedException();
//    }
//}

//public class CiboScatola : Prodotto
//{
//    public override void StampaProdotto()
//    {
//        throw new NotImplementedException();
//    }
//}