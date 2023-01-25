using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Entities.Abstract
{
    public class BaseEntity
    {
        public int Id { get; set; }

		private DateTime _CreateDate=DateTime.Now;

		public DateTime CreateDate
		{
			get { return _CreateDate; }
			set { _CreateDate= value; }
		}


	}
}
