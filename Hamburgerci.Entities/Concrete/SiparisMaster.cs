using Hamburgerci.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Entities.Concrete
{
    public class SiparisMaster:BaseEntity
    {
        public Kullanici Kullanici { get; set; }

        public ICollection<SiparisDetay> SiparisDetaylari { get; set; }
    }
}
