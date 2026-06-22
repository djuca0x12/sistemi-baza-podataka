namespace ProdavnicaLibrary.DTOs;

public class RadiUView
{
    public RadiUIdView? Id { get; set; }
    public DateTime? DatumOd { get; set; }
    public DateTime? DatumDo { get; set; }

    public RadiUView()
    {
    }

    internal RadiUView(RadiU? r)
    {
        if (r != null)
        {
            Id = new RadiUIdView(r.Id);
            DatumOd = r.DatumOd;
            DatumDo = r.DatumDo;
        }
    }
}
