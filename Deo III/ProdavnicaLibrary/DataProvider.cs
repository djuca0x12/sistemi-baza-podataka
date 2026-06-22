namespace ProdavnicaLibrary;

public static class DataProvider
{
    #region Odeljenja

    // metode iz forms aplikacije
    // komunikacija sa bazom: greške i poruke o njima su bitne!
    // prosleđuju se nazad webapi-ju
    // -> tip Result sa povratnim tipom metode željenim i ErrorMessage (status code + message)
    public static async Task<Result<List<OdeljenjeView>, ErrorMessage>> VratiSvaOdeljenjaAsync()
    {
        List<OdeljenjeView> data = new();

        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                // postavi status code
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            // implicitni operator konvertovanja omogućava da vratimo samo podatke
            data = (await s.QueryOver<Odeljenje>().ListAsync())
                           .Select(p => new OdeljenjeView(p)).ToList();
        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o odeljenjima.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }

    public static async Task<Result<List<OdeljenjeView>, ErrorMessage>> VratiSvaOdeljenjaProdavniceAsync(int id)
    {
        List<OdeljenjeView> data = new();

        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            data = (await s.QueryOver<Odeljenje>().ListAsync())
                           .Where(p => p.PripadaProdavnici?.Id == id)
                           .Select(p => new OdeljenjeView(p)).ToList();
        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o odeljenjima.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }

    #region OdeljenjaDo5
    public async static Task<Result<bool, ErrorMessage>> ObrisiOdeljenjeAsync(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Odeljenje odeljenje = await s.LoadAsync<Odeljenje>(id);

            await s.DeleteAsync(odeljenje);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Greška prilikom brisanja odeljenja.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<OdeljenjeDo5View, ErrorMessage>> VratiOdeljenjaDo5Async(int id)
    {
        ISession? s = null;
        OdeljenjeDo5View o = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            OdeljenjeDo5 odeljenje = await s.LoadAsync<OdeljenjeDo5>(id);

            o.OdeljenjeId = odeljenje.Id;
            o.Lokacija = odeljenje.Lokacija;
            o.BrojKasa = odeljenje.BrojKasa;
            o.InfoPult = odeljenje.InfoPult;
        }
        catch (Exception)
        {
            return "Nemoguće vratiti odeljenja.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return o;
    }

    public static Result<List<OdeljenjeView>, ErrorMessage> GetOdInfos(int prodavnicaId)
    {
        ISession? s = null;
        List<OdeljenjeView> odInfos = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<Odeljenje> odeljenja = from o in s.Query<Odeljenje>()
                                               where o.PripadaProdavnici != null && o.PripadaProdavnici.Id == prodavnicaId
                                               select o;

            // Drugi način, bez foreach petlje (LINQ)
            // odInfos = odeljenja.Select(p => new OdeljenjeView(p)).ToList();

            foreach (Odeljenje o in odeljenja)
            {
                odInfos.Add(new OdeljenjeView(o));
            }

        }
        catch (Exception)
        {
            return "Nemoguće pronaći odeljenja ili pripadajuće prodavnice.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return odInfos;
    }

    public static Result<List<OdeljenjeDo5View>, ErrorMessage> VratiOdeljenjaDo5Prodavnice(int prodavnicaId)
    {
        ISession? s = null;
        List<OdeljenjeDo5View> odInfos = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<OdeljenjeDo5> odeljenja = from o in s.Query<OdeljenjeDo5>()
                                                  where o.PripadaProdavnici != null && o.PripadaProdavnici.Id == prodavnicaId
                                                  select o;

            odInfos = odeljenja.Select(o => new OdeljenjeDo5View(o, o.PripadaProdavnici)).ToList();

            /*foreach (OdeljenjeDo5 o in odeljenja)
            {
                var od5 = new OdeljenjeDo5View(o, o.PripadaProdavnici);
                odInfos.Add(od5);
            }*/
        }
        catch (Exception)
        {
            return "Nemoguće pronaći odeljenja koja pripadaju prodavnici.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return odInfos;
    }

    public async static Task<Result<bool, ErrorMessage>> IzmeniOdeljenjeDo5Async(OdeljenjeDo5View odeljenje)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            OdeljenjeDo5 o = await s.LoadAsync<OdeljenjeDo5>(odeljenje.OdeljenjeId);

            o.Lokacija = odeljenje.Lokacija;
            o.BrojKasa = odeljenje.BrojKasa;
            o.InfoPult = odeljenje.InfoPult;

            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće izmeniti odeljenje do 5 godina.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<int, ErrorMessage>> SacuvajOdeljenjeDo5BezProdavniceAsync(OdeljenjeDo5View odeljenje)
    {
        ISession? s = null;
        int id = default;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            OdeljenjeDo5 o = new()
            {
                Lokacija = odeljenje.Lokacija,
                BrojKasa = odeljenje.BrojKasa,
                InfoPult = odeljenje.InfoPult
            };

            await s.SaveAsync(o);
            await s.FlushAsync();

            id = o.Id;
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati odeljenje bez prodavnice.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return id;
    }

    public async static Task<Result<bool, ErrorMessage>> PoveziOdeljenjeDo5IProdavnicuAsync(int odeljenjeID, int prodavnicaID)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            OdeljenjeDo5 odeljenje = await s.LoadAsync<OdeljenjeDo5>(odeljenjeID);
            Prodavnica prodavnica = await s.LoadAsync<Prodavnica>(prodavnicaID);

            odeljenje.PripadaProdavnici = prodavnica;

            await s.UpdateAsync(odeljenje);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće povezati odeljenje sa prodavnicom.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<bool, ErrorMessage>> SacuvajOdeljenjeAsync(OdeljenjeView odeljenje, string tip, int idProdavnice)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Prodavnica p = await s.LoadAsync<Prodavnica>(idProdavnice);

            /*Odeljenje? o = null;

            switch(tip)
            {
                case "Do5":
                    o = new OdeljenjeDo5();
                    break;
                case "Od6Do16":
                    o = new OdeljenjeOd6Do16();
                    break;
                case "Odrasli":
                    o = new OdeljenjeOdrasli();
                    break;
            }*/

            Odeljenje? o = tip switch
            {
                "Do5" => new OdeljenjeDo5(),
                "Od6Do16" => new OdeljenjeOd6Do16(),
                "Odrasli" => new OdeljenjeOdrasli(),
                _ => null,
            };

            if (o != null)
            {
                o.Lokacija = odeljenje.Lokacija;
                o.BrojKasa = odeljenje.BrojKasa;
                o.InfoPult = odeljenje.InfoPult;
                o.PripadaProdavnici = p;

                await s.SaveAsync(o);
                await s.FlushAsync();
                odeljenje.OdeljenjeId = o.Id;
            }
            else
            {
                return "Pogrešan tip odeljenja.".ToError(400);
            }
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati odeljenje do 5 godina.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<bool, ErrorMessage>> SacuvajOdeljenjeDo5Async(OdeljenjeDo5View odeljenje, int idProdavnice)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Prodavnica p = await s.LoadAsync<Prodavnica>(idProdavnice);

            OdeljenjeDo5 o = new()
            {
                Lokacija = odeljenje.Lokacija,
                BrojKasa = odeljenje.BrojKasa,
                InfoPult = odeljenje.InfoPult,
                PripadaProdavnici = p
            };

            await s.SaveAsync(o);
            await s.FlushAsync();
            odeljenje.OdeljenjeId = o.Id;
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati odeljenje do 5 godina.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }
    #endregion

