using Hamburgerci.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Entities.Concrete
{
    public class Extra:BaseEntity
    {
        public string ExtraAdi { get; set; }

        public double Fiyat { get; set; }
    }
}
