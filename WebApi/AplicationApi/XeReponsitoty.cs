using AplicationApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicationApi
{
    class XeReponsitoty
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public XeReponsitoty()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://127.0.0.1:5000/");
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<List<Xe>> GetList()
        {
            _response = await _client.GetAsync($"api/getXe");

            var json = await _response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<List<Xe>>(json);
            MessageBox.Show(list.ToString());
            return list;

        }
        public void Add(Xe xe)
        {
            var X = JsonConvert.SerializeObject(xe);
            //MessageBox.Show(U.ToString(), "", MessageBoxButtons.OK);
            var buffer = Encoding.UTF8.GetBytes(X);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PostAsync("/api/postXe", byteContent);
        }



        public void Delete(Xe xe)
        {
            var X = JsonConvert.SerializeObject(xe);
            var buffer = Encoding.UTF8.GetBytes(X);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PostAsync($"/api/deleteXe", byteContent);

        }
        //public async Task<CarUser> Get(int id)
        //{
        //    _response = await _client.GetAsync($"api/biensoxe/select");

        //    var json = await _response.Content.ReadAsStringAsync();
        //    var listUser = JsonConvert.DeserializeObject<CarUser>(json);
        //    return listUser;
        //}
        public void Update(Xe xe)
        {
            var X = JsonConvert.SerializeObject(xe);
            var buffer = Encoding.UTF8.GetBytes(X);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PostAsync($"/api/updateXe", byteContent);
        }
    }
}
