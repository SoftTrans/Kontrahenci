using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kontrahenci.Entities
{
    public class Tabele
    {
     public int ID { get; set; }
     public string NUMER { get; set; }
     public DateTime  Z_DNIA { get; set; }
     public int BANK  { get; set; }  // ID=0 nbp
     public int SREDNI { get; set; }  // 0 SREDNI, 1 SPRZEDAZY, 2 ZAKUPU

    }
}
