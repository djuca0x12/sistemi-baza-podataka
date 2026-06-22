namespace ProdavnicaLibrary.Entiteti;

internal class Sefuje
{
    internal protected virtual int Id { get; set; }
    internal protected virtual DateTime? DatumPostavljenja { get; set; }

    internal protected virtual Sef? Upravnik { get; set; }
    internal protected virtual Prodavnica? Upravlja { get; set; }
}