    #region OdeljenjaOd6Do16
    public static Result<bool, ErrorMessage> ObrisiOdeljenjeOd6Do16(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            OdeljenjeOd6Do16 odeljenje = s.Load<OdeljenjeOd6Do16>(id);

            s.Delete(odeljenje);
            s.Flush();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati odeljenje od 6 do 16 godina.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public static Result<OdeljenjeOd6Do16View, ErrorMessage> VratiOdeljenjaOd6Do16(int id)
    {
        OdeljenjeOd6Do16View o = new();

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            OdeljenjeOd6Do16 odeljenje = s.Load<OdeljenjeOd6Do16>(id);

            o.OdeljenjeId = odeljenje.Id;
            o.Lokacija = odeljenje.Lokacija;
            o.BrojKasa = odeljenje.BrojKasa;
            o.InfoPult = odeljenje.InfoPult;

            s.Close();
        }
        catch (Exception)
        {
            // Kada se pozove throw iz catch bloka, isti exception se prosleđuje u metodu koja zove
            // trenutnu, a u ovom slučaju u metodu kontrolera. Ako se tamo ne obradi, pojaviće se
            // prilikom poziva metode, pa je zato svuda iznad zamenjeno sa bool vrednošću koja može
            // da bude i string koji opisuje grešku.
            // handle exceptions

            // throw;
            return "Nemoguće pronaći odeljenje od 6 do 16 godina.".ToError(400);
        }

        return o;
    }

    public static Result<List<OdeljenjeOd6Do16View>, ErrorMessage> VratiOdeljenjaOd6Do16Prodavnice(int prodavnicaId)
    {
        List<OdeljenjeOd6Do16View> odInfos = new();

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<OdeljenjeOd6Do16> odeljenja = from o in s.Query<OdeljenjeOd6Do16>()
                                                      where o.PripadaProdavnici != null && o.PripadaProdavnici.Id == prodavnicaId
                                                      select o;

            foreach (OdeljenjeOd6Do16 o in odeljenja)
            {
                odInfos.Add(new OdeljenjeOd6Do16View(o));
            }

            s.Close();

        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće vratiti odeljenja od 6 do 16 godina koja pripadaju prodavnici sa zadatim ID-jem.".ToError(400);
        }

