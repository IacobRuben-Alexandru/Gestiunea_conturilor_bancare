using System;

class Program
{
    static void Main()
    {

        Banca BancaMea = new Banca();
        ContBancar ContulMeu = new ContBancar("123456", "Iacob Ruben", 1000,"BT");
        ContulMeu.Cont();
        BancaMea.AdaugaCont(ContulMeu);
        ContulMeu.Depune(500);
        Console.WriteLine($"Sold actualizat: {ContulMeu.Sold} RON");
        bool success = ContulMeu.Extrage(1200);
        if (success)
        {
            Console.WriteLine($"Retragere reusită. Sold nou: {ContulMeu.Sold} RON");
        }
        else
        {
            Console.WriteLine("Fonduri insuficiente!");
        }
        ContBancar foundAccount = BancaMea.GasireCont("123456");
        if (foundAccount != null)
        {
            Console.WriteLine($"Cont gasit: {foundAccount.Proprietar} - Sold: {foundAccount.Sold} RON");
        }
        else
        {
            Console.WriteLine("Contul nu a fost găsit.");
        }
    }
}
