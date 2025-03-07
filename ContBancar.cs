using System;

public class ContBancar
{
    //public string NumarCont; 
    //public string Proprietar;         
   // public double Sold;
    //public string Banca;

    public string NumarCont { get; set; }
    public string Proprietar { get; set; }
    public double Sold { get; private set; }
    public string Banca { get; set; }

    public ContBancar(string numarCont, string proprietar, double sold, string banca)
    {
        NumarCont = numarCont;
        Proprietar = proprietar;
        Sold = sold;
        Banca = banca;
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
