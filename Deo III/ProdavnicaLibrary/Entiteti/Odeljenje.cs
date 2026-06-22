namespace ProdavnicaLibrary.Entiteti;

internal abstract class Odeljenje
{
    internal protected virtual int Id { get; set; }
    internal protected virtual string? Tip { get; set; }
    internal protected virtual string? Lokacija { get; set; }
    internal protected virtual int? BrojKasa { get; set; }
    internal protected virtual string? InfoPult { get; set; }

    internal protected virtual Prodavnica? PripadaProdavnici { get; set; }

    internal protected virtual IList<ProdajeSe>? ProdajeSeProizvod { get; set; }


    internal Odeljenje()
    {
        ProdajeSeProizvod = new List<ProdajeSe>();
    }
}

internal class OdeljenjeDo5 : Odeljenje
{
}

internal class OdeljenjeOd6Do16 : Odeljenje
{
}

internal class OdeljenjeOdrasli : Odeljenje
{
}
