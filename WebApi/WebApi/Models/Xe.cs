using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Xe
    {
        public int ID { get; set; }
        public int IDUser { get; set; }
        public int IDHang { get; set; }
        public int IDLoai { get; set; }
        public String SoXe { get; set; }
        public String MauXe { get; set; }
        
    }
}