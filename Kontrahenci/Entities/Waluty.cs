using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kontrahenci.Entities
{
    public class Waluty
    {
        public int ID {get; set;}
        public virtual Kraje  KRAJ { get; set; }
        public string SYMBOL { get; set; }
        public string NAZWA { get; set; }
        public int  DEF_ILOSC { get; set; }

    }
}
