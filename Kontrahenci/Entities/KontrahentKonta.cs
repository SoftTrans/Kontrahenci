using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kontrahenci.Entities
{
    public class KontrahentKonta
    {
    public int ID { get; set; }
    public int ID_KONTRAHENTA { get; set; }
    public string NAZWA { get; set; }
    public string NUMER { get; set; }
    public string OPIS { get; set; }
    public string RACHUNEK1 { get; set; }
    public string RACHUNEK2 { get; set; }
    public int AKTYWNE { get; set; }
    public string SWITH { get; set; }
    public int DOMYSLNE { get; set; }
    public virtual Waluty  WALUTA { get; set; }
    public string EMAIL { get; set; }         // adres do wysłania faktury 
    public virtual Kontrahenci KONTRAHENT { get; set; }
    }
}
