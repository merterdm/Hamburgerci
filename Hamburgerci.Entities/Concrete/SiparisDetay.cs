using Hamburgerci.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Entities.Concrete
{
    public class SiparisDetay:BaseEntity
    {
        public int SiparisMasterID { get; set; }
        public SiparisMaster SiparisMaster { get; set; } // Burasi database'e yansimaz

        public Menu Menu { get; set; }
        public double Adet { get; set; }

        public ICollection<Extra> Extralar { get; set; }
        
        [NotMapped]
        public double ToplamFiyat { get; set; }

    }
}
