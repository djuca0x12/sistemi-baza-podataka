namespace ProdavnicaLibrary.DTOs;

public class RadiUIdView
{
    public RadnikView? RadnikRadiU { get; set; }
    public ProdavnicaView? RadiUProdavnica { get; set; }

    public RadiUIdView()
    {
    }

    internal RadiUIdView(RadiUId? r)
    {
        if (r != null)
        {
            RadnikRadiU = new RadnikView(r.RadnikRadiU);
            RadiUProdavnica = new ProdavnicaView(r.RadiUProdavnica);
        }
    }
}
