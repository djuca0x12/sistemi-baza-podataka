
namespace PoljoprivrednoGazdinstvoLibrary
{
    // beleške sa lab vežbi:
    // metode iz forms aplikacije
    // komunikacija sa bazom: greške i poruke o njima su bitne!
    // prosleđuju se nazad webapi-ju
    // -> tip Result sa povratnim tipom metode željenim i ErrorMessage (status code + message)
    //
    // u suštini: jedan veliki TODO za prepakovanje ovih metoda na željeni format za web api!
    //
    public static class DataProvider
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
                //MessageBox.Show($"Greška pri čitanju podataka: {ex.FormatExceptionMessage()}");
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
                //MessageBox.Show($"Greška prilikom dodavanja traktora u bazu: {ex.FormatExceptionMessage()}");
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
                //MessageBox.Show($"Greška prilikom učitavanja traktora: {ex.FormatExceptionMessage()}");
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
                //MessageBox.Show($"Greška prilikom izmene traktora: {ex.FormatExceptionMessage()}");
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
                //MessageBox.Show($"Greška prilikom brisanja traktora: {ex.FormatExceptionMessage()}");
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
                //MessageBox.Show($"Greška prilikom učitavanja masine: {ex.FormatExceptionMessage()}");
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
                //MessageBox.Show($"Greška prilikom dodavanja masine: {ex.FormatExceptionMessage()}");
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
                //MessageBox.Show($"Greška prilikom učitavanja masine: {ex.Message}");
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
                //MessageBox.Show($"Greška prilikom izmene masine: {ex.Message}");
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
                //MessageBox.Show($"Greška prilikom brisanja masine: {ex.Message}");
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
                //MessageBox.Show($"Greška prilikom dodavanja prinosa: {ex.Message}");
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
                //MessageBox.Show($"Greška prilikom učitavanja prinosa: {ex.Message}");
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
                //MessageBox.Show($"Greška prilikom učitavanja prinosa: {ex.Message}");
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
                //MessageBox.Show($"Greška prilikom izmene prinosa: {ex.Message}");
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
                //MessageBox.Show($"Greška prilikom brisanja prinosa: {ex.Message}");
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
                //MessageBox.Show($"Greška prilikom učitavanja prodaja: {ex.FormatExceptionMessage()}");
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
                //MessageBox.Show($"Greška prilikom učitavanja prodaje: {ex.Message}");
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
                //MessageBox.Show($"Greška prilikom izmene prodaje: {ex.Message}");
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
                //MessageBox.Show($"Greška prilikom brisanja prodaje: {ex.Message}");
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
                    //MessageBox.Show($"Greška: Jedinica mere na prinosu je '{prinos.JedinicaMere}', a na prodaji pokušavate da koristite '{jedinicaSaForme}'.");
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

