using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class BienSoXeController : ApiController
    {
        BienSoXe[] biensoxes = new BienSoXe[]
        {
         
        };

        public IEnumerable<BienSoXe> GetAllBSX()
        {
            return biensoxes;
        }
        public IHttpActionResult GetBSX(int id)
        {
            var biensoxe = biensoxes.FirstOrDefault((p) => p.ID == id);
            if (biensoxe == null)
            {
                return NotFound();
            }
            return Ok(biensoxe);
        }
    }
}
