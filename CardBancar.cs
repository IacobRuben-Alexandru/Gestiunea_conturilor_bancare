public class CardBancar
{
    public string NumarCard { get; set; }
    public string Titular { get; set; }
    public string DataExpirare { get; set; }
    public string CVV { get; set; }

    public CardBancar(string numarCard, string titular, string dataExpirare, string cvv)
    {
        NumarCard = numarCard;
        Titular = titular;
        DataExpirare = dataExpirare;
        CVV = cvv;
    }
}