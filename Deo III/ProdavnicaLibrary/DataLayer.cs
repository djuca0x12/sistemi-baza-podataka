using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace ProdavnicaLibrary;

// dotnet new <library>
// dotnet add package Nhibernate u cd ProdavnicaLibrary
//                      FluentNHibernate
//                      ManagedDataAccessCore
// DataLayer, Provider, Extensions, Imports i Entiteti kopirani iz prethodne aplikacije
// bez MessageBox-a -> logovanje grešaka (konzola ili logovanje sa bibliotekom (tako bi trebalo))

internal static class DataLayer
{
    private static ISessionFactory? _factory = null;
    private static readonly object objLock = new();

    //funkcija na zahtev otvara sesiju
    public static ISession? GetSession()
    {
        //ukoliko session factory nije kreiran
        if (_factory == null)
        {
            lock (objLock)
            {
                _factory ??= CreateSessionFactory();
            }
        }

        return _factory?.OpenSession();
    }

    //konfiguracija i kreiranje session factory
    private static ISessionFactory? CreateSessionFactory()
    {
        try
        {
            var cfg = OracleManagedDataClientConfiguration.Oracle10
                        .ShowSql()
                        .ConnectionString(c =>
                            c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=prodavnica;Password=prodavnica"));

            return Fluently.Configure()
                .Database(cfg)
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .BuildSessionFactory();
        }
        catch (Exception e)
        {
            string error = e.HandleError();
            /* Logovanje greške!
             * Console.ForegroundColor = ConsoleColor.Red;
             * Console.Error.WriteLine(error);
             * Nema potrebe, već se prikazuje identična greška.
             */
            return null;
        }
    }
}
