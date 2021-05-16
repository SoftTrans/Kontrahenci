using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kontrahenci.Entities
{
    public class KontrahentCharakter
    {
     public int ID { get; set; }
     public string  OPIS { get; set; }
     public List<Kontrahenci> KONTRAHENCI_L { get; set; }
    }
}
