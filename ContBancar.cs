using System;

public class ContBancar
{
    public string NumarCont; 
    public string Proprietar;         
    public double Sold;
    public string Banca;

    public ContBancar(string numarCont, string proprietar, double sold, string banca)
    {
        NumarCont = numarCont;
        Proprietar = proprietar;
        Sold = sold;
        Banca = banca;
    }
    public void Cont()
    {
        Console.WriteLine($"Cont la banca: {Banca}, NumarCont: {NumarCont}, Proprietar: {Proprietar}, Sold: {Sold}");
    }
    public void Depune(double suma)
    {
        Sold += suma;
    }

    public bool Extrage(double suma)
    {
        if (suma > Sold)
        {
            return false;
        }
        Sold -= suma;
        return true;
    }
}
