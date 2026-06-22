namespace ProdavnicaLibrary.Entiteti;

internal class RadiUId
{
    internal protected virtual Radnik? RadnikRadiU { get; set; }
    internal protected virtual Prodavnica? RadiUProdavnica { get; set; }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj?.GetType() != typeof(RadiUId))
        {
            return false;
        }

        RadiUId recievedObject = (RadiUId)obj;

        if ((RadnikRadiU?.Jbr == recievedObject?.RadnikRadiU?.Jbr) &&
            (RadiUProdavnica?.Id == recievedObject?.RadiUProdavnica?.Id))
        {
            return true;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return System.HashCode.Combine(base.GetHashCode());
    }
}
