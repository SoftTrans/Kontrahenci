using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kontrahenci.Entities
{
    public class Kraje
    {
     public int ID { get; set; }
     public string SYMBOL { get; set; }
     public string NAZWA { get; set; }
     public string HTTPSTRING { get; set; }
     public string KOD_POCZTOWY_MASKA { get; set; }
     public virtual Waluty WALUTA { get; set; }
    }
}
