using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poljoprivredno_gazdinstvo
{
    public class DTOManager
    {

        public static List<TraktorBasic> UcitajTraktore()
        {
            List<TraktorBasic> traktori = new List<TraktorBasic>();

            try
            {
                using (var session = DataLayer.GetSession())
                {
                    traktori = session.Query<Traktor>()
                    .Select(t => new TraktorBasic(
                        t.IdMehanizacija,
                        t.BrojSasije,
                        t.Status,
                        t.Komentar,
                        t.Model,
                        t.DatumKupovine,
                        t.GodinaProizvodnje,
                        t.Snaga,
                        t.RadniSati,
                        t.BrojMotora

                    ))
                    .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri čitanju podataka: {ex.FormatExceptionMessage()}");
            }

            return traktori;
        }

        public static void DodajTraktor(TraktorBasic traktorDTO)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    Traktor noviTraktor = new Traktor
                    {
                        BrojSasije = traktorDTO.BrojSasije,
                        Status = traktorDTO.Status,
                        Komentar = traktorDTO.Komentar,
                        Model = traktorDTO.Model,
                        DatumKupovine = traktorDTO.DatumKupovine,
                        GodinaProizvodnje = traktorDTO.GodinaProizvodnje,
                        Snaga = traktorDTO.Snaga,
                        RadniSati = traktorDTO.RadniSati,
                        BrojMotora = traktorDTO.BrojMotora
                    };

                    session.Save(noviTraktor);

                    session.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom dodavanja traktora u bazu: {ex.FormatExceptionMessage}");
            }
        }


        public static bool ProveriDaLiBrojSasijePostoji(string brojSasije, int trenutniId = 0)
        {
            using (var session = DataLayer.GetSession())
            {
                var postojeci = session.Query<Mehanizacija>()
                    .Where(m => m.BrojSasije == brojSasije)
                    .FirstOrDefault();

                // Ne postoji
                if (postojeci == null)
                {
                    return false;
                }

                // Ako radimo izmenu dozvoljeno da zadzi svoj broj sasije!
                if (trenutniId != 0 && postojeci.IdMehanizacija == trenutniId)
                {
                    return false;
                }

                // Ako radimo unos, onda broj mora da bude jedinstven
                return true;
            }
        }
    }
}
