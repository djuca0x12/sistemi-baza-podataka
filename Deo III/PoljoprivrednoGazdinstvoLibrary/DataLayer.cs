using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
//using PoljoprivrednoGazdinstvoLibrary.Mapiranja;

namespace PoljoprivrednoGazdinstvoLibrary
{
    public class DataLayer
    {
        private static ISessionFactory _factory = null;
        private static object objLock = new object();


        // Funkcija na zahtev otvara sesiju
        public static ISession GetSession()
        {
            //ukoliko session factory nije kreiran
            if (_factory == null)
            {
                lock (objLock)
                {
                    if (_factory == null)
                        _factory = CreateSessionFactory();
                }
            }

            return _factory.OpenSession();
        }

        // Konfiguracija i kreiranje session factory
        private static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var cfg = OracleManagedDataClientConfiguration.Oracle10
                .ShowSql()
                .ConnectionString(c =>
                    c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S19853;Password=ceganapravimo"));

                return Fluently.Configure()
                    .Database(cfg)
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<MehanizacijaMapiranja>())
                    .BuildSessionFactory();
            }
            catch (Exception ec)
            {
                if (ec.InnerException != null)
                {
                    //MessageBox.Show("Stvarna greška: " + ec.InnerException.Message);
                }
                else
                {
                    //MessageBox.Show("Glavna greška: " + ec.Message);
                }
                return null;
            }

        }
    }
}
