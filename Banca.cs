using System;
using System.Collections.Generic;

public class Banca
{
    private List<ContBancar> conturi = new List<ContBancar>(); 

    public void AdaugaCont(ContBancar account)
    {
        conturi.Add(account);
    }

    public ContBancar GasireCont(string numarCont)
    {
        foreach (ContBancar cont in conturi)
        {
            if (cont.NumarCont == numarCont)
            {
                return cont;
            }
        }
        return null; 
    }
}