        public static void AzurirajKoriscenje(int stariIdMehanizacija, int idPrinos, DateTime datumOd, int noviIdMehanizacija, DateTime? noviDatumDo)
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
        public async static Task<Result<List<ZivotinjeBasic>, ErrorMessage>> VratiSveZivotinje()
        {
            List<ZivotinjeBasic> zivotinje = new();
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                List<Zivotinje> sveZivotinje = await s.Query<Zivotinje>().ToListAsync();

                foreach (Zivotinje z in sveZivotinje)
                    zivotinje.Add(new ZivotinjeBasic(z.IdZivotinje, z.BrojUha, z.Vrsta, z.Pol, z.Rasa, z.BrojJedinki, z.DatumRodjenja, z.DatumUlaska, z.Tezina, z.Status, z.Komentar));

                s.Close();
            }
            catch (Exception ec)
            {
                return "Greška pri čitanju podataka o životinjama.".ToError(400);
            }
            return zivotinje;
        }
        public async static Task<Result<bool, ErrorMessage>> DodajZivotinju(ZivotinjeBasic z)
        {
            using (ISession s = DataLayer.GetSession())
            {
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }
                using (ITransaction transaction = s.BeginTransaction())
                {
                    try
                    {
                        UseviZivotinje uz = new()
                        {
                            // baza popunjava id preko sekvence
                            KategorijaTip = 'z'
                        };

                        await s.SaveAsync(uz);

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

                        await s.SaveAsync(zivotinja);
                        await transaction.CommitAsync();
                        return true;
                    }
                    catch (Exception ec)
                    {
                        if (transaction != null && transaction.IsActive)
                        {
                            await transaction.RollbackAsync();
                        }
                        return "Greška pri dodavanju životinje.".ToError(400);
                    }
                }
            }
        }

        public async static Task<Result<ZivotinjeBasic, ErrorMessage>> VratiZivotinju(int id)
        {
            ZivotinjeBasic zb = new();
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Zivotinje z = await s.LoadAsync<Zivotinje>(id);
                zb = new ZivotinjeBasic(z.IdZivotinje, z.BrojUha, z.Vrsta, z.Pol, z.Rasa, z.BrojJedinki, z.DatumRodjenja, z.DatumUlaska, z.Tezina, z.Status, z.Komentar);

                await s.FlushAsync();
                s.Close();
            }
            catch (Exception)
            {
                return "Greška pri pribavljanju životinje.".ToError(400);
            }
            return zb;
        }

        public async static Task<Result<bool, ErrorMessage>> IzmeniZivotinju(ZivotinjeBasic z)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }
                Zivotinje zivotinja = await s.LoadAsync<Zivotinje>(z.IdZivotinje);

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

                await s.UpdateAsync(zivotinja);
                await s.FlushAsync();
                s.Close();

                return true;
            }
            catch (Exception)
            {
                return "Greška pri izmeni životinje.".ToError(400);
            }
        }

        public async static Task<Result<bool, ErrorMessage>> ObrisiZivotinju(int id)
        {
            using (ISession s = DataLayer.GetSession())
            {
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }
                using (ITransaction transaction = s.BeginTransaction())
                {
                    try
                    {
                        Zivotinje z = await s.LoadAsync<Zivotinje>(id);

                        if (z != null)
                        {
                            UseviZivotinje kategorija = z.Kategorija!;

                            await s.DeleteAsync(z);

                            if (kategorija != null)
                            {
                                await s.DeleteAsync(kategorija);
                            }

                            await transaction.CommitAsync();
                            return true;
                        }
                        return "Životinja za brisanje nije pronađena.".ToError(404);
                    }
                    catch (Exception)
                    {
                        if (transaction != null && transaction.IsActive)
                        {
                            await transaction.RollbackAsync();
                        }
                        return "Greška pri brisanju životinje.".ToError(400);
                    }
                }
            }
        }
        #endregion

        #region Zitarice
        public async static Task<Result<List<ZitariceBasic>, ErrorMessage>> VratiSveZitarice()
        {
            List<ZitariceBasic> zitarice = new();
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                List<Zitarice> sveZitarice = await s.Query<Zitarice>().ToListAsync();

                foreach (Zitarice z in sveZitarice)
                    zitarice.Add(new ZitariceBasic(z.Id, z.Naziv, z.Lokacija, z.Vrsta, z.Povrsina, z.KvalitetZemljista,
                        z.DatumSetve, z.DatumZetvePlanirani, z.DatumZetveStvarni, z.Status, z.Komentar,
                        z.GustinaSetve, z.KolicinaSemenaPoHektaru, z.PrinosPoHektaru, z.TipDjubrenja, z.Tip));

                s.Close();
            }
            catch (Exception)
            {
                return "Greška pri čitanju podataka o žitaricama.".ToError(400);
            }
            return zitarice;
        }
        public async static Task<Result<ZitariceBasic, ErrorMessage>> VratiZitaricu(int id)
        {
            ZitariceBasic zb = new();
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Zitarice z = await s.LoadAsync<Zitarice>(id);
                zb = new ZitariceBasic(z.Id, z.Naziv, z.Lokacija, z.Vrsta, z.Povrsina, z.KvalitetZemljista,
                    z.DatumSetve, z.DatumZetvePlanirani, z.DatumZetveStvarni, z.Status, z.Komentar,
                    z.GustinaSetve, z.KolicinaSemenaPoHektaru, z.PrinosPoHektaru, z.TipDjubrenja, z.Tip);

                await s.FlushAsync();
                s.Close();
            }
            catch (Exception ec)
            {
                return "Greška pri pribavljanju žitarice.".ToError(400);
            }
            return zb;
        }

        public async static Task<Result<bool, ErrorMessage>> DodajZitaricu(ZitariceBasic z)
        {
            using (ISession s = DataLayer.GetSession())
            {
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }
                using (ITransaction transaction = s.BeginTransaction())
                {
                    try
                    {
                        UseviZivotinje uz = new()
                        {
                            // baza popunjava id preko sekvence
                            KategorijaTip = 'u'
                        };

                        await s.SaveAsync(uz);

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

                        await s.SaveOrUpdateAsync(zitarica);
                        await transaction.CommitAsync();
                        return true;
                    }
                    catch (Exception)
                    {
                        if (transaction != null && transaction.IsActive)
                        {
                            await transaction.RollbackAsync();
                        }
                        return "Greška pri dodavanju žitarice.".ToError(400);
                    }
                }
            }
        }
        public async static Task<Result<bool, ErrorMessage>> IzmeniZitaricu(ZitariceBasic z)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Zitarice zitarice = await s.GetAsync<Zitarice>(z.Id);
                if (zitarice == null)
                {
                    return "Žitarica nije pronađena.".ToError(404);
                }

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

                await s.SaveOrUpdateAsync(zitarice);

                await s.FlushAsync();
                s.Close();
                return true;
            }
            catch (Exception)
            {
                return "Greška pri izmeni žitarice.".ToError(400);
            }
        }

        public async static Task<Result<bool, ErrorMessage>> ObrisiZitaricu(int id)
        {
            using (ISession s = DataLayer.GetSession())
            {
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }
                using (ITransaction transaction = s.BeginTransaction())
                {
                    try
                    {
                        Zitarice z = await s.LoadAsync<Zitarice>(id);
                        if (z != null)
                        {
                            UseviZivotinje kategorija = z.Kategorija!;

                            await s.DeleteAsync(z);

                            if (kategorija != null)
                            {
                                s.Delete(kategorija);
                            }
                            await transaction.CommitAsync();
                            return true;
                        }
                        return "Žitarica za brisanje nije pronađena.".ToError(404);
                    }
                    catch (Exception)
                    {
                        if (transaction != null && transaction.IsActive)
                        {
                            await transaction.RollbackAsync();
                        }
                        return "Greška pri brisanju žitarice.".ToError(400);
                    }
                }
            }
        }
        #endregion

        #region Vocnjaci
        public async static Task<Result<List<VocnjaciBasic>, ErrorMessage>> VratiSveVocnjake()
        {
            List<VocnjaciBasic> vocnjaci = new();
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                List<Vocnjaci> sviVocnjaci = await s.Query<Vocnjaci>().ToListAsync();

                foreach (Vocnjaci v in sviVocnjaci)
                    vocnjaci.Add(new VocnjaciBasic(v.Id, v.Naziv, v.Lokacija, v.Vrsta, v.Povrsina, v.KvalitetZemljista,
                        v.DatumSetve, v.DatumZetvePlanirani, v.DatumZetveStvarni, v.Status, v.Komentar,
                        v.GodinaSadnje, v.BrojStabala, v.Sorta, v.DatumRezidbe, v.RodniCiklus));

                s.Close();
            }
            catch (Exception)
            {
                return "Greška pri čitanju podataka o voćnjacima.".ToError(400);
            }
            return vocnjaci;
        }
        public async static Task<Result<VocnjaciBasic, ErrorMessage>> VratiVocnjak(int id)
        {
            VocnjaciBasic vb = new();
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }
                Vocnjaci v = await s.LoadAsync<Vocnjaci>(id);
                vb = new VocnjaciBasic(v.Id, v.Naziv, v.Lokacija, v.Vrsta, v.Povrsina, v.KvalitetZemljista,
                    v.DatumSetve, v.DatumZetvePlanirani, v.DatumZetveStvarni, v.Status, v.Komentar,
                    v.GodinaSadnje, v.BrojStabala, v.Sorta, v.DatumRezidbe, v.RodniCiklus);

                await s.FlushAsync();
                s.Close();
            }
            catch (Exception ec)
            {
                return "Greška pri pribavljanju voćnjaka.".ToError(400);
            }
            return vb;
        }

        public async static Task<Result<bool, ErrorMessage>> DodajVocnjak(VocnjaciBasic v)
        {
            using (ISession s = DataLayer.GetSession())
            {
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }
                using (ITransaction transaction = s.BeginTransaction())
                {
                    try
                    {
                        UseviZivotinje uz = new()
                        {
                            // baza popunjava id preko sekvence
                            KategorijaTip = 'u'
                        };

                        await s.SaveAsync(uz);

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

                        await s.SaveOrUpdateAsync(vocnjak);
                        await transaction.CommitAsync();
                        return true;

                    }
                    catch (Exception)
                    {
                        if (transaction != null && transaction.IsActive)
                        {
                            await transaction.RollbackAsync();
                        }
                        return "Greška pri dodavanju voćnjaka.".ToError(400);
                    }
                }
            }
        }
        public async static Task<Result<bool, ErrorMessage>> IzmeniVocnjak(VocnjaciBasic v)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Vocnjaci vocnjak = await s.GetAsync<Vocnjaci>(v.Id);
                if (vocnjak == null)
                {
                    return "Voćnjak nije pronađen.".ToError(404);
                }

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

                await s.SaveOrUpdateAsync(vocnjak);

                await s.FlushAsync();
                s.Close();
                return true;
            }
            catch (Exception)
            {
                return "Greška pri izmeni voćnjaka.".ToError(400);
            }
        }

        public async static Task<Result<bool, ErrorMessage>> ObrisiVocnjak(int id)
        {
            using (ISession s = DataLayer.GetSession())
            {
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }
                using (ITransaction transaction = s.BeginTransaction())
                {
                    try
                    {
                        Vocnjaci v = await s.LoadAsync<Vocnjaci>(id);
                        if (v != null)
                        {
                            UseviZivotinje kategorija = v.Kategorija!;

                            await s.DeleteAsync(v);

                            if (kategorija != null)
                            {
                                await s.DeleteAsync(kategorija);
                            }
                            await transaction.CommitAsync();
                            return true;
                        }
                        return "Voćnjak za brisanje nije pronađen.".ToError(404);
                    }
                    catch (Exception)
                    {
                        if (transaction != null && transaction.IsActive)
                        {
                            await transaction.RollbackAsync();
                        }
                        return "Greška pri brisanju voćnjaka.".ToError(400);
                    }
                }
            }
        }

        #endregion

        #region Povrce
        public async static Task<Result<List<PovrceBasic>, ErrorMessage>> VratiSvoPovrce()
        {
            List<PovrceBasic> povrce = new();
            try
            {

                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                List<Povrce> svoPovrce = await s.Query<Povrce>().ToListAsync();

                foreach (Povrce p in svoPovrce)
                    povrce.Add(new PovrceBasic(p.Id, p.Naziv, p.Lokacija, p.Vrsta, p.Povrsina, p.KvalitetZemljista,
                        p.DatumSetve, p.DatumZetvePlanirani, p.DatumZetveStvarni, p.Status, p.Komentar,
                        p.BrojSetviGodisnje, p.ZastitneMere, p.NacinGajenja, p.Tip));
                s.Close();
            }
            catch (Exception ec)
            {
                return "Greška pri čitanju podataka o povrću.".ToError(400);
            }
            return povrce;
        }
        public async static Task<Result<PovrceBasic, ErrorMessage>> VratiPovrce(int id)
        {
            PovrceBasic pb = new();
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Povrce p = await s.LoadAsync<Povrce>(id);
                pb = new PovrceBasic(p.Id, p.Naziv, p.Lokacija, p.Vrsta, p.Povrsina, p.KvalitetZemljista,
                     p.DatumSetve, p.DatumZetvePlanirani, p.DatumZetveStvarni, p.Status, p.Komentar,
                     p.BrojSetviGodisnje, p.ZastitneMere, p.NacinGajenja, p.Tip
                  );

                await s.FlushAsync();
                s.Close();
            }
            catch (Exception)
            {
                return "Greška pri pribavljanju povrća.".ToError(400);
            }
            return pb;
        }

        public async static Task<Result<bool, ErrorMessage>> DodajPovrce(PovrceBasic p)
        {
            using (ISession s = DataLayer.GetSession())
            {
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }
                using (ITransaction transaction = s.BeginTransaction())
                {
                    try
                    {
                        UseviZivotinje uz = new()
                        {
                            // baza popunjava id preko sekvence
                            KategorijaTip = 'u'
                        };

                        await s.SaveAsync(uz);
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
                        await s.SaveOrUpdateAsync(povrce);
                        await transaction.CommitAsync();
                        return true;
                    }
                    catch (Exception)
                    {
                        if (transaction != null && transaction.IsActive)
                        {
                            await transaction.RollbackAsync();
                        }
                        return "Greška pri dodavanju povrća.".ToError(400);
                    }
                }
            }
        }
        public async static Task<Result<bool, ErrorMessage>> IzmeniPovrce(PovrceBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                Povrce povrce = await s.GetAsync<Povrce>(p.Id);
                if (povrce == null)
                {
                    return "Povrće nije pronađeno.".ToError(404);
                }

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

                await s.SaveOrUpdateAsync(povrce);
                await s.FlushAsync();
                s.Close();

                return true;
            }
            catch (Exception)
            {
                return "Greška pri izmeni povrća.".ToError(400);
            }
        }

        public async static Task<Result<bool, ErrorMessage>> ObrisiPovrce(int id)
        {
            using (ISession s = DataLayer.GetSession())
            {
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }
                using (ITransaction transaction = s.BeginTransaction())
                {
                    try
                    {
                        Povrce p = await s.LoadAsync<Povrce>(id);
                        if (p != null)
                        {
                            UseviZivotinje kategorija = p.Kategorija!;

                            await s.DeleteAsync(p);

                            if (kategorija != null)
                            {
                                await s.DeleteAsync(kategorija);
                            }

                            await transaction.CommitAsync();
                            return true;
                        }
                        return "Povrće za brisanje nije pronađeno.".ToError(404);
                    }
                    catch (Exception)
                    {
                        if (transaction != null && transaction.IsActive)
                        {
                            await transaction.RollbackAsync();
                        }
                        return "Greška pri brisanju povrća.".ToError(400);
                    }
                }
            }
        }
        #endregion

        #region KrmnoBilje
        public async static Task<Result<List<KrmnoBiljeBasic>, ErrorMessage>> VratiSvoKrmnoBilje()
        {
            List<KrmnoBiljeBasic> krma = new();
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                List<KrmnoBilje> svaKrma = await s.Query<KrmnoBilje>().ToListAsync();

                foreach (KrmnoBilje k in svaKrma)
                    krma.Add(new KrmnoBiljeBasic(k.Id, k.Naziv, k.Lokacija, k.Vrsta, k.Povrsina, k.KvalitetZemljista,
                        k.DatumSetve, k.DatumZetvePlanirani, k.DatumZetveStvarni, k.Status, k.Komentar,
                        k.VrstaKrme, k.BrojKosnjiGodisnje, k.ProcenatProteina, k.IshranaStokeFlag, k.ZaProdajuFlag));

                s.Close();
            }
            catch (Exception ec)
            {
                return "Greška pri čitanju podataka o krmnom bilju.".ToError(400);
            }
            return krma;
        }
        public async static Task<Result<KrmnoBiljeBasic, ErrorMessage>> VratiKrmnoBilje(int id)
        {
            KrmnoBiljeBasic kb = new();
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                KrmnoBilje k = await s.LoadAsync<KrmnoBilje>(id);
                kb = new KrmnoBiljeBasic(k.Id, k.Naziv, k.Lokacija, k.Vrsta, k.Povrsina, k.KvalitetZemljista,
                        k.DatumSetve, k.DatumZetvePlanirani, k.DatumZetveStvarni, k.Status, k.Komentar,
                        k.VrstaKrme, k.BrojKosnjiGodisnje, k.ProcenatProteina, k.IshranaStokeFlag, k.ZaProdajuFlag);

                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                return "Greška pri pribavljanju krmnog bilja.".ToError(400);
            }
            return kb;
        }

        public async static Task<Result<bool, ErrorMessage>> DodajKrmnoBilje(KrmnoBiljeBasic k)
        {
            using (ISession s = DataLayer.GetSession())
            {
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }
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
                        await s.SaveAsync(uz);

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

                        await s.SaveOrUpdateAsync(krma);
                        await transaction.CommitAsync();
                        return true;
                    }
                    catch (Exception ec)
                    {
                        if (transaction != null && transaction.IsActive)
                        {
                            transaction.Rollback();
                        }
                        return "Greška pri dodavanju krmnog bilja.".ToError(400);
                    }
                }
            }
        }

        public async static Task<Result<bool, ErrorMessage>> IzmeniKrmnoBilje(KrmnoBiljeBasic z)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }

                KrmnoBilje krma = await s.GetAsync<KrmnoBilje>(z.Id);
                if (krma == null)
                {
                    return "Krmno bilje nije pronađeno.".ToError(404);
                }

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

                await s.SaveOrUpdateAsync(krma);

                await s.FlushAsync();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                return "Greška pri izmeni krmnog bilja.".ToError(400);
            }
        }

        public async static Task<Result<bool, ErrorMessage>> ObrisiKrmnoBilje(int id)
        {
            using (ISession s = DataLayer.GetSession())
            {
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.".ToError(403);
                }
                using (ITransaction transaction = s.BeginTransaction())
                {
                    try
                    {
                        KrmnoBilje k = await s.LoadAsync<KrmnoBilje>(id);
                        if (k != null)
                        {
                            UseviZivotinje kategorija = k.Kategorija!;

                            await s.DeleteAsync(k);

                            if (kategorija != null)
                            {
                                await s.DeleteAsync(kategorija);
                            }

                            await transaction.CommitAsync();
                            return true;
                        }
                        return "Krmno bilje za brisanje nije pronađeno.".ToError(404);
                    }
                    catch (Exception)
                    {
                        if (transaction != null && transaction.IsActive)
                        {
                            await transaction.RollbackAsync();
                        }
                        return "Greška pri brisanju krmnog bilja.".ToError(400);
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

        // todo: morala sam da zakomentarišem, javljalo mi je grešku u konzoli
        // pa baci pogled kad stigneš

        //public static List<ProizvodniIzvestajDTO> VratiSveProizvodneIzvestaje()
        //{
        //    using (ISession s = DataLayer.GetSession())
        //    {
        //        var sviZapisi = s.Query<Proizvode>()
        //                         .Fetch(x => x.Prinos)
        //                         .Fetch(x => x.Kategorija)
        //                         .ToList();               

        //        // Ono sto se prikazuje u DataGridView
        //        List<ProizvodniIzvestajDTO> izvestaj = new List<ProizvodniIzvestajDTO>();

        //        foreach (var z in sviZapisi)
        //        {

        //            /*if (z.Kategorija == null || z.Kategorija.KategorijaTip == null)
        //            {
        //                continue;  
        //            }*/

        //            var dto = new ProizvodniIzvestajDTO
        //            {
        //                Id = z.Id,
        //                DatumProizvodnje = z.DatumProizvodnje,
        //                TipPrinosa = z.Prinos.Tip,
        //                Kolicina = (decimal)z.Prinos.Kolicina,
        //                JedinicaMere = z.Prinos.JedinicaMere,
        //                Kvalitet = z.Prinos.KvalitetProizvoda,
        //                KategorijaTip = z.Kategorija.KategorijaTip
        //            };

        //            int idKat = z.Kategorija.UseviZivotinjeId;


        //            //string tip = z.Kategorija.KategorijaTip.ToString().Trim().ToLower();
        //            char tipChar = z.Kategorija.KategorijaTip.ToString().Trim()[0];

        //            /*if (tipChar == 'u')
        //            {
        //                dto.NazivIzvora = "Usev";
        //            }
        //            else
        //            {
        //                dto.NazivIzvora = "Zivotinja";
        //            }*/

        //            //System.Diagnostics.Debug.WriteLine($"DB Vrednost: '{tip}', Dužina: {tip?.Length}");

        //            switch (tipChar)
        //            {
        //                case 'u':
        //                    var usev = s.Query<Usevi>().FirstOrDefault(x => x.Kategorija != null && x.Kategorija.UseviZivotinjeId == idKat);
        //                    dto.NazivIzvora = usev != null ? usev.Naziv : "Nepoznat usev";
        //                    //dto.NazivIzvora = "Usev";
        //                    break;

        //                case 'z':
        //                    var ziv = s.Query<Zivotinje>().FirstOrDefault(x => x.Kategorija != null && x.Kategorija.UseviZivotinjeId == idKat);
        //                    dto.NazivIzvora = ziv != null ? ziv.Vrsta : "Nepoznata životinja";                            
        //                    break;                     

        //                default:
        //                    dto.NazivIzvora = "Nepoznat izvor";
        //                   break;
        //            }



        //            izvestaj.Add(dto);
        //        }

        //        return izvestaj;
        //    }
        //}

        #endregion
    }
}
