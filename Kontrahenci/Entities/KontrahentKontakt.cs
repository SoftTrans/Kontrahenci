using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kontrahenci.Entities
{
    public class KontrahentKontakt
    {
      public int ID { get; set; }
      public int ID_KONTRAHENTA { get; set; }
      public string NAZWISKO { get; set; }
      public string IMIE { get; set; }
      public string STANOWISKO { get; set; }
      public string  TEL { get; set; }
      public string TEL1 { get; set; }
      public string EMAIL { get; set; }
      public string UWAGI { get; set; }
     public virtual Kontrahenci KONTRAHENT { get; set; }
    }
}