        return odInfos;
    }

    public static Result<bool, ErrorMessage> IzmeniOdeljenjeOd6Do16(OdeljenjeOd6Do16View odeljenje)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            OdeljenjeOd6Do16 o = s.Load<OdeljenjeOd6Do16>(odeljenje.OdeljenjeId);

            o.Lokacija = odeljenje.Lokacija;
            o.BrojKasa = odeljenje.BrojKasa;
            o.InfoPult = odeljenje.InfoPult;

            s.SaveOrUpdate(o);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće izmeniti odeljenje od 6 do 16 godina.".ToError(400);
        }

        return true;
    }

    public static Result<bool, ErrorMessage> SacuvajOdeljenjeOd6Do16(OdeljenjeOd6Do16View odeljenje, int idProdavnice)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            OdeljenjeOd6Do16 o = new();
            Prodavnica p = s.Load<Prodavnica>(idProdavnice);

            o.Lokacija = odeljenje.Lokacija;
            o.BrojKasa = odeljenje.BrojKasa;
            o.InfoPult = odeljenje.InfoPult;
            o.PripadaProdavnici = p;

            s.SaveOrUpdate(o);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;

            return "Nemoguće sačuvati odeljenje od 6 do 16 godina.".ToError(400);
        }

        return true;
    }
    #endregion

    #region OdeljenjeZaOdrasle
    public static Result<bool, ErrorMessage> ObrisiOdeljenjeZaOdrsla(int id)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            OdeljenjeOdrasli odeljenje = s.Load<OdeljenjeOdrasli>(id);

            s.Delete(odeljenje);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće obrisati odeljenje za odrasle.".ToError(400);
        }

        return true;
    }

    public static Result<OdeljenjeOdrasliView, ErrorMessage> VratiOdeljenjaOdrasli(int id)
    {
        OdeljenjeOdrasliView o = new();

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            OdeljenjeOdrasli odeljenje = s.Load<OdeljenjeOdrasli>(id);

            o.OdeljenjeId = odeljenje.Id;
            o.Lokacija = odeljenje.Lokacija;
            o.BrojKasa = odeljenje.BrojKasa;
            o.InfoPult = odeljenje.InfoPult;

            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće vratiti odeljenje za odrasle.".ToError(400);
        }

        return o;
    }

    public static Result<List<OdeljenjeOdrasliView>, ErrorMessage> VratiOdeljenjaOdrasliProdavnice(int prodavnicaId)
    {
        List<OdeljenjeOdrasliView> odInfos = new();

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<OdeljenjeOdrasli> odeljenja = from o in s.Query<OdeljenjeOdrasli>()
                                                      where o.PripadaProdavnici != null && o.PripadaProdavnici.Id == prodavnicaId
                                                      select o;

            foreach (OdeljenjeOdrasli o in odeljenja)
            {
                odInfos.Add(new OdeljenjeOdrasliView(o));
            }

            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće vratiti odeljenje za odrasle koje pripada prodavnici sa zadatim ID-jem.".ToError(400);
        }

        return odInfos;
    }

    public static Result<bool, ErrorMessage> IzmeniOdeljenjeOdrasli(OdeljenjeOdrasliView odeljenje)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            OdeljenjeOdrasli o = s.Load<OdeljenjeOdrasli>(odeljenje.OdeljenjeId);

            o.Lokacija = odeljenje.Lokacija;
            o.BrojKasa = odeljenje.BrojKasa;
            o.InfoPult = odeljenje.InfoPult;

            s.SaveOrUpdate(o);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće izmeniti odeljenje za odrasle.".ToError(400);
        }

        return true;
    }

    public static Result<bool, ErrorMessage> SacuvajOdeljenjeOdrasli(OdeljenjeOdrasliView odeljenje, int idProdavnice)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            OdeljenjeOdrasli o = new();
            Prodavnica p = s.Load<Prodavnica>(idProdavnice);

            o.Lokacija = odeljenje.Lokacija;
            o.BrojKasa = odeljenje.BrojKasa;
            o.InfoPult = odeljenje.InfoPult;
            o.PripadaProdavnici = p;

            s.Save(o);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;

            return "Nemoguće sačuvati odeljenje za odrasle.".ToError(400);
        }

        return true;
    }
    #endregion
    #endregion

    #region Prodavnica
    public static Result<List<ProdavnicaView>, ErrorMessage> VratiSveProdavnice()
    {
        ISession? s = null;

        List<ProdavnicaView> prodavnice = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<Prodavnica> sveProdavnice = from o in s.Query<Prodavnica>()
                                                    select o;

            foreach (Prodavnica p in sveProdavnice)
            {
                prodavnice.Add(new ProdavnicaView(p));
            }
        }
        catch (Exception)
        {
            return "Nemoguće vratiti sve prodavnice.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return prodavnice;
    }

    public async static Task<Result<bool, ErrorMessage>> DodajProdavnicuAsync(ProdavnicaView p)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Prodavnica o = new()
            {
                Naziv = p.Naziv,
                Adresa = p.Adresa,
                BrojTelefona = p.BrojTelefona,
                RadniDan = p.RadniDan,
                Subota = p.Subota,
                Nedelja = p.Nedelja
            };

            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return GetError("Nemoguće dodati prodavnicu.", 404);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<ProdavnicaView, ErrorMessage>> AzurirajProdavnicuAsync(ProdavnicaView p)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Prodavnica o = s.Load<Prodavnica>(p.Id);
            o.Naziv = p.Naziv;
            o.Adresa = p.Adresa;
            o.BrojTelefona = p.BrojTelefona;
            o.RadniDan = p.RadniDan;
            o.Subota = p.Subota;
            o.Nedelja = p.Nedelja;

            await s.UpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati prodavnicu.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return p;
    }

    public async static Task<Result<ProdavnicaView, ErrorMessage>> VratiProdavnicuAsync(int id)
    {
        ISession? s = null;

        ProdavnicaView prodavnicaView = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Prodavnica o = await s.LoadAsync<Prodavnica>(id);
            prodavnicaView = new ProdavnicaView(o);
        }
        catch (Exception)
        {
            return "Nemoguće vratiti prodavnicu sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return prodavnicaView;
    }

    public async static Task<Result<bool, ErrorMessage>> ObrisiProdavnicuAsync(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Prodavnica o = await s.LoadAsync<Prodavnica>(id);

            await s.DeleteAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati prodavnicu.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }
    #endregion

    #region Radnici
    public async static Task<Result<bool, ErrorMessage>> DodajRadniOdnosAsync(RadiUView radi)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            RadiU r = new()
            {
                Id = new RadiUId
                {
                    RadiUProdavnica = await s.LoadAsync<Prodavnica>(radi.Id?.RadiUProdavnica?.Id),
                    RadnikRadiU = await s.LoadAsync<Radnik>(radi.Id?.RadnikRadiU?.Jbr)
                },
                DatumOd = radi.DatumOd,
                DatumDo = radi.DatumDo
            };

            await s.SaveOrUpdateAsync(r);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće dodati radni odnos radniku.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<List<RadnikView>, ErrorMessage>> VratiSveRadnikeAsync()
    {
        ISession? s = null;

        List<RadnikView> radnici = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            // List nije preporučljivo koristiti u ovakvim upitima, kada imamo neki uslov,
            // zato što će svakako da se pribave svi podaci iz baze, a to ne želimo. Ovde to nije slučaj,
            // svakako preuzimamo sve podatke.
            IEnumerable<Radnik> sviRadnici = from o in await s.QueryOver<Radnik>().ListAsync()
                                             select o;

            foreach (Radnik r in sviRadnici)
            {
                // Radnici bez prodavnica
                // radnici.Add(new RadnikView(r));

                // Sa prodavnicama u kojima rade
                var prodavnice = r.RadiUProdavnice;
                var radnik = new RadnikView(r)
                {
                    RadiUProdavnice = prodavnice?.Select(p => new RadiUView(p)).ToList()
                };
                radnici.Add(radnik);
            }
        }
        catch (Exception)
        {
            return "Nemoguće vratiti sve radnike.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return radnici;
    }

    public static Result<List<RadnikView>, ErrorMessage> VratiSveRadnikeProdavnice(int id)
    {
        ISession? s = null;

        List<RadnikView> radnici = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<RadiU> sviRadnici = from o in s.Query<RadiU>()
                                            where o.Id != null && o.Id.RadiUProdavnica != null && o.Id.RadiUProdavnica.Id == id
                                            select o;

            foreach (RadiU r in sviRadnici)
            {
                radnici.Add(new RadnikView(r.Id?.RadnikRadiU));
            }
        }
        catch (Exception)
        {
            return "Nemoguće vratiti sve radnike koji rade u prodavnici sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return radnici;
    }

    public async static Task<Result<bool, ErrorMessage>> DodajRadnikaAsync(RadnikView r)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Radnik o = new()
            {
                Mbr = r.Mbr,
                Ime = r.Ime,
                SrednjeSlovo = r.SrednjeSlovo,
                Prezime = r.Prezime,
                DatumRodjenja = r.DatumRodjenja,
                StrucnaSprema = r.StrucnaSpema
            };

            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće dodati radnika.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public static Result<RadnikView, ErrorMessage> AzurirajRadnika(RadnikView r)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Radnik o = s.Load<Radnik>(r.Jbr);

            o.Ime = r.Ime;
            o.SrednjeSlovo = r.SrednjeSlovo;
            o.Prezime = r.Prezime;
            o.DatumRodjenja = r.DatumRodjenja;
            o.StrucnaSprema = r.StrucnaSpema;
            // o.Sef = r.Sef;

            s.Update(o);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće ažurirati radnika.".ToError(400);
        }

        return r;
    }

    public async static Task<Result<RadnikView, ErrorMessage>> VratiRadnikaAsync(int id)
    {
        ISession? s = null;

        RadnikView radnikView = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Radnik r = await s.LoadAsync<Radnik>(id);
            radnikView = new RadnikView(r);
        }
        catch (Exception)
        {
            return "Nemoguće vratiti radnika sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return radnikView;
    }

    public async static Task<Result<bool, ErrorMessage>> ObrisiRadnikaIzSistemaAsync(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Radnik r = await s.LoadAsync<Radnik>(id);
            r.Prodavnice?.Clear();
            r.RadiUProdavnice?.Clear(); //jedan radnik moze da radi i u vise prodavnica 

            await s.DeleteAsync(r);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati radnika sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public static Result<bool, ErrorMessage> ObrisiRadnika(int id)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Radnik r = s.Load<Radnik>(id);
            r.Prodavnice?.Clear();
            // r.RadiUProdavnice.Clear(); jedan radnik moze da radi i u vise prodavnica //ovo mozda nece biti potrebno

            s.Delete(r);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće obrisati radnika sa zadatim ID-jem.".ToError(400);
        }

        return true;
    }
    #endregion

    #region RadiU
    public static Result<List<RadiUView>, ErrorMessage> VratiRadniOdnos(int idZaposlenog, int idProdavnice)
    {
        List<RadiUView> radi = new();

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<RadiU> rad = from o in s.Query<RadiU>()
                                     where o.Id != null && o.Id.RadnikRadiU != null && o.Id.RadnikRadiU.Jbr == idZaposlenog
                                     where o.Id != null && o.Id.RadiUProdavnica != null && o.Id.RadiUProdavnica.Id == idProdavnice
                                     select o;

            foreach (RadiU r in rad)
            {
                radi.Add(new RadiUView(r));
            }

            s.Close();

        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće vratiti radni odnos zaposlenog u prodavnici.".ToError(400);
        }

        return radi;
    }

    public static Result<bool, ErrorMessage> IzmeniRadniOdnos(RadiUView rad)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            RadiUId id = new()
            {
                RadnikRadiU = s.Load<Radnik>(rad.Id?.RadnikRadiU?.Jbr),
                RadiUProdavnica = s.Load<Prodavnica>(rad.Id?.RadiUProdavnica?.Id)
            };

            RadiU o = s.Load<RadiU>(id);

            o.DatumOd = rad.DatumOd;
            o.DatumDo = rad.DatumDo;

            s.SaveOrUpdate(o);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće izmeniti radni odnos.".ToError(400);
        }

        return true;
    }
    #endregion

    #region Proizvodi
    public static Result<List<ProizvodView>, ErrorMessage> VratiSveProizvode()
    {
        List<ProizvodView> proizvodi = new();

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<Proizvod> sviProizvodi = from o in s.Query<Proizvod>()
                                                 select o;

            foreach (Proizvod p in sviProizvodi)
            {
                proizvodi.Add(new ProizvodView(p));
            }

            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće vratiti sve proizvode.".ToError(400);
        }

        return proizvodi;
    }
    #endregion

    #region Sef
    public static Result<List<SefView>, ErrorMessage> VratiSveSefove()
    {
        List<SefView> radnici = new();

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<Sef> sviSefovi = from o in s.Query<Sef>()
                                         select o;

            foreach (Sef r in sviSefovi)
            {
                radnici.Add(new SefView(r));
            }

            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće vratiti sve šefove.".ToError(400);
        }

        return radnici;
    }

    public async static Task<Result<List<SefujeView>, ErrorMessage>> VratiSveSefoveProdavniceAsync(int id)
    {
        ISession? s = null;

        List<SefujeView> sefovanje = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<Sefuje> sviSefovi = from o in s.Query<Sefuje>()
                                            where o.Upravlja != null && o.Upravlja.Id == id
                                            select o;

            foreach (Sefuje r in sviSefovi)
            {
                var upravnik = VratiSefa(r.Upravnik?.Jbr ?? -1);
                var upravlja = await VratiProdavnicuAsync(r.Upravlja?.Id ?? -1);

                if (upravlja.IsError)
                {
                    // Preskače Sefuje koji ima grešku prilikom preuzimanja prodavnice
                    continue;
                }

                sefovanje.Add(new SefujeView(r));
            }
        }
        catch (Exception)
        {
            return "Nemoguće vratiti sve šefove prodavnice sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return sefovanje;
    }

    public static Result<List<RadiUView>, ErrorMessage> RadiUProdavnice(int jbrRadnik)
    {
        ISession? s = null;

        List<RadiUView> prodavniceUKojimaRadi = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IList<RadiU>? radiU = s.Query<Radnik>()
                         .Where(p => p.Jbr == jbrRadnik)
                         .FirstOrDefault()?.RadiUProdavnice;

            if (radiU != null)
            {
                foreach (RadiU r in radiU)
                {
                    RadiUView radi = new(r)
                    {
                        Id = new RadiUIdView()
                        {
                            RadnikRadiU = new RadnikView(r?.Id?.RadnikRadiU),
                            RadiUProdavnica = new ProdavnicaView(r?.Id?.RadiUProdavnica)
                        }
                    };
                    prodavniceUKojimaRadi.Add(radi);
                }
            }
        }
        catch (Exception)
        {
            return "Nemoguće vratiti zaposlenja za radnika.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return prodavniceUKojimaRadi;
    }

    public static Result<bool, ErrorMessage> DodajSefOdnos(SefujeView sefuje)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Sefuje r = new()
            {
                Upravlja = s.Load<Prodavnica>(sefuje.Upravlja?.Id),
                Upravnik = s.Load<Sef>(sefuje.Upravnik?.Jbr), // OVDE JE GRESKA
                DatumPostavljenja = sefuje.DatumPostavljenja
            };

            s.SaveOrUpdate(r);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće dodati šefa.".ToError(400);
        }

        return true;
    }

    public static Result<bool, ErrorMessage> DodajSefa(SefView r)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Sef o = new()
            {
                Mbr = r.Mbr,
                Ime = r.Ime,
                SrednjeSlovo = r.SrednjeSlovo,
                Prezime = r.Prezime,
                DatumRodjenja = r.DatumRodjenja,
                StrucnaSprema = r.StrucnaSpema
            };

            s.SaveOrUpdate(o);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;

            return "Nemoguće dodati šefa.".ToError(400);
        }

        return true;
    }

    public static Result<SefView, ErrorMessage> VratiSefa(int id)
    {
        SefView sefView;

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Sef sef = s.Load<Sef>(id);
            sefView = new SefView(sef);

            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće vratiti šefa.".ToError(400);
        }

        return sefView;
    }

    public static Result<RadnikView, ErrorMessage> AzurirajSefa(RadnikView r)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Radnik o = s.Load<Radnik>(r.Jbr);

            o.Ime = r.Ime;
            o.SrednjeSlovo = r.SrednjeSlovo;
            o.Prezime = r.Prezime;
            o.DatumRodjenja = r.DatumRodjenja;
            o.StrucnaSprema = r.StrucnaSpema;
            // o.Sef = r.Sef;

            s.Update(o);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće ažurirati šefa.".ToError(400);
        }

        return r;
    }

    public static Result<bool, ErrorMessage> ObrisiSefa(int id)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Sefuje r = s.Load<Sefuje>(id);

            //r.RadiUProdavnice.Clear();
            //r.SefujeProdavnice.Clear();
            s.Delete(r);
            s.Flush();

            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće obrisati šefa.".ToError(400);
        }

        return true;
    }
    #endregion

    #region Proizvodi
    public static Result<List<ProizvodView>, ErrorMessage> VratiSveProizvodeView()
    {
        List<ProizvodView> prodaja = new();

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<Proizvod> proizvodi = from o in s.Query<Proizvod>()
                                              select o;

            foreach (Proizvod p in proizvodi)
            {
                var proizvod = VratiProizvod(p.BarKod);

                if (proizvod.IsSuccess)
                {
                    prodaja.Add(proizvod.Data);
                }
            }

            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće vratiti sve proizvode.".ToError(400);
        }

        return prodaja;
    }

    public static Result<List<ProdajeSeView>, ErrorMessage> VratiProizvodeOdeljenjaDo5(int odeljenjeId)
    {
        ISession? s = null;

        List<ProdajeSeView> prodaja = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<ProdajeSe> proizvodi = from o in s.Query<ProdajeSe>()
                                               where o.ProdajeOdeljenje != null && o.ProdajeOdeljenje.Id == odeljenjeId
                                               select o;

            prodaja = proizvodi.Select(p => new ProdajeSeView(p)).ToList();

            /*foreach (ProdajeSe p in proizvodi)
            {
                ProizvodView proizvod = VratiProizvod(p.ProdajeProzivod.BarKod);
                OdeljenjeDo5View odeljenje = VratiOdeljenjeDo5(p.ProdajeOdeljenje.Id);
                prodaja.Add(new ProdajeSeView(p));
            }*/
        }
        catch (Exception)
        {
            return "Nemoguće vratiti sve proizvode na odeljenju do 5 godina sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return prodaja;
    }

    public static Result<List<ProdajeSeView>, ErrorMessage> VratiProizvodeOdeljenjaOd6Do16(int odeljenjeId)
    {
        List<ProdajeSeView> prodaja = new();

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<ProdajeSe> proizvodi = from o in s.Query<ProdajeSe>()
                                               where o.ProdajeOdeljenje != null && o.ProdajeOdeljenje.Id == odeljenjeId
                                               select o;

            foreach (ProdajeSe p in proizvodi)
            {
                var proizvod = VratiProizvod(p.ProdajeProzivod?.BarKod ?? -1);
                var odeljenje = VratiOdeljenjeOd6Do16(p.ProdajeOdeljenje?.Id ?? -1);
                prodaja.Add(new ProdajeSeView(p));
            }

            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće vratiti sve proizvode odeljenja od 6 do 15 godina sa zadatim ID-jem.".ToError(400);
        }

        return prodaja;
    }

    public static Result<List<ProdajeSeView>, ErrorMessage> VratiProizvodeOdeljenjaOdraslih(int odeljenjeId)
    {
        List<ProdajeSeView> prodaja = new();

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<ProdajeSe> proizvodi = from o in s.Query<ProdajeSe>()
                                               where o.ProdajeOdeljenje != null && o.ProdajeOdeljenje.Id == odeljenjeId
                                               select o;

            foreach (ProdajeSe p in proizvodi)
            {
                var proizvod = VratiProizvod(p.ProdajeProzivod?.BarKod ?? -1);
                var odeljenje = VratiOdeljenjeOdrasli(p.ProdajeOdeljenje?.Id ?? -1);
                prodaja.Add(new ProdajeSeView(p));
            }

            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće vratiti sve proizvode odeljenja za odrasle sa zadatim ID-jem.".ToError(400);
        }

        return prodaja;
    }

    public async static Task<Result<bool, ErrorMessage>> ObrisiProizvodAsync(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            ProdajeSe r = await s.LoadAsync<ProdajeSe>(id);

            await s.DeleteAsync(r);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati proizvod sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public static Result<ProizvodView, ErrorMessage> VratiProizvod(int id)
    {
        ProizvodView proizvodView;

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Proizvod p = s.Load<Proizvod>(id);
            proizvodView = new ProizvodView(p);

            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće vratiti proizvod sa zadatim ID-jem.".ToError(400);
        }

        return proizvodView;
    }

    public async static Task<Result<OdeljenjeDo5View, ErrorMessage>> VratiOdeljenjeDo5Async(int id)
    {
        ISession? s = null;

        OdeljenjeDo5View odeljenjeDo5View = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            OdeljenjeDo5 o = await s.LoadAsync<OdeljenjeDo5>(id);
            odeljenjeDo5View = new OdeljenjeDo5View(o);

            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće vratiti odeljenje do 5 godina sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return odeljenjeDo5View;
    }

    public static Result<OdeljenjeOd6Do16View, ErrorMessage> VratiOdeljenjeOd6Do16(int id)
    {
        OdeljenjeOd6Do16View odeljenjeOd6Do16View;

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            OdeljenjeOd6Do16 o = s.Load<OdeljenjeOd6Do16>(id);
            odeljenjeOd6Do16View = new OdeljenjeOd6Do16View(o);

            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće vratiti odeljenje od 6 do 16 godina sa zadatim ID-jem.".ToError(400);
        }

        return odeljenjeOd6Do16View;
    }

    public static Result<OdeljenjeOdrasliView, ErrorMessage> VratiOdeljenjeOdrasli(int id)
    {
        OdeljenjeOdrasliView odeljenjeOdrasliView;

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            OdeljenjeOdrasli o = s.Load<OdeljenjeOdrasli>(id);
            odeljenjeOdrasliView = new OdeljenjeOdrasliView(o);

            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće vratiti odeljenje za odrasle sa zadatim ID-jem.".ToError(400);
        }

        return odeljenjeOdrasliView;
    }

    public static Result<bool, ErrorMessage> SacuvajAutomobil(AutomobilView automobil)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Automobil a = new()
            {
                Tip = automobil.Tip,
                Naziv = automobil.Naziv,
                Proizvodjac = automobil.Proizvodjac,
                NazivSerije = automobil.NazivSerije,
                Baterije = automobil.Baterije
            };

            s.Save(a);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće sačuvati automobil.".ToError(400);
        }

        return true;
    }

    public static Result<bool, ErrorMessage> SacuvajIgrackuPlastika(IgrackaPlastikaView igracka)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IgrackaPlastika ip = new()
            {
                Tip = igracka.Tip,
                Naziv = igracka.Naziv,
                Proizvodjac = igracka.Proizvodjac,
                Uzrast = igracka.Uzrast,
                Vodootporna = igracka.Vodootporna,
                Lomljiva = igracka.Lomljiva
            };

            s.Save(ip);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće sačuvati igračku od plastike.".ToError(400);
        }

        return true;
    }

    public static Result<bool, ErrorMessage> SacuvajVojnika(VojnikView vojnik)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Vojnik v = new()
            {
                Tip = vojnik.Tip,
                Naziv = vojnik.Naziv,
                Proizvodjac = vojnik.Proizvodjac,
                NazivSerije = vojnik.NazivSerije,
                Baterije = vojnik.Baterije,
                Metal = vojnik.Metal,
                Plastika = vojnik.Plastika
            };

            s.Save(v);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;

            return "Nemoguće sačuvati vojnika.".ToError(400);
        }

        return true;
    }

    public async static Task<Result<int, ErrorMessage>> SacuvajSlagalicuAsync(SlagalicaView slagalica)
    {
        ISession? s = null;

        int id = default;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Slagalica sl = new()
            {
                Tip = slagalica.Tip,
                Naziv = slagalica.Naziv,
                Proizvodjac = slagalica.Proizvodjac,
                BrojDelova = slagalica.BrojDelova,
                Turisticka = slagalica.Turisticka,
                Umetnicka = slagalica.Umetnicka,
                Ilustracija = slagalica.Ilustracija
            };

            id = (int)await s.SaveAsync(sl);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati slagalicu.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return id;
    }

    public static Result<bool, ErrorMessage> SacuvajLutku(LutkaView lutka)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Lutka l = new()
            {
                Tip = lutka.Tip,
                Naziv = lutka.Naziv,
                Proizvodjac = lutka.Proizvodjac,
                Ime = lutka.Ime,
                Govori = lutka.Govori,
                OsetljivaDodir = lutka.OsetljivaDodir
            };

            s.Save(l);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;

            return "Nemoguće sačuvati lutku.".ToError(400);
        }

        return true;
    }

    public static Result<bool, ErrorMessage> SacuvajDodatakZaLutku(DodatakZaLutkuView dodatak)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            DodatakZaLutku dzl = new()
            {
                Tip = dodatak.Tip,
                Naziv = dodatak.Naziv,
                Proizvodjac = dodatak.Proizvodjac,
                NazivDodatka = dodatak.NazivDodatka,
                TipDodatka = dodatak.TipDodatka
            };

            s.Save(dzl);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;

            return "Nemoguće sačuvati dodatak za lutku.".ToError(400);
        }

        return true;
    }

    public static Result<IgrackaPlastikaView, ErrorMessage> VratiIgrackuPlastika(int id)
    {
        IgrackaPlastikaView igrackaPlastikaView;

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IgrackaPlastika ip = s.Load<IgrackaPlastika>(id);
            igrackaPlastikaView = new IgrackaPlastikaView(ip);

            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;

            return "Nemoguće vratiti igračku od plastike sa zadatim ID-jem.".ToError(400);
        }

        return igrackaPlastikaView;
    }

    public static Result<IgrackaPlastikaView, ErrorMessage> AzurirajIgrackuPlastika(IgrackaPlastikaView r)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IgrackaPlastika ip = s.Load<IgrackaPlastika>(r.BarKod);

            ip.Naziv = r.Naziv;
            ip.Proizvodjac = r.Proizvodjac;
            ip.Uzrast = r.Uzrast;
            ip.Vodootporna = r.Vodootporna;
            ip.Lomljiva = r.Lomljiva;

            s.Update(ip);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće ažurirati igračku od plastike.".ToError(400);
        }

        return r;
    }

    public static Result<AutomobilView, ErrorMessage> VratiAutomobil(int id)
    {
        AutomobilView automobilView;

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Automobil a = s.Load<Automobil>(id);
            automobilView = new AutomobilView(a);

            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće vratiti automobil.".ToError(400);
        }

        return automobilView;
    }

    public static Result<AutomobilView, ErrorMessage> AzurirajAutomobil(AutomobilView r)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Automobil a = s.Load<Automobil>(r.BarKod);

            a.Naziv = r.Naziv;
            a.Proizvodjac = r.Proizvodjac;
            a.NazivSerije = r.NazivSerije;
            a.Baterije = r.Baterije;

            s.Update(a);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće ažurirati automobil.".ToError(400);
        }

        return r;
    }

    public static Result<VojnikView, ErrorMessage> VratiVojnika(int id)
    {
        VojnikView vojnikView;

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Vojnik v = s.Load<Vojnik>(id);
            vojnikView = new VojnikView(v);

            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće vratiti vojnika.".ToError(400);
        }

        return vojnikView;
    }

    public static Result<VojnikView, ErrorMessage> AzurirajVojnika(VojnikView r)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Vojnik v = s.Load<Vojnik>(r.BarKod);

            v.Naziv = r.Naziv;
            v.Proizvodjac = r.Proizvodjac;
            v.NazivSerije = r.NazivSerije;
            v.Baterije = r.Baterije;
            v.Metal = r.Metal;
            v.Plastika = r.Plastika;

            s.Update(v);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće ažurirati vojnika.".ToError(400);
        }

        return r;
    }

    public static Result<LutkaView, ErrorMessage> VratiLutku(int id)
    {
        LutkaView lutkaView;

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Lutka l = s.Load<Lutka>(id);
            lutkaView = new LutkaView(l);

            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće vratiti lutku.".ToError(400);
        }

        return lutkaView;
    }

    public static Result<LutkaView, ErrorMessage> AzurirajLutku(LutkaView r)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Lutka l = s.Load<Lutka>(r.BarKod);

            l.Naziv = r.Naziv;
            l.Proizvodjac = r.Proizvodjac;
            l.Ime = r.Ime;
            l.Govori = r.Govori;
            l.OsetljivaDodir = r.OsetljivaDodir;

            s.Update(l);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće ažurirati lutku.".ToError(400);
        }

        return r;
    }

    public static Result<DodatakZaLutkuView, ErrorMessage> VratiDodatakZaLutku(int id)
    {
        DodatakZaLutkuView dodatakZaLutkuView;

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            DodatakZaLutku dzl = s.Load<DodatakZaLutku>(id);
            dodatakZaLutkuView = new DodatakZaLutkuView(dzl);

            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće vratiti dodatak za lutku.".ToError(400);
        }

        return dodatakZaLutkuView;
    }

    public static Result<DodatakZaLutkuView, ErrorMessage> AzurirajDodatakZaLutku(DodatakZaLutkuView r)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            DodatakZaLutku dzl = s.Load<DodatakZaLutku>(r.BarKod);

            dzl.Naziv = r.Naziv;
            dzl.Proizvodjac = r.Proizvodjac;
            dzl.NazivDodatka = r.NazivDodatka;
            dzl.TipDodatka = r.TipDodatka;

            s.Update(dzl);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće ažurirati dodatak za lutku.".ToError(400);
        }

        return r;
    }

    public async static Task<Result<SlagalicaView, ErrorMessage>> VratiSlagalicuAsync(int id)
    {
        ISession? s = null;

        SlagalicaView slagalicaView = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Slagalica sl = await s.LoadAsync<Slagalica>(id);
            slagalicaView = new SlagalicaView(sl);
        }
        catch (Exception)
        {
            return "Nemoguće vratiti slagalicu sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return slagalicaView;
    }

    public async static Task<Result<SlagalicaView, ErrorMessage>> AzurirajSlagalicuAsync(SlagalicaView r)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Slagalica sl = await s.LoadAsync<Slagalica>(r.BarKod);

            sl.Naziv = r.Naziv;
            sl.Proizvodjac = r.Proizvodjac;
            sl.BrojDelova = r.BrojDelova;
            sl.Turisticka = r.Turisticka;
            sl.Umetnicka = r.Umetnicka;
            sl.Ilustracija = r.Ilustracija;

            s.Update(sl);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati slagalicu.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return r;
    }

    public static Result<bool, ErrorMessage> ObrisiIgrackuIzSistema(int id)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Proizvod p = s.Load<Proizvod>(id);

            s.Delete(p);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće obrisati igračku iz sistema.".ToError(400);
        }

        return true;
    }
    #endregion

    #region ProdajeSe
    public async static Task<Result<bool, ErrorMessage>> SacuvajProdajeSeAsync(ProdajeSeView p)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            ProdajeSe a = new()
            {
                ProdajeOdeljenje = await s.LoadAsync<Odeljenje>(p.ProdajeOdeljenje?.OdeljenjeId),
                ProdajeProzivod = await s.LoadAsync<Proizvod>(p.ProdajeProzivod?.BarKod)
            };

            await s.SaveAsync(a);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati vezu proizvoda i odeljenja na kome se prodaje.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }
    #endregion
}
