using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicationApi.Models
{
    public class BienSoXe
    {
        public int ID { get; set; }
        public String BienSo { get; set; }
        public DateTime date { get; set; }
		public int TrangThai { get; set; }
	}
}