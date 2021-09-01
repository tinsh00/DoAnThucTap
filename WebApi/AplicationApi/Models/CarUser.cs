using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicationApi.Models
{
    public class CarUser
    {
        public int ID { get; set; }
        public String HoTen { get; set; }
        public String GioiTinh { get; set; }
        public String NgaySinh { get; set; }
        public String SDT { get; set; }
        public String Email { get; set; }
        public String NgayDK { get; set; }
        public int TrangThai { get; set; }
    }
}