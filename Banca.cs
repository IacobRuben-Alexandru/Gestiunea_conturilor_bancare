using System.Collections.Generic;
using System;

public class Banca
{
    private List<ContBancar> conturi = new List<ContBancar>();

    public void AdaugaCont(ContBancar account)
    {
        conturi.Add(account);
    }

    public ContBancar GasireCont(string numarCont)
    {
        return conturi.Find(cont => cont.NumarCont == numarCont);
    }

    public void AfisareConturi()
    {
        foreach (var cont in conturi)
        {
            if (cont is ContFirma cf)
            {
                Console.WriteLine($"{cont.Banca} - {cont.NumarCont} - {cf.DenumireFirma} (Firma) - {cont.Sold} RON");
            }
            else
            {
                Console.WriteLine($"{cont.Banca} - {cont.NumarCont} - {cont.Proprietar} - {cont.Sold} RON");
            }
        }
    }
}