﻿using Hamburgerci.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Entities.Concrete
{
    public class Kullanici:BaseEntity
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

    }
}
