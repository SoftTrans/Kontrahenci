using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kontrahenci.Entities
{
    public class KontrahentZdarzenia
    {
     public int ID { get; set; }
     public virtual Kontrahenci KONTRAHENT { get; set; }
     public DateTime DATA { get; set; }
     public string UWAGI { get; set; }
     public int RODZAJ { get; set; }
     public DateTime DATA_ALARM { get; set; }
     public string UWAGI1 { get; set; }
     public virtual KontrahentKontakt KONTAKT  { get; set; }
     public virtual Users USER { get; set; }
     public int IDKALENDARZ { get; set; }
     public int DOTYCZY { get; set; }
    }
}
