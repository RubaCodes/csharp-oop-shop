﻿#region vecchio esercizio
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




//public class Elettrodomestico : Prodotto
//{
//    public override void StampaProdotto()
//    {
//        throw new NotImplementedException();
//    }
//}

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