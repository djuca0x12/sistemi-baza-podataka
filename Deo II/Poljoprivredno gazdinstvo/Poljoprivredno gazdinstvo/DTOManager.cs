using Poljoprivredno_gazdinstvo.Forme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
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
                    Masina novaMasina = new Masina
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

        public static bool DodajProdaju(ProdajaBasic prodaja)
        {
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    // Transtakcija
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        // Prinos
                        Prinos prinos = session.Load<Prinos>(prodaja.IdPrinosa);

                        // Azuriramo kolicinu
                        prinos.Kolicina -= (double)prodaja.Kolicina;

                        // Prodaja
                        Prodaja novaProdaja = new Prodaja
                        {
                            BrojFakture = prodaja.BrojFakture,
                            Prinos = prinos,
                            TipPlacanja = prodaja.TipPlacanja,
                            Komentar = prodaja.Komentar,
                            CenaPoJedinici = (double)prodaja.CenaPoJedinici,
                            JedinicaMere = prodaja.JedinicaMere,
                            Datum = prodaja.Datum,
                            Kolicina = (double)prodaja.Kolicina,
                            Kupac = prodaja.Kupac
                        };

                        session.Save(novaProdaja);
                        session.Update(prinos);

                        transaction.Commit();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                // Ako bilo šta pođe po zlu, transakcija se neće potvrditi (Commit)
                Console.WriteLine(ex.Message);
                return false;
            }
        }

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
                            p.Kupac
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom učitavanja prodaja: {ex.FormatExceptionMessage()}");
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
                            p.Kupac
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
                    p.Kupac = prodajaDTO.Kupac;

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

        public static bool DaLiImaDovoljnoPrinosa(int idPrinosa, decimal kolicinaZaProdaju, string jedinicaSaForme)
        {
            using (var session = DataLayer.GetSession())
            {
                var prinos = session.Get<Prinos>(idPrinosa);

                if (prinos == null) return false;


                if (!prinos.JedinicaMere.Equals(jedinicaSaForme, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Greška: Jedinica mere na prinosu je '{prinos.JedinicaMere}', a na prodaji pokušavate da koristite '{jedinicaSaForme}'.");
                    return false;
                }

                return kolicinaZaProdaju <= (decimal)prinos.Kolicina;
            }
        }

        #endregion

        #region KoristiZa

        public static List<KoristiZaBasic> VratiPregledKoriscenja()
        {
            using (var session = DataLayer.GetSession())
            {
                // LINQ to NHibernate join
                var rezultat = from k in session.Query<KoristiZa>()
                               join m in session.Query<Mehanizacija>() on k.Mehanizacija.IdMehanizacija equals m.IdMehanizacija
                               join p in session.Query<Prinos>() on k.Prinos.IdPrinosa equals p.IdPrinosa
                               select new KoristiZaBasic
                               {
                                   TipPrinos = p.Tip,
                                   ModelMehanizacije = m.Model,
                                   BrojSasije = m.BrojSasije,
                                   DatumOd = k.DatumOd,
                                   DatumDo = k.DatumDo,
                                   IdMehanizacija = m.IdMehanizacija,
                                   IdPrinos = p.IdPrinosa
                               };

                return rezultat.ToList();
            }
        }

        public static void PoveziMehanizacijuIPrinos(int idMehanizacija, int idPrinos, DateTime datumOd)
        {
            using (var session = DataLayer.GetSession())
            {
                var meh = session.Load<Mehanizacija>(idMehanizacija);
                var pr = session.Load<Prinos>(idPrinos);

                KoristiZa novaVeza = new KoristiZa
                {
                    Mehanizacija = meh,
                    Prinos = pr,
                    DatumOd = datumOd
                };

                session.Save(novaVeza);
                session.Flush();
            }
        }

        public static string VratiTipMehanizacije(int idMehanizacija)
        {
            using (var session = DataLayer.GetSession())
            {
                // Ucitavamo traktor/masina
                var meh = session.Get<Mehanizacija>(idMehanizacija);

                if (meh is Traktor) return "Traktor";
                if (meh is Masina) return "Masina";

                return "Nepoznato";
            }
        }

        // KoristiZa poseduje kompozitni kljuc, koji nam sprecava izmenu?
        // Da li mozemo izmenu da napravimo kao delete + insert?
        /*public static void AzurirajKoriscenje(int stariIdMehanizacija, int idPrinos, DateTime datumOd, int noviIdMehanizacija, DateTime? noviDatumDo)
        {
            using (var session = DataLayer.GetSession())
            {
                var zapis = session.Query<KoristiZa>()
                    .FirstOrDefault(k => k.Mehanizacija.IdMehanizacija == stariIdMehanizacija
                                      && k.Prinos.IdPrinosa == idPrinos
                                      && k.DatumOd == datumOd);

                if (zapis != null)
                {
                    if (stariIdMehanizacija != noviIdMehanizacija)
                    {
                        zapis.Mehanizacija = session.Load<Mehanizacija>(noviIdMehanizacija);
                    }

                    zapis.DatumDo = noviDatumDo;                   

                    session.Update(zapis);
                    session.Flush();
                }
            }
        }*/

        public static void AzurirajKoriscenje(int stariIdMehanizacija, int idPrinos, DateTime datumOd, int noviIdMehanizacija, DateTime? noviDatumDo)
        {
            using (var session = DataLayer.GetSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        // Pronalazimo red
                        var stariZapis = session.Query<KoristiZa>()
                            .FirstOrDefault(k => k.Mehanizacija.IdMehanizacija == stariIdMehanizacija
                                              && k.Prinos.IdPrinosa == idPrinos
                                              && k.DatumOd == datumOd);

                        if (stariZapis != null)
                        {
                            // Brisemo ga iz baze
                            session.Delete(stariZapis);

                            // Forsiramo brisanje
                            session.Flush();
                        }

                        // Kreiramo novi red
                        KoristiZa noviZapis = new KoristiZa
                        {
                            Mehanizacija = session.Load<Mehanizacija>(noviIdMehanizacija),
                            Prinos = session.Load<Prinos>(idPrinos),
                            DatumOd = datumOd,
                            DatumDo = noviDatumDo
                        };

                        session.Save(noviZapis);
                      
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static void ObrisiKoriscenje(int idMehanizacija, int idPrinos, DateTime datumOd)
        {
            using (var session = DataLayer.GetSession())
            {
                var zapis = session.Query<KoristiZa>()
                    .FirstOrDefault(k => k.Mehanizacija.IdMehanizacija == idMehanizacija
                                      && k.Prinos.IdPrinosa == idPrinos
                                      && k.DatumOd == datumOd);

                if (zapis != null)
                {
                    session.Delete(zapis);
                    session.Flush();
                }
                else
                {
                    throw new Exception("Zapis o korišćenju nije pronađen.");
                }
            }
        }

        #endregion

        #region Subvencija

        public static List<SubvencijaBasic> VratiSveSubvencije()
        {
            using (var session = DataLayer.GetSession())
            {
                return session.Query<Subvencija>()
                    .Select(s => new SubvencijaBasic
                    {
                        IdSubvencija = s.IdSubvencija,
                        BrojResenja = s.BrojResenja,
                        Vrsta = s.Vrsta,
                        Iznos = (decimal)s.Iznos,
                        Valuta = s.Valuta,
                        DatumPodnosenja = s.DatumPodnosenja,
                        DatumOdobrenja = s.DatumOdobrenja,
                        Status = s.Status,
                        Komentar = s.Komentar,
                        UseviZivotinjeId = s.Kategorija.UseviZivotinjeId
                    }).ToList();
            }
        }

        public static void ObrisiSubvenciju(int id)
        {
            using (var session = DataLayer.GetSession())
            {
                var subvencija = session.Get<Subvencija>(id);
                if (subvencija != null)
                {
                    session.Delete(subvencija);
                    session.Flush();
                }
            }
        }

        public static bool DaLiBrojResenjaPostoji(string brojResenja, int? trenutniId = null)
        {
            using (var session = DataLayer.GetSession())
            {
                var postojeca = session.Query<Subvencija>()
                    .FirstOrDefault(s => s.BrojResenja == brojResenja);

                if (postojeca != null && (trenutniId == null || postojeca.IdSubvencija != trenutniId))
                {
                    return true;
                }

                return false;
            }
        }

        public static void AzurirajSubvenciju(SubvencijaBasic s)
        {
            using (var session = DataLayer.GetSession())
            {
                var subvencija = session.Get<Subvencija>(s.IdSubvencija);
                if (subvencija != null)
                {
                    subvencija.BrojResenja = s.BrojResenja;
                    subvencija.Vrsta = s.Vrsta;
                    subvencija.Iznos = (double)s.Iznos;
                    subvencija.Valuta = s.Valuta;
                    subvencija.DatumPodnosenja = s.DatumPodnosenja;
                    subvencija.DatumOdobrenja = s.DatumOdobrenja;
                    subvencija.Status = s.Status;
                    subvencija.Komentar = s.Komentar;

                    // Azuriranje kategorije
                    subvencija.Kategorija = session.Load<UseviZivotinje>(s.UseviZivotinjeId);

                    session.Update(subvencija);
                    session.Flush();
                }
            }
        }

        public static void DodajSubvenciju(SubvencijaBasic s)
        {
            using (var session = DataLayer.GetSession())
            {
                Subvencija nova = new Subvencija();
                nova.BrojResenja = s.BrojResenja;
                nova.Vrsta = s.Vrsta;
                nova.Iznos = (double)s.Iznos;
                nova.Valuta = s.Valuta;
                nova.DatumPodnosenja = s.DatumPodnosenja;
                nova.DatumOdobrenja = null;
                nova.Status = s.Status;
                nova.Komentar = s.Komentar;

                // Povezivanje sa kategorijom
                nova.Kategorija = session.Load<UseviZivotinje>(s.UseviZivotinjeId);

                session.Save(nova);
                session.Flush();
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
            using (ISession s = DataLayer.GetSession())
            {
                using (ITransaction transaction = s.BeginTransaction())
                {
                    try
                    {
                        UseviZivotinje uz = new()
                        {
                            // baza popunjava id preko sekvence
                            KategorijaTip = 'z'
                        };

                        s.Save(uz);

                        Zivotinje zivotinja = new()
                        {
                            BrojUha = z.BrojUha,
                            Vrsta = z.Vrsta,
                            Pol = z.Pol,
                            Rasa = z.Rasa,
                            BrojJedinki = z.BrojJedinki,
                            DatumRodjenja = z.DatumRodjenja,
                            DatumUlaska = z.DatumUlaska,
                            Tezina = z.Tezina,
                            Status = z.Status,
                            Komentar = z.Komentar,
                            Kategorija = uz
                        };

                        s.Save(zivotinja);

                        transaction.Commit();
                    }
                    catch (Exception ec)
                    {
                        if (transaction != null && transaction.IsActive)
                        {
                            transaction.Rollback();
                        }

                        MessageBox.Show($"Greška pri dodavanju životinje: {ec.FormatExceptionMessage()}");
                    }
                }
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
            using (ISession s = DataLayer.GetSession())
            {
                using (ITransaction transaction = s.BeginTransaction())
                {
                    try
                    {
                        Zivotinje z = s.Load<Zivotinje>(id);

                        if (z != null)
                        {
                            UseviZivotinje kategorija = z.Kategorija;

                            s.Delete(z);

                            if (kategorija != null)
                            {
                                s.Delete(kategorija);
                            }

                            transaction.Commit();
                        }
                    }
                    catch (Exception ec)
                    {
                        if (transaction != null && transaction.IsActive)
                        {
                            transaction.Rollback();
                        }

                        MessageBox.Show($"Greška pri brisanju životinje: {ec.FormatExceptionMessage()}");
                    }
                }
            }
        }

        public static bool DaLiPostojiZivotinjaSaBrojemUha(string brojUha, int trenutniId = 0)
        {
            using (var session = DataLayer.GetSession())
            {               
                string proveraBroja = brojUha.Trim().ToUpper();

                return session.Query<Zivotinje>()
                    .Any(z => z.BrojUha.Trim().ToUpper() == proveraBroja
                           && z.IdZivotinje != trenutniId);
            }
        }

        #endregion

        #region Zitarice

        public static bool DaLiPostojiUsevSaNazivomILokacijom(string naziv, string lokacija, int trenutniId = 0)
        {
            using (var session = DataLayer.GetSession())
            {
                string nazivTrimmed = naziv.Trim().ToLower();
                string lokacijaTrimmed = lokacija.Trim().ToLower();

                return session.Query<Usevi>() 
                    .Any(u => (u.Naziv.Trim().ToLower() == nazivTrimmed
                           || u.Lokacija.Trim().ToLower() == lokacijaTrimmed)
                           && u.Id != trenutniId);
            }
        }
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
            using (ISession s = DataLayer.GetSession())
            {
                using (ITransaction transaction = s.BeginTransaction())
                {
                    try
                    {
                        UseviZivotinje uz = new()
                        {
                            // baza popunjava id preko sekvence
                            KategorijaTip = 'u'
                        };

                        s.Save(uz);

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
                            TipDjubrenja = z.TipDjubrenja,
                            Kategorija = uz
                        };

                        s.SaveOrUpdate(zitarica);
                        transaction.Commit();
                    }
                    catch (Exception ec)
                    {
                        if (transaction != null && transaction.IsActive)
                        {
                            transaction.Rollback();
                        }
                        MessageBox.Show($"Greška pri dodavanju žitarice: {ec.FormatExceptionMessage()}");
                    }
                }
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
            using (ISession s = DataLayer.GetSession())
            {
                using (ITransaction transaction = s.BeginTransaction())
                {
                    try
                    {
                        Zitarice z = s.Load<Zitarice>(id);
                        if (z != null)
                        {
                            UseviZivotinje kategorija = z.Kategorija;

                            s.Delete(z);

                            if (kategorija != null)
                            {
                                s.Delete(kategorija);
                            }

                            transaction.Commit();
                        }
                    }
                    catch (Exception ec)
                    {
                        if (transaction != null && transaction.IsActive)
                        {
                            transaction.Rollback();
                        }
                        MessageBox.Show($"Greška pri brisanju žitarice: {ec.FormatExceptionMessage()}");
                    }
                }
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
            using (ISession s = DataLayer.GetSession())
            {
                using (ITransaction transaction = s.BeginTransaction())
                {
                    try
                    {
                        UseviZivotinje uz = new()
                        {
                            // baza popunjava id preko sekvence
                            KategorijaTip = 'u'
                        };

                        s.Save(uz);

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
                            RodniCiklus = v.RodniCiklus,
                            Kategorija = uz
                        };

                        s.SaveOrUpdate(vocnjak);
                        transaction.Commit();

                    }
                    catch (Exception ec)
                    {
                        if (transaction != null && transaction.IsActive)
                        {
                            transaction.Rollback();
                        }
                        MessageBox.Show($"Greška pri dodavanju voćnjaka: {ec.FormatExceptionMessage()}");
                    }
                }
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
            using (ISession s = DataLayer.GetSession())
            {
                using (ITransaction transaction = s.BeginTransaction())
                {
                    try
                    {
                        Vocnjaci v = s.Load<Vocnjaci>(id);
                        if (v != null)
                        {
                            UseviZivotinje kategorija = v.Kategorija;

                            s.Delete(v);

                            if (kategorija != null)
                            {
                                s.Delete(kategorija);
                            }
                            transaction.Commit();
                        }
                    }
                    catch (Exception ec)
                    {
                        MessageBox.Show($"Greška pri brisanju voćnjaka: {ec.FormatExceptionMessage()}");
                    }
                }
            }
        }

        #endregion

        #region Povrce
        public static List<PovrceBasic> VratiSvoPovrce()
        {
            List<PovrceBasic> povrce = new();
            try
            {

                ISession s = DataLayer.GetSession();

                List<Povrce> svoPovrce = s.Query<Povrce>().ToList();

                foreach (Povrce p in svoPovrce)
                    povrce.Add(new PovrceBasic(p.Id, p.Naziv, p.Lokacija, p.Vrsta, p.Povrsina, p.KvalitetZemljista,
                        p.DatumSetve, p.DatumZetvePlanirani, p.DatumZetveStvarni, p.Status, p.Komentar,
                        p.BrojSetviGodisnje, p.ZastitneMere, p.NacinGajenja, p.Tip));
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri čitanju podataka o povrću: {ec.FormatExceptionMessage()}");
            }
            return povrce;
        }
        public static PovrceBasic VratiPovrce(int id)
        {
            PovrceBasic pb = new();
            try
            {
                ISession s = DataLayer.GetSession();

                Povrce p = s.Load<Povrce>(id);
                pb = new PovrceBasic(p.Id, p.Naziv, p.Lokacija, p.Vrsta, p.Povrsina, p.KvalitetZemljista,
                     p.DatumSetve, p.DatumZetvePlanirani, p.DatumZetveStvarni, p.Status, p.Komentar,
                     p.BrojSetviGodisnje, p.ZastitneMere, p.NacinGajenja, p.Tip
                  );

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri pribavljanju povrća: {ec.FormatExceptionMessage()}");
            }
            return pb;
        }

        public static void DodajPovrce(PovrceBasic p)
        {
            using (ISession s = DataLayer.GetSession())
            {
                using (ITransaction transaction = s.BeginTransaction())
                {
                    try
                    {
                        UseviZivotinje uz = new()
                        {
                            // baza popunjava id preko sekvence
                            KategorijaTip = 'u'
                        };

                        s.Save(uz);
                        Povrce povrce = new()
                        {
                            // baza popunjava id preko sekvence
                            Naziv = p.Naziv,
                            Lokacija = p.Lokacija,
                            Vrsta = p.Vrsta,
                            Povrsina = p.Povrsina,
                            KvalitetZemljista = p.KvalitetZemljista,
                            DatumSetve = p.DatumSetve,
                            DatumZetvePlanirani = p.DatumZetvePlanirani,
                            DatumZetveStvarni = p.DatumZetveStvarni,
                            Status = p.Status,
                            Komentar = p.Komentar,
                            // properties izvedene klase
                            BrojSetviGodisnje = p.BrojSetviGodisnje,
                            ZastitneMere = p.ZastitneMere,
                            NacinGajenja = p.NacinGajenja,
                            Tip = p.Tip,
                            Kategorija = uz
                        };

                        s.SaveOrUpdate(povrce);
                        transaction.Commit();

                    }
                    catch (Exception ec)
                    {
                        if (transaction != null && transaction.IsActive)
                        {
                            transaction.Rollback();
                        }
                        MessageBox.Show($"Greška pri dodavanju povrća: {ec.FormatExceptionMessage()}");
                    }
                }
            }
        }
        public static void IzmeniPovrce(PovrceBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Povrce povrce = s.Get<Povrce>(p.Id);

                povrce.Naziv = p.Naziv;
                povrce.Lokacija = p.Lokacija;
                povrce.Povrsina = p.Povrsina;
                povrce.KvalitetZemljista = p.KvalitetZemljista;
                povrce.DatumSetve = p.DatumSetve;
                povrce.DatumZetvePlanirani = p.DatumZetvePlanirani;
                povrce.DatumZetveStvarni = p.DatumZetveStvarni;
                povrce.Status = p.Status;
                povrce.Komentar = p.Komentar;
                povrce.BrojSetviGodisnje = p.BrojSetviGodisnje;
                povrce.ZastitneMere = p.ZastitneMere;
                povrce.NacinGajenja = p.NacinGajenja;
                povrce.Tip = p.Tip;

                s.SaveOrUpdate(povrce);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri izmeni povrća: {ec.FormatExceptionMessage()}");
            }
        }

        public static void ObrisiPovrce(int id)
        {
            using (ISession s = DataLayer.GetSession())
            {
                using (ITransaction transaction = s.BeginTransaction())
                {
                    try
                    {
                        Povrce p = s.Load<Povrce>(id);
                        if (p != null)
                        {
                            UseviZivotinje kategorija = p.Kategorija;

                            s.Delete(p);

                            if (kategorija != null)
                            {
                                s.Delete(kategorija);
                            }

                            transaction.Commit();
                        }
                    }
                    catch (Exception ec)
                    {
                        MessageBox.Show($"Greška pri brisanju povrća: {ec.FormatExceptionMessage()}");
                    }
                }
            }
        }
        #endregion

        #region KrmnoBilje
        public static List<KrmnoBiljeBasic> VratiSvoKrmnoBilje()
        {
            List<KrmnoBiljeBasic> krma = new();
            try
            {
                ISession s = DataLayer.GetSession();

                List<KrmnoBilje> svaKrma = s.Query<KrmnoBilje>().ToList();

                foreach (KrmnoBilje k in svaKrma)
                    krma.Add(new KrmnoBiljeBasic(k.Id, k.Naziv, k.Lokacija, k.Vrsta, k.Povrsina, k.KvalitetZemljista,
                        k.DatumSetve, k.DatumZetvePlanirani, k.DatumZetveStvarni, k.Status, k.Komentar,
                        k.VrstaKrme, k.BrojKosnjiGodisnje, k.ProcenatProteina, k.IshranaStokeFlag, k.ZaProdajuFlag));

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri čitanju podataka o krmnom bilju: {ec.FormatExceptionMessage()}");
            }
            return krma;
        }
        public static KrmnoBiljeBasic VratiKrmnoBilje(int id)
        {
            KrmnoBiljeBasic kb = new();
            try
            {
                ISession s = DataLayer.GetSession();

                KrmnoBilje k = s.Load<KrmnoBilje>(id);
                kb = new KrmnoBiljeBasic(k.Id, k.Naziv, k.Lokacija, k.Vrsta, k.Povrsina, k.KvalitetZemljista,
                        k.DatumSetve, k.DatumZetvePlanirani, k.DatumZetveStvarni, k.Status, k.Komentar,
                        k.VrstaKrme, k.BrojKosnjiGodisnje, k.ProcenatProteina, k.IshranaStokeFlag, k.ZaProdajuFlag);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri pribavljanju krmnog bilja: {ec.FormatExceptionMessage()}");
            }
            return kb;
        }

        public static void DodajKrmnoBilje(KrmnoBiljeBasic k)
        {
            using (ISession s = DataLayer.GetSession())
            {
                using (ITransaction transaction = s.BeginTransaction())
                {
                    try
                    {
                        UseviZivotinje uz = new()
                        {
                            // baza popunjava id preko sekvence
                            KategorijaTip = 'u'
                        };

                        // Čuvamo nadređeni entitet
                        s.Save(uz);

                        KrmnoBilje krma = new()
                        {
                            // baza popunjava id preko sekvence
                            Naziv = k.Naziv,
                            Lokacija = k.Lokacija,
                            Vrsta = k.Vrsta,
                            Povrsina = k.Povrsina,
                            KvalitetZemljista = k.KvalitetZemljista,
                            DatumSetve = k.DatumSetve,
                            DatumZetvePlanirani = k.DatumZetvePlanirani,
                            DatumZetveStvarni = k.DatumZetveStvarni,
                            Status = k.Status,
                            Komentar = k.Komentar,
                            // properties izvedene klase
                            VrstaKrme = k.VrstaKrme,
                            BrojKosnjiGodisnje = k.BrojKosnjiGodisnje,
                            ProcenatProteina = k.ProcenatProteina,
                            ZaProdajuFlag = k.ZaProdajuFlag,
                            IshranaStokeFlag = k.IshranaStokeFlag,
                            Kategorija = uz
                        };


                        s.SaveOrUpdate(krma);
                        transaction.Commit();


                    }
                    catch (Exception ec)
                    {
                        if (transaction != null && transaction.IsActive)
                        {
                            transaction.Rollback();
                        }
                        MessageBox.Show($"Greška pri dodavanju krmnog bilja: {ec.FormatExceptionMessage()}");
                    }
                }
            }
        }

        public static void IzmeniKrmnoBilje(KrmnoBiljeBasic z)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KrmnoBilje krma = s.Get<KrmnoBilje>(z.Id);

                krma.Naziv = z.Naziv;
                krma.Lokacija = z.Lokacija;
                krma.Povrsina = z.Povrsina;
                krma.KvalitetZemljista = z.KvalitetZemljista;
                krma.DatumSetve = z.DatumSetve;
                krma.DatumZetvePlanirani = z.DatumZetvePlanirani;
                krma.DatumZetveStvarni = z.DatumZetveStvarni;
                krma.Status = z.Status;
                krma.Komentar = z.Komentar;
                krma.VrstaKrme = z.VrstaKrme;
                krma.BrojKosnjiGodisnje = z.BrojKosnjiGodisnje;
                krma.ProcenatProteina = z.ProcenatProteina;
                krma.IshranaStokeFlag = z.IshranaStokeFlag;
                krma.ZaProdajuFlag = z.ZaProdajuFlag;

                s.SaveOrUpdate(krma);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri izmeni krmnog bilja: {ec.FormatExceptionMessage()}");
            }
        }

        public static void ObrisiKrmnoBilje(int id)
        {
            using (ISession s = DataLayer.GetSession())
            {
                using (ITransaction transaction = s.BeginTransaction())
                {
                    try
                    {
                        KrmnoBilje k = s.Load<KrmnoBilje>(id);
                        if (k != null)
                        {
                            // Uzimamo referencu na kategoriju pre nego što obrišemo životinju
                            UseviZivotinje kategorija = k.Kategorija;

                            // 1. Brišemo životinju (dete)
                            s.Delete(k);

                            // 2. Brišemo kategoriju (roditelj) - Rešen TODO!
                            if (kategorija != null)
                            {
                                s.Delete(kategorija);
                            }

                            // Potvrđujemo transakciju
                            transaction.Commit();
                        }
                    }
                    catch (Exception ec)
                    {
                        if (transaction != null && transaction.IsActive)
                        {
                            transaction.Rollback();
                        }
                        MessageBox.Show($"Greška pri brisanju krmnog bilja: {ec.FormatExceptionMessage()}");
                    }
                }
            }
        }
        #endregion

        #region Proizvode

        public static void DodajPrinosIKategoriju(PrinosBasic prinosDTO, int idKategorije)
        {
            using (var session = DataLayer.GetSession())
            {
                // Transakcija - da ne bi puklo na pola
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        // Obican prinos
                        Prinos noviPrinos = new Prinos
                        {
                            Tip = prinosDTO.Tip,
                            Kolicina = (double)prinosDTO.Kolicina,
                            Komentar = prinosDTO.Komentar,
                            KvalitetProizvoda = prinosDTO.KvalitetProizvoda,
                            JedinicaMere = prinosDTO.JedinicaMere
                        };

                        session.Save(noviPrinos);

                        // Da bi smo bili sigurni da je prinos upisan u bazi
                        session.Flush();

                        // Podatak da je prinos proizveden i od koga
                        var kat = session.Get<UseviZivotinje>(idKategorije);

                        Proizvode novaVeza = new Proizvode();
                        novaVeza.Prinos = noviPrinos;
                        novaVeza.Kategorija = kat;
                        novaVeza.DatumProizvodnje = DateTime.Now;

                        session.Save(novaVeza);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Greška prilikom čuvanja prinosa u bazu: " + ex.Message);
                    }
                }
            }
        }

        public static int DohvatiIdKategorije(int idEntiteta, string tipEntiteta)
        {
            using (var s = DataLayer.GetSession())
            {
                switch (tipEntiteta)
                {
                    // Da bi smo bili sigurni da se izvlaci id kategorije
                    // pre zatvaranja sesije koristimo Get
                    case "POVRCE":
                        return s.Get<Povrce>(idEntiteta).Kategorija.UseviZivotinjeId;
                    case "ZITARICE":
                        return s.Get<Zitarice>(idEntiteta).Kategorija.UseviZivotinjeId; ;
                    case "VOCNJACI":
                        return s.Get<Vocnjaci>(idEntiteta).Kategorija.UseviZivotinjeId; ;
                    case "KRMNO_BILJE":
                        return s.Get<KrmnoBilje>(idEntiteta).Kategorija.UseviZivotinjeId;
                    case "ZIVOTINJE":
                        return s.Get<Zivotinje>(idEntiteta).Kategorija.UseviZivotinjeId; ;
                    default:
                        return -1;
                }
            }
        }

        public static void ObrisiProizvodnuVezu(int proizvodeId)
        {
            using (ISession s = DataLayer.GetSession())
            {
                using (ITransaction t = s.BeginTransaction())
                {
                    Proizvode veza = s.Load<Proizvode>(proizvodeId);

                    if (veza != null)
                    {
                        s.Delete(veza);
                        s.Flush();
                    }                    
                }
            }
        }

        public static List<ProizvodniIzvestajDTO> VratiSveProizvodneIzvestaje()
        {
            using (ISession s = DataLayer.GetSession())
            {
                var sviZapisi = s.Query<Proizvode>()
                                 .Fetch(x => x.Prinos)
                                 .Fetch(x => x.Kategorija)
                                 .ToList();               

                // Ono sto se prikazuje u DataGridView
                List<ProizvodniIzvestajDTO> izvestaj = new List<ProizvodniIzvestajDTO>();

                foreach (var z in sviZapisi)
                {

                    /*if (z.Kategorija == null || z.Kategorija.KategorijaTip == null)
                    {
                        continue;  
                    }*/

                    var dto = new ProizvodniIzvestajDTO
                    {
                        Id = z.Id,
                        DatumProizvodnje = z.DatumProizvodnje,
                        TipPrinosa = z.Prinos.Tip,
                        Kolicina = (decimal)z.Prinos.Kolicina,
                        JedinicaMere = z.Prinos.JedinicaMere,
                        Kvalitet = z.Prinos.KvalitetProizvoda,
                        KategorijaTip = z.Kategorija.KategorijaTip
                    };

                    int idKat = z.Kategorija.UseviZivotinjeId;

                    
                    //string tip = z.Kategorija.KategorijaTip.ToString().Trim().ToLower();
                    char tipChar = z.Kategorija.KategorijaTip.ToString().Trim()[0];

                    /*if (tipChar == 'u')
                    {
                        dto.NazivIzvora = "Usev";
                    }
                    else
                    {
                        dto.NazivIzvora = "Zivotinja";
                    }*/

                    //System.Diagnostics.Debug.WriteLine($"DB Vrednost: '{tip}', Dužina: {tip?.Length}");

                    switch (tipChar)
                    {
                        case 'u':
                            var usev = s.Query<Usevi>().FirstOrDefault(x => x.Kategorija != null && x.Kategorija.UseviZivotinjeId == idKat);
                            dto.NazivIzvora = usev != null ? usev.Naziv : "Nepoznat usev";
                            //dto.NazivIzvora = "Usev";
                            break;

                        case 'z':
                            var ziv = s.Query<Zivotinje>().FirstOrDefault(x => x.Kategorija != null && x.Kategorija.UseviZivotinjeId == idKat);
                            dto.NazivIzvora = ziv != null ? ziv.Vrsta : "Nepoznata životinja";                            
                            break;                     

                        default:
                            dto.NazivIzvora = "Nepoznat izvor";
                           break;
                    }

                  

                    izvestaj.Add(dto);
                }

                return izvestaj;
            }
        }

        #endregion
    }
}
