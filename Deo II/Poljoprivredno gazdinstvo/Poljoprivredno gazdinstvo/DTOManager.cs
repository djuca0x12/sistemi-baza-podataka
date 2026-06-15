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
        #region Mehanizacije
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

        public static TraktorBasic VratiTraktorPoId(int id)
        {
            TraktorBasic traktorDTO = null;

            try
            {
                using (var session = DataLayer.GetSession())
                {
                    Traktor t = session.Get<Traktor>(id);

                    if (t != null)
                    {
                        // Mapiramo entitet u TraktorBasic DTO objekat
                        traktorDTO = new TraktorBasic(
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
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom učitavanja traktora: {ex.FormatExceptionMessage}");
            }

            return traktorDTO;
        }

        public static void IzmeniTraktor(TraktorBasic traktorDTO)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    Traktor t = session.Load<Traktor>(traktorDTO.IdMehanizacija);

                    // Azuriramo podatke
                    t.BrojSasije = traktorDTO.BrojSasije;
                    t.Status = traktorDTO.Status;
                    t.Komentar = traktorDTO.Komentar;
                    t.Model = traktorDTO.Model;
                    t.DatumKupovine = traktorDTO.DatumKupovine;
                    t.GodinaProizvodnje = traktorDTO.GodinaProizvodnje;
                    t.Snaga = traktorDTO.Snaga;
                    t.RadniSati = traktorDTO.RadniSati;
                    t.BrojMotora = traktorDTO.BrojMotora;

                    // Cuvamo izmene
                    session.Update(t);
                    session.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom izmene traktora: {ex.FormatExceptionMessage}");
            }
        }

        public static void ObrisiTraktor(int id)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    Traktor t = session.Load<Traktor>(id);

                    if (t != null)
                    {
                        session.Delete(t);
                        session.Flush();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom brisanja traktora: {ex.FormatExceptionMessage}");
            }
        }

        public static List<MasinaBasic> VratiSvePrskalice()
        {
            List<MasinaBasic> masine = new List<MasinaBasic>();

            try
            {
                using (var session = DataLayer.GetSession())
                {                   
                    var sveMasine = session.Query<Masina>().ToList();
               
                    foreach (var p in sveMasine)
                    {
                        masine.Add(new MasinaBasic(
                            p.IdMehanizacija,
                            p.BrojSasije,
                            p.Status,
                            p.Komentar,
                            p.Model,
                            p.DatumKupovine,
                            p.GodinaProizvodnje,
                            p.BrojTockova
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom učitavanja masine: {ex.FormatExceptionMessage}");
            }

            return masine;
        }

        public static void DodajMasinu(MasinaBasic masina)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    MasinaBasic novaMasina = new MasinaBasic
                    {
                        BrojSasije = masina.BrojSasije,
                        Status = masina.Status,
                        Komentar = masina.Komentar,
                        Model = masina.Model,
                        DatumKupovine = masina.DatumKupovine,
                        GodinaProizvodnje = masina.GodinaProizvodnje,
                        BrojTockova = masina.BrojTockova
                    };

                    session.Save(novaMasina);
                    session.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom dodavanja masine: {ex.FormatExceptionMessage}");
            }
        }

        public static bool ProveriDaLiBrojSasijePostojiZaMasinu(string brojSasije, int trenutniId = 0)
        {
            using (var session = DataLayer.GetSession())
            {
                var postojeci = session.Query<Masina>()
                    .Where(p => p.BrojSasije == brojSasije)
                    .FirstOrDefault();

                if (postojeci == null) return false;

                if (trenutniId != 0 && postojeci.IdMehanizacija == trenutniId) return false;

                return true;
            }
        }

        public static MasinaBasic VratiMasinuPoId(int id)
        {
            MasinaBasic MasinaDTO = null;

            try
            {
                using (var session = DataLayer.GetSession())
                {
                    Masina m = session.Get<Masina>(id);

                    if (m != null)
                    {
                        MasinaDTO = new MasinaBasic(
                            m.IdMehanizacija,
                            m.BrojSasije,
                            m.Status,
                            m.Komentar,
                            m.Model,
                            m.DatumKupovine,
                            m.GodinaProizvodnje,
                            m.BrojTockova
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom učitavanja masine: {ex.Message}");
            }
            return MasinaDTO;
        }

        public static void IzmeniMasinu(MasinaBasic masinaDTO)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    Masina p = session.Load<Masina>(masinaDTO.IdMehanizacija);

                    p.BrojSasije = masinaDTO.BrojSasije;
                    p.Status = masinaDTO.Status;
                    p.Komentar = masinaDTO.Komentar;
                    p.Model = masinaDTO.Model;
                    p.DatumKupovine = masinaDTO.DatumKupovine;
                    p.GodinaProizvodnje = masinaDTO.GodinaProizvodnje;
                    p.BrojTockova = masinaDTO.BrojTockova;

                    session.Update(p);
                    session.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom izmene masine: {ex.Message}");
            }
        }

        public static void ObrisiMasinu(int id)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    Masina m = session.Load<Masina>(id);

                    if (m != null)
                    {
                        session.Delete(m);
                        session.Flush();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom brisanja masine: {ex.Message}");
            }
        }

        #endregion

        #region Prinos

        public static void DodajPrinos(PrinosBasic prinosDTO)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    Prinos noviPrinos = new Prinos
                    {
                        Tip = prinosDTO.Tip,
                        Kolicina = (double)prinosDTO.Kolicina,
                        Komentar = prinosDTO.Komentar,
                        KvalitetProizvoda = prinosDTO.KvalitetProizvoda,
                        JedinicaMere = prinosDTO.JedinicaMere
                    };

                    session.Save(noviPrinos);
                    session.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom dodavanja prinosa: {ex.Message}");
            }
        }

        public static bool ProveriDaLiTipPostoji(string tip, int trenutniId = 0)
        {
            using (var session = DataLayer.GetSession())
            {
                var postojeci = session.Query<Prinos>()
                                .Where(p => p.Tip == tip)
                                .FirstOrDefault();

                if (postojeci == null) return false;

                if (trenutniId != 0 && postojeci.IdPrinosa == trenutniId) return false;

                return true;
            }
        }

        public static List<PrinosBasic> VratiSvePrinose()
        {
            List<PrinosBasic> prinosiDTO = new List<PrinosBasic>();

            try
            {
                using (var session = DataLayer.GetSession())
                {
                    var sviPrinosi = session.Query<Prinos>().ToList();

                    foreach (var p in sviPrinosi)
                    {
                        prinosiDTO.Add(new PrinosBasic(
                            p.IdPrinosa,
                            p.Tip,
                            (decimal)p.Kolicina,
                            p.Komentar,
                            p.KvalitetProizvoda,
                            p.JedinicaMere
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom učitavanja prinosa: {ex.Message}");
            }

            return prinosiDTO;
        }

        public static PrinosBasic VratiPrinosPoId(int id)
        {
            PrinosBasic prinosDTO = null;

            try
            {
                using (var session = DataLayer.GetSession())
                {
                    Prinos p = session.Get<Prinos>(id);

                    if (p != null)
                    {
                        prinosDTO = new PrinosBasic(
                            p.IdPrinosa,
                            p.Tip,
                            (decimal)p.Kolicina,
                            p.Komentar,
                            p.KvalitetProizvoda,
                            p.JedinicaMere
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom učitavanja prinosa: {ex.Message}");
            }
            return prinosDTO;
        }

        public static void IzmeniPrinos(PrinosBasic prinosDTO)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    Prinos p = session.Load<Prinos>(prinosDTO.IdPrinosa);

                    p.Tip = prinosDTO.Tip;
                    p.Kolicina = (double)prinosDTO.Kolicina;
                    p.Komentar = prinosDTO.Komentar;
                    p.KvalitetProizvoda = prinosDTO.KvalitetProizvoda;
                    p.JedinicaMere = prinosDTO.JedinicaMere;

                    session.Update(p);
                    session.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom izmene prinosa: {ex.Message}");
            }
        }

        public static void ObrisiPrinos(int id)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    Prinos p = session.Load<Prinos>(id);
                    if (p != null)
                    {
                        session.Delete(p);
                        session.Flush();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom brisanja prinosa: {ex.Message}");
            }
        }

        #endregion

        #region Prodaja

        public static bool ProveriDaLiBrojFakturePostoji(string brojFakture, int trenutniId = 0)
        {
            using (var session = DataLayer.GetSession())
            {
                var postojeci = session.Query<Prodaja>()
                    .Where(p => p.BrojFakture == brojFakture)
                    .FirstOrDefault();

                if (postojeci == null) return false;

                if (trenutniId != 0 && postojeci.IdProdaja == trenutniId) return false;

                return true;
            }
        }

        public static List<ProdajaBasic> VratiSveProdaje()
        {
            List<ProdajaBasic> prodajeDTO = new List<ProdajaBasic>();

            try
            {
                using (var session = DataLayer.GetSession())
                {
                    var sveProdaje = session.Query<Prodaja>().ToList();

                    foreach (var p in sveProdaje)
                    {
                        var kupacObj = session.Query<Kupac>()
                                .FirstOrDefault(k => k.Prodaja.IdProdaja == p.IdProdaja);

                        string nazivKupca = kupacObj != null ? kupacObj.KupacIme : "Nepoznat";

                        prodajeDTO.Add(new ProdajaBasic(
                            p.IdProdaja,
                            p.BrojFakture,
                            p.Prinos.IdPrinosa,                            
                            p.TipPlacanja,
                            p.Komentar,
                            (decimal) p.CenaPoJedinici,
                            p.JedinicaMere,
                            p.Datum,
                            (decimal)p.Kolicina,
                            nazivKupca
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom učitavanja prodaja: {ex.Message}");
            }
            return prodajeDTO;
        }

        public static ProdajaBasic VratiProdajuPoId(int id)
        {
            ProdajaBasic prodajaDTO = null;
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    Prodaja p = session.Get<Prodaja>(id);
                    if (p != null)
                    {
                        var kupacObj = session.Query<Kupac>()
                                .FirstOrDefault(k => k.Prodaja.IdProdaja == p.IdProdaja);

                        string nazivKupca = kupacObj != null ? kupacObj.KupacIme : "Nepoznat";

                        prodajaDTO = new ProdajaBasic(
                            p.IdProdaja,
                            p.BrojFakture,
                            p.Prinos.IdPrinosa,
                            p.TipPlacanja,
                            p.Komentar,
                            (decimal)p.CenaPoJedinici,
                            p.JedinicaMere,
                            p.Datum,
                            (decimal)p.Kolicina,
                            nazivKupca
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom učitavanja prodaje: {ex.Message}");
            }
            return prodajaDTO;
        }

        public static void IzmeniProdaju(ProdajaBasic prodajaDTO)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    Prodaja p = session.Load<Prodaja>(prodajaDTO.IdProdaja);

                    p.BrojFakture = prodajaDTO.BrojFakture;                
                    p.TipPlacanja = prodajaDTO.TipPlacanja;
                    p.Komentar = prodajaDTO.Komentar;
                    p.CenaPoJedinici = (double)prodajaDTO.CenaPoJedinici;
                    p.JedinicaMere = prodajaDTO.JedinicaMere;
                    p.Datum = prodajaDTO.Datum;
                    p.Kolicina = (double)prodajaDTO.Kolicina;

                    session.Update(p);
                    session.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom izmene prodaje: {ex.Message}");
            }
        }

        public static void ObrisiProdaju(int id)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    Prodaja p = session.Load<Prodaja>(id);
                    if (p != null)
                    {
                        session.Delete(p);
                        session.Flush();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom brisanja prodaje: {ex.Message}");
            }
        }

        #endregion

        #region Kupac

        public static void ObrisiKupca(int kupacId)
        {
            using (var session = DataLayer.GetSession())
            {
                Kupac k = session.Load<Kupac>(kupacId);
                session.Delete(k);
                session.Flush();
            }
        }

        /*public static void DodajKupceIzSkripte()
        {
            using (var session = DataLayer.GetSession())
            {
                Prodaja prodaja1 = session.Load<Prodaja>(1);
                Prinos prinos1 = session.Load<Prinos>(1);

                Kupac kupac1 = new Kupac
                {
                    KupacIme = "Milan Banatski",
                    Prodaja = prodaja1,
                    Prinos = prinos1
                };

                session.Save(kupac1);
                session.Flush();

                Prodaja prodaja2 = session.Load<Prodaja>(2);
                Prinos prinos2 = session.Load<Prinos>(2);

                Kupac kupac2 = new Kupac
                {
                    KupacIme = "Zadruga Srem",
                    Prodaja = prodaja2,
                    Prinos = prinos2
                };

                session.Save(kupac2);
                session.Flush();

                Prodaja prodaja3 = session.Load<Prodaja>(6);
                Prinos prinos3 = session.Load<Prinos>(3);

                Kupac kupac3 = new Kupac
                {
                    KupacIme = "Pijaca Topola",
                    Prodaja = prodaja3,
                    Prinos = prinos3
                };

                session.Save(kupac2);
                session.Flush();

                Prodaja prodaja4 = session.Load<Prodaja>(7);
                Prinos prinos4 = session.Load<Prinos>(4);

                Kupac kupac4 = new Kupac
                {
                    KupacIme = "Otkupljivac Arilje",
                    Prodaja = prodaja4,
                    Prinos = prinos4
                };

                session.Save(kupac4);
                session.Flush();
            }
        }*/

        public static void IzmeniKupca(KupacBasic kupacDTO)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {                 
                    Kupac k = session.Load<Kupac>(kupacDTO.IdKupac);
                 
                    k.KupacIme = kupacDTO.Kupac;
                    
                    session.Update(k);
                    session.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom izmene kupca: {ex.Message}");
            }
        }

        public static void IzmeniKupcaZaProdaju(int prodajaId, string novoIme)
        {
            using (var session = DataLayer.GetSession())
            {
                var kupac = session.Query<Kupac>().FirstOrDefault(k => k.Prodaja.IdProdaja == prodajaId);

                if (kupac != null)
                {
                    KupacBasic kDTO = new KupacBasic(kupac.IdKupac, novoIme);
                    IzmeniKupca(kDTO);
                }
            }
        }

        #endregion



    }
}
