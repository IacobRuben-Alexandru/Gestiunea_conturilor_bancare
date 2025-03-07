using System;

class Program
{
    static void Main()
    {
        Banca BancaMea = new Banca();

        // Citire date de la tastatură
        Console.Write("Introduceti numarul contului: ");
        string numarCont = Console.ReadLine();
        Console.Write("Introduceti numele proprietarului: ");
        string proprietar = Console.ReadLine();
        Console.Write("Introduceti soldul initial: ");
        double sold = double.Parse(Console.ReadLine());
        Console.Write("Introduceti banca: ");
        string banca = Console.ReadLine();
        Console.Write("Este cont de firmă? (da/nu): ");
        bool esteFirma = Console.ReadLine().ToLower() == "da";

        ContBancar contNou;
        if (esteFirma)
        {
            Console.Write("Introduceti denumirea firmei: ");
            string denumireFirma = Console.ReadLine();
            contNou = new ContFirma(numarCont, proprietar, sold, banca, denumireFirma);
        }
        else
        {
            contNou = new ContBancar(numarCont, proprietar, sold, banca);
        }

        BancaMea.AdaugaCont(contNou);

        // Afisare conturi
        Console.WriteLine("Lista conturilor:");
        BancaMea.AfisareConturi();

        // Căutare cont
        Console.Write("Introduceti numarul contului de cautat: ");
        string contCautat = Console.ReadLine();
        ContBancar foundAccount = BancaMea.GasireCont(contCautat);
        if (foundAccount != null)
        {
            Console.WriteLine($"Cont găsit: {foundAccount.Proprietar} - Sold: {foundAccount.Sold} RON");

            // Optiuni de depunere sau retragere
            Console.Write("Doriti sa depuneti (D) sau sa retrageti (R) bani? (D/R): ");
            string optiune = Console.ReadLine().ToUpper();
            Console.Write("Introduceti suma: ");
            double suma = double.Parse(Console.ReadLine());

            if (optiune == "D")
            {
                foundAccount.Depune(suma);
                Console.WriteLine($"Sold actualizat: {foundAccount.Sold} RON");
            }
            else if (optiune == "R")
            {
                if (foundAccount.Extrage(suma))
                {
                    Console.WriteLine($"Retragere reusita. Sold nou: {foundAccount.Sold} RON");
                }
                else
                {
                    Console.WriteLine("Fonduri insuficiente!");
                }
            }
        }
        else
        {
            Console.WriteLine("Contul nu a fost găsit.");
        }
    }
}
