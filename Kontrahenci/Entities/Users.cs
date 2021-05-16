using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kontrahenci.Entities
{
    public class Users
    {
     public int ID { get; set; }
     public string LOGIN { get; set; }
     public string IMIE { get; set; }
     public string NAZWISKO { get; set; }
     public int  VISIBLE { get; set; }
     public string EMAIL { get; set; }
     public int LOCK { get; set; }
     public DateTime PASSCHANGED { get; set; }
     public string  PASS { get; set; }
     public int IDGRUPA { get; set; }     
    public string  PASSODKOD { get; set; }
    public string  PASSOLD { get; set; }
    }
}
