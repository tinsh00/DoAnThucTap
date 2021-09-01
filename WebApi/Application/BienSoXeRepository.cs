using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Application
{
    public class BienSoXeRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;
        public BienSoXeRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost:6393/");
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }



    }
}
