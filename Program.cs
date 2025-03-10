using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Banca BancaMea = new Banca();

        while (true)
        {
            Console.WriteLine("1. Creare cont");
            Console.WriteLine("2. Accesare cont");
            Console.WriteLine("3. Afisare conturi");
            Console.WriteLine("4. Iesire");
            Console.Write("Alegeti o optiune: ");
            int optiune = int.Parse(Console.ReadLine());

            if (optiune == 1)
            {
                Console.Write("Introduceti numele proprietarului: ");
                string proprietar = Console.ReadLine();
                Console.Write("Introduceti numarul contului: ");
                string numarCont = Console.ReadLine();
                Console.Write("Introduceti soldul initial: ");
                double sold = double.Parse(Console.ReadLine());
                Console.Write("Introduceti banca: ");
                string banca = Console.ReadLine();
                Console.Write("Setati un PIN: ");
                string pin = Console.ReadLine();
                Console.Write("Este cont de firmă? (da/nu): ");
                bool esteFirma = Console.ReadLine().ToLower() == "da";

                ContBancar contNou;
                if (esteFirma)
                {
                    Console.Write("Introduceti denumirea firmei: ");
                    string denumireFirma = Console.ReadLine();
                    contNou = new ContFirma(numarCont, proprietar, sold, banca, denumireFirma, pin);
                }
                else
                {
                    contNou = new ContBancar(numarCont, proprietar, sold, banca, pin);
                }

                BancaMea.AdaugaCont(contNou);
                Console.WriteLine("Cont creat cu succes!");
            }
            else if (optiune == 2)
            {
                Console.Write("Introduceti numele proprietarului: ");
                string proprietar = Console.ReadLine();
                Console.Write("Introduceti numarul contului: ");
                string numarCont = Console.ReadLine();
                ContBancar foundAccount = BancaMea.GasireCont(numarCont, proprietar);

                if (foundAccount != null)
                {
                    Console.Write("Introduceti PIN-ul: ");
                    string pin = Console.ReadLine();

                    if (foundAccount.VerificaPin(pin))
                    {
                        Console.WriteLine($"Cont accesat: {foundAccount.Proprietar} - Sold: {foundAccount.Sold} RON");
                        Console.Write("Doriti sa depuneti (D) sau sa retrageti (R) bani? (D/R): ");
                        string actiune = Console.ReadLine().ToUpper();
                        Console.Write("Introduceti suma: ");
                        double suma = double.Parse(Console.ReadLine());

                        if (actiune == "D")
                        {
                            foundAccount.Depune(suma);
                            Console.WriteLine($"Sold actualizat: {foundAccount.Sold} RON");
                        }
                        else if (actiune == "R")
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
                        Console.WriteLine("PIN incorect!");
                    }
                }
                else
                {
                    Console.WriteLine("Contul nu a fost găsit.");
                }
            }
            else if (optiune == 3)
            {
                BancaMea.AfisareConturi();
            }
            else if (optiune == 4)
            {
                break;
            }
        }
    }
}