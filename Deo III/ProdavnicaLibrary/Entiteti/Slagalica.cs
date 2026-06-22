namespace ProdavnicaLibrary.Entiteti;

internal class Slagalica : Proizvod
{
    internal protected virtual int BrojDelova { get; set; }
    internal protected virtual string? Turisticka { get; set; }
    internal protected virtual string? Umetnicka { get; set; }
    internal protected virtual string? Ilustracija { get; set; }
}
