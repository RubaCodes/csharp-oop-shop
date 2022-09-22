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


//test bottiglia
//metodo statico

public class SacchettoFrutta : Prodotto
{
    public override void StampaProdotto()
    {
        throw new NotImplementedException();
    }
}

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