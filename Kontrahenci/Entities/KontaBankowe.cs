using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kontrahenci.Entities
{
    public class KontaBankowe
    {
     public int ID { get; set; }
     public string  BANK { get; set; }
     public string RACHUNEK { get; set; }
     public string OPIS { get; set; }
    public int DEFAULT_KONTO { get; set; }
    public virtual Waluty WALUTA { get; set; }
    public string RACHUNEK1 { get; set; }
    public string RACHUNEK2 { get; set; }
    public int AKTYWNE  { get; set; }
    public string  SWITH { get; set; }

}
}
