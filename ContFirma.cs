using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ContFirma : ContBancar
{
    public string DenumireFirma { get; set; }

    public ContFirma(string numarCont, string proprietar, double sold, string banca, string denumireFirma, string pin)
        : base(numarCont, proprietar, sold, banca, pin)
    {
        DenumireFirma = denumireFirma;
    }
}