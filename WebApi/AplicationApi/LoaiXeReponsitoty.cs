using AplicationApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AplicationApi
{
    class LoaiXeReponsitoty
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public LoaiXeReponsitoty()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://127.0.0.1:5000/");
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<List<LoaiXe>> GetList()
        {
            _response = await _client.GetAsync($"api/getLoaiXe");

            var json = await _response.Content.ReadAsStringAsync();
            var listUser = JsonConvert.DeserializeObject<List<LoaiXe>>(json);

            return listUser;

        }
        public void Add(LoaiXe loai)
        {
            var L = JsonConvert.SerializeObject(loai);
            //MessageBox.Show(U.ToString(), "", MessageBoxButtons.OK);
            var buffer = Encoding.UTF8.GetBytes(L);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PostAsync("/api/postLoaiXe", byteContent);
        }



        public void Delete(LoaiXe loai)
        {
            var L = JsonConvert.SerializeObject(loai);
            var buffer = Encoding.UTF8.GetBytes(L);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PostAsync($"/api/deleteLoaiXe", byteContent);

        }
        //public async Task<CarUser> Get(int id)
        //{
        //    _response = await _client.GetAsync($"api/biensoxe/select");

        //    var json = await _response.Content.ReadAsStringAsync();
        //    var listUser = JsonConvert.DeserializeObject<CarUser>(json);
        //    return listUser;
        //}
        public void Update(LoaiXe loai)
        {
            var L = JsonConvert.SerializeObject(loai);
            var buffer = Encoding.UTF8.GetBytes(L);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PostAsync($"/api/updateLoaiXe", byteContent);
        }
    }
}
