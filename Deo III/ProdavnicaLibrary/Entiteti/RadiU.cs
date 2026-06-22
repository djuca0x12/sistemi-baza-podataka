namespace ProdavnicaLibrary.Entiteti;

internal class RadiU
{
    internal protected virtual RadiUId? Id { get; set; }
    internal protected virtual DateTime? DatumOd { get; set; }
    internal protected virtual DateTime? DatumDo { get; set; }

    internal RadiU()
    {
        Id = new RadiUId();
    }
}
