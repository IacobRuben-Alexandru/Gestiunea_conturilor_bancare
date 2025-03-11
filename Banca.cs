using System.Collections.Generic;
using System;

public class Banca
{
    private List<ContBancar> conturi = new List<ContBancar>();
    private List<CardBancar> carduri = new List<CardBancar>();

    public void AdaugaCont(ContBancar account)
    {
        conturi.Add(account);
    }

    public void AdaugaCard(CardBancar card)
    {
        carduri.Add(card);
    }

    public ContBancar GasireCont(string numarCont, string proprietar)
    {
        return conturi.Find(cont => cont.NumarCont == numarCont && cont.Proprietar == proprietar);
    }

    public CardBancar GasireCard(string numarCard)
    {
        return carduri.Find(card => card.NumarCard == numarCard);
    }

    public void AfisareConturi()
    {
        foreach (var cont in conturi)
        {
            Console.WriteLine($"{cont.Banca} - {cont.NumarCont} - {cont.Proprietar} - {cont.Sold} RON");
        }
    }

    public void AfisareCarduri()
    {
        foreach (var card in carduri)
        {
            Console.WriteLine($"{card.NumarCard} - {card.Titular} - Expira: {card.DataExpirare}");
        }
    }
}