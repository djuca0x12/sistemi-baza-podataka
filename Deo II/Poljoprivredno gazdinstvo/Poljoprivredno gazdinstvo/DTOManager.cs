using Poljoprivredno_gazdinstvo.Forme;
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
                MessageBox.Show($"Greška prilikom dodavanja traktora u bazu: {ex.FormatExceptionMessage()}");
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
                MessageBox.Show($"Greška prilikom učitavanja traktora: {ex.FormatExceptionMessage()}");
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
                MessageBox.Show($"Greška prilikom izmene traktora: {ex.FormatExceptionMessage()}");
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
                MessageBox.Show($"Greška prilikom brisanja traktora: {ex.FormatExceptionMessage()}");
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
                MessageBox.Show($"Greška prilikom učitavanja masine: {ex.FormatExceptionMessage()}");
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
                MessageBox.Show($"Greška prilikom dodavanja masine: {ex.FormatExceptionMessage()}");
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
                            (decimal)p.CenaPoJedinici,
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

        #region Zivotinje
        public static List<ZivotinjeBasic> VratiSveZivotinje()
        {
            List<ZivotinjeBasic> zivotinje = new();
            try
            {

                ISession s = DataLayer.GetSession();

                List<Zivotinje> sveZivotinje = s.Query<Zivotinje>().ToList();

                foreach (Zivotinje z in sveZivotinje)
                    zivotinje.Add(new ZivotinjeBasic(z.IdZivotinje, z.BrojUha, z.Vrsta, z.Pol, z.Rasa, z.BrojJedinki, z.DatumRodjenja, z.DatumUlaska, z.Tezina, z.Status, z.Komentar));

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri čitanju podataka o životinjama: {ec.FormatExceptionMessage()}");
            }
            return zivotinje;
        }
        public static void DodajZivotinju(ZivotinjeBasic z)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zivotinje zivotinja = new()
                {
                    // baza popunjava id preko sekvence
                    BrojUha = z.BrojUha,
                    Vrsta = z.Vrsta,
                    Pol = z.Pol,
                    Rasa = z.Rasa,
                    BrojJedinki = z.BrojJedinki,
                    DatumRodjenja = z.DatumRodjenja,
                    DatumUlaska = z.DatumUlaska,
                    Tezina = z.Tezina,
                    Status = z.Status,
                    Komentar = z.Komentar
                };

                // todo: dodati kategoriju

                s.SaveOrUpdate(zivotinja);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri dodavanju životinje: {ec.FormatExceptionMessage()}");
            }
        }

        public static ZivotinjeBasic VratiZivotinju(int id)
        {
            ZivotinjeBasic zb = new();
            try
            {
                ISession s = DataLayer.GetSession();

                Zivotinje z = s.Load<Zivotinje>(id);
                zb = new ZivotinjeBasic(z.IdZivotinje, z.BrojUha, z.Vrsta, z.Pol, z.Rasa, z.BrojJedinki, z.DatumRodjenja, z.DatumUlaska, z.Tezina, z.Status, z.Komentar);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri pribavljanju životinje: {ec.FormatExceptionMessage()}");
            }
            return zb;
        }

        public static void IzmeniZivotinju(ZivotinjeBasic z)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zivotinje zivotinja = s.Load<Zivotinje>(z.IdZivotinje);

                zivotinja.BrojUha = z.BrojUha;
                zivotinja.Vrsta = z.Vrsta;
                zivotinja.Pol = z.Pol;
                zivotinja.Rasa = z.Rasa;
                zivotinja.BrojJedinki = z.BrojJedinki;
                zivotinja.DatumRodjenja = z.DatumRodjenja;
                zivotinja.DatumUlaska = z.DatumUlaska;
                zivotinja.Tezina = z.Tezina;
                zivotinja.Status = z.Status;
                zivotinja.Komentar = z.Komentar;

                s.Update(zivotinja);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri izmeni životinje: {ec.FormatExceptionMessage()}");
            }
        }

        public static void ObrisiZivotinju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zivotinje z = s.Load<Zivotinje>(id);
                // todo: brisanje kategorije!
                s.Delete(z);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri brisanju životinje: {ec.FormatExceptionMessage()}");

            }
        }
        #endregion

        #region Usevi
        #endregion

        #region Zitarice
        public static List<ZitariceBasic> VratiSveZitarice()
        {
            List<ZitariceBasic> zitarice = new();
            try
            {

                ISession s = DataLayer.GetSession();

                List<Zitarice> sveZitarice = s.Query<Zitarice>().ToList();

                foreach (Zitarice z in sveZitarice)
                    zitarice.Add(new ZitariceBasic(z.Id, z.Naziv, z.Lokacija, z.Vrsta, z.Povrsina, z.KvalitetZemljista,
                        z.DatumSetve, z.DatumZetvePlanirani, z.DatumZetveStvarni, z.Status, z.Komentar,
                        z.GustinaSetve, z.KolicinaSemenaPoHektaru, z.PrinosPoHektaru, z.TipDjubrenja, z.Tip));

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri čitanju podataka o žitaricama: {ec.FormatExceptionMessage()}");
            }
            return zitarice;
        }
        public static ZitariceBasic VratiZitaricu(int id)
        {
            ZitariceBasic zb = new();
            try
            {
                ISession s = DataLayer.GetSession();

                Zitarice z = s.Load<Zitarice>(id);
                zb = new ZitariceBasic(z.Id, z.Naziv, z.Lokacija, z.Vrsta, z.Povrsina, z.KvalitetZemljista,
                    z.DatumSetve, z.DatumZetvePlanirani, z.DatumZetveStvarni, z.Status, z.Komentar,
                    z.GustinaSetve, z.KolicinaSemenaPoHektaru, z.PrinosPoHektaru, z.TipDjubrenja, z.Tip);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri pribavljanju žitarice: {ec.FormatExceptionMessage()}");
            }
            return zb;
        }

        public static void DodajZitaricu(ZitariceBasic z)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zitarice zitarica = new()
                {
                    // baza popunjava id preko sekvence
                    Naziv = z.Naziv,
                    Lokacija = z.Lokacija,
                    Vrsta = z.Vrsta,
                    Povrsina = z.Povrsina,
                    KvalitetZemljista = z.KvalitetZemljista,
                    DatumSetve = z.DatumSetve,
                    DatumZetvePlanirani = z.DatumZetvePlanirani,
                    DatumZetveStvarni = z.DatumZetveStvarni,
                    Status = z.Status,
                    Komentar = z.Komentar,
                    // properties izvedene klase
                    GustinaSetve = z.GustinaSetve,
                    KolicinaSemenaPoHektaru = z.KolicinaSemenaPoHektaru,
                    PrinosPoHektaru = z.PrinosPoHektaru,
                    Tip = z.Tip,
                    TipDjubrenja = z.TipDjubrenja
                };

                // todo: dodati kategoriju

                s.SaveOrUpdate(zitarica);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri dodavanju žitarice: {ec.FormatExceptionMessage()}");
            }
        }
        public static void IzmeniZitaricu(ZitariceBasic z)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zitarice zitarice = s.Get<Zitarice>(z.Id);

                zitarice.Naziv = z.Naziv;
                zitarice.Lokacija = z.Lokacija;
                zitarice.Povrsina = z.Povrsina;
                zitarice.KvalitetZemljista = z.KvalitetZemljista;
                zitarice.DatumSetve = z.DatumSetve;
                zitarice.DatumZetvePlanirani = z.DatumZetvePlanirani;
                zitarice.DatumZetveStvarni = z.DatumZetveStvarni;
                zitarice.Status = z.Status;
                zitarice.Komentar = z.Komentar;
                zitarice.GustinaSetve = z.GustinaSetve;
                zitarice.KolicinaSemenaPoHektaru = z.KolicinaSemenaPoHektaru;
                zitarice.PrinosPoHektaru = z.PrinosPoHektaru;
                zitarice.Tip = z.Tip;
                zitarice.TipDjubrenja = z.TipDjubrenja;

                s.SaveOrUpdate(zitarice);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri izmeni žitarice: {ec.FormatExceptionMessage()}");
            }
        }

        public static void ObrisiZitaricu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zitarice z = s.Load<Zitarice>(id);
                // todo: brisanje kategorije!
                s.Delete(z);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri brisanju žitarice: {ec.FormatExceptionMessage()}");
            }
        }

        #endregion

        #region Vocnjaci
        public static List<VocnjaciBasic> VratiSveVocnjake()
        {
            List<VocnjaciBasic> vocnjaci = new();
            try
            {
                ISession s = DataLayer.GetSession();

                List<Vocnjaci> sviVocnjaci = s.Query<Vocnjaci>().ToList();

                foreach (Vocnjaci v in sviVocnjaci)
                    vocnjaci.Add(new VocnjaciBasic(v.Id, v.Naziv, v.Lokacija, v.Vrsta, v.Povrsina, v.KvalitetZemljista,
                        v.DatumSetve, v.DatumZetvePlanirani, v.DatumZetveStvarni, v.Status, v.Komentar,
                        v.GodinaSadnje, v.BrojStabala, v.Sorta, v.DatumRezidbe, v.RodniCiklus));

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri čitanju podataka o voćnjacima: {ec.FormatExceptionMessage()}");
            }
            return vocnjaci;
        }
        public static VocnjaciBasic VratiVocnjak(int id)
        {
            VocnjaciBasic vb = new();
            try
            {
                ISession s = DataLayer.GetSession();

                Vocnjaci v = s.Load<Vocnjaci>(id);
                vb = new VocnjaciBasic(v.Id, v.Naziv, v.Lokacija, v.Vrsta, v.Povrsina, v.KvalitetZemljista,
                    v.DatumSetve, v.DatumZetvePlanirani, v.DatumZetveStvarni, v.Status, v.Komentar,
                    v.GodinaSadnje, v.BrojStabala, v.Sorta, v.DatumRezidbe, v.RodniCiklus);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri pribavljanju voćnjaka: {ec.FormatExceptionMessage()}");
            }
            return vb;
        }

        public static void DodajVocnjak(VocnjaciBasic v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vocnjaci vocnjak = new()
                {
                    // baza popunjava id preko sekvence
                    Naziv = v.Naziv,
                    Lokacija = v.Lokacija,
                    Vrsta = v.Vrsta,
                    Povrsina = v.Povrsina,
                    KvalitetZemljista = v.KvalitetZemljista,
                    DatumSetve = v.DatumSetve,
                    DatumZetvePlanirani = v.DatumZetvePlanirani,
                    DatumZetveStvarni = v.DatumZetveStvarni,
                    Status = v.Status,
                    Komentar = v.Komentar,
                    // properties izvedene klase
                    GodinaSadnje = v.GodinaSadnje,
                    BrojStabala = v.BrojStabala,
                    Sorta = v.Sorta,
                    DatumRezidbe = v.DatumRezidbe,
                    RodniCiklus = v.RodniCiklus
                };

                // todo: dodati kategoriju

                s.SaveOrUpdate(vocnjak);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri dodavanju voćnjaka: {ec.FormatExceptionMessage()}");
            }
        }
        public static void IzmeniVocnjak(VocnjaciBasic v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vocnjaci vocnjak = s.Get<Vocnjaci>(v.Id);

                vocnjak.Naziv = v.Naziv;
                vocnjak.Lokacija = v.Lokacija;
                vocnjak.Povrsina = v.Povrsina;
                vocnjak.KvalitetZemljista = v.KvalitetZemljista;
                vocnjak.DatumSetve = v.DatumSetve;
                vocnjak.DatumZetvePlanirani = v.DatumZetvePlanirani;
                vocnjak.DatumZetveStvarni = v.DatumZetveStvarni;
                vocnjak.Status = v.Status;
                vocnjak.Komentar = v.Komentar;
                vocnjak.GodinaSadnje = v.GodinaSadnje;
                vocnjak.BrojStabala = v.BrojStabala;
                vocnjak.Sorta = v.Sorta;
                vocnjak.DatumRezidbe = v.DatumRezidbe;
                vocnjak.DatumRezidbe = v.DatumRezidbe;
                vocnjak.RodniCiklus = v.RodniCiklus;

                s.SaveOrUpdate(vocnjak);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri izmeni voćnjaka: {ec.FormatExceptionMessage()}");
            }
        }

        public static void ObrisiVocnjak(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vocnjaci v = s.Load<Vocnjaci>(id);
                // todo: brisanje kategorije!
                s.Delete(v);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri brisanju voćnjaka: {ec.FormatExceptionMessage()}");
            }
        }

        #endregion

        #region Povrce
        #endregion

        #region KrmnoBilje
        #endregion
    }
}
