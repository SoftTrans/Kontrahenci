using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kontrahenci.Entities
{
    public class Kursy
    {
     public int ID { get; set; }
     public virtual Tabele TABELA { get; set; }
     public virtual Waluty WALUTA { get; set; }
     public int   LOSC { get; set; }
     public double KURS { get; set; }
     public int SREDNI { get; set; }
     public int BANK { get; set; }
    }
}
