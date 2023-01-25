using Hamburgerci.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Entities.Concrete
{
    public enum Boyut:byte
    {
        Kucuk=1,
        Orta,
        Buyuk

    }

    public class Menu:BaseEntity
    {
        public string MenuAdi { get; set; }
        public Boyut Boyut { get; set; }
        public double Fiyat { get; set; }

    }
}
