using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kontrahenci.Entities
{
    public class Kontrahenci
    {

        int ID { get; set; }           //  ID_KONTRAHENTA INTEGER NOT NULL,
        public string SKROT { get; set; }
        public string NAZWA { get; set; }
        public string NIP { get; set; }
        public string ADRES { get; set; }
        public string MIEJSCOWOSC { get; set; }
        public string WOJEWODZTWO { get; set; }
        public virtual Kraje KRAJ { get; set; }
        public string UWAGI { get; set; }
        public virtual KontrahentPlatnosc RODZAJ_PLATNOSCI { get; set; }
        public int PLATNOSC_DNI { get; set; }
        public int AKTYWNY { get; set; }
        public string KOD { get; set; }
        public string REGON { get; set; }
        public int NR_IDENT { get; set; }
        public double LIMIT_KREDYTOWY { get; set; }
        public virtual Waluty WALUTA { get; set; }
        public List<KontrahentKonta> KONTA { get; set; }
        public List<KontrahentKontakt> KONTAKTY { get; set; }
        public virtual KontrahentKonta DEFAULTKONTO { get; set; }
        public string TELEFON { get; set; }
        public int STATUS { get; set; }
        public string OSOBA { get; set; }
        public string FAX { get; set; }
        public string WWW { get; set; }
        public string EMAIL { get; set; }
        public DateTime DATA_WPISU { get; set; }
        public string OSOBAKONTRAHENT { get; set; }
        public string UWAGI1 { get; set; }
        public string UWAGI2 { get; set; }
        public DateTime KRD_DATA { get; set; }
        public DateTime DATA_ZMIANY { get; set; }
        public virtual Users USER_ { get; set; }
        public List<KontrahentZdarzenia> ZDARZENIA {get;set;}
        public virtual KontrahentCharakter CHARAKTER { get; set; }
        public virtual Users POZYSKUJACY { get; set; }
    }
}
