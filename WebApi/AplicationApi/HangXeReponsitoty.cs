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
    class HangXeReponsitoty
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public HangXeReponsitoty()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://127.0.0.1:5000/");
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<List<HangXe>> GetList()
        {
            _response = await _client.GetAsync($"api/getHangXe");

            var json = await _response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<List<HangXe>>(json);
            MessageBox.Show(list.ToString());
            return list;

        }
        public void Add(HangXe hang)
        {
            var H= JsonConvert.SerializeObject(hang);
            //MessageBox.Show(U.ToString(), "", MessageBoxButtons.OK);
            var buffer = Encoding.UTF8.GetBytes(H);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PostAsync("/api/postHangXe", byteContent);
        }



        public void Delete(HangXe hang)
        {
            var H = JsonConvert.SerializeObject(hang);
            var buffer = Encoding.UTF8.GetBytes(H);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PostAsync($"/api/deleteHangXe", byteContent);

        }
        //public async Task<CarUser> Get(int id)
        //{
        //    _response = await _client.GetAsync($"api/biensoxe/select");

        //    var json = await _response.Content.ReadAsStringAsync();
        //    var listUser = JsonConvert.DeserializeObject<CarUser>(json);
        //    return listUser;
        //}
        public void Update(HangXe hang)
        {
            var H = JsonConvert.SerializeObject(hang);
            var buffer = Encoding.UTF8.GetBytes(H);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PostAsync($"/api/updateHangXe", byteContent);
        }
    }
}
