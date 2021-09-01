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
    public class XeTheoNgayReponsitory
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public XeTheoNgayReponsitory()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://127.0.0.1:5000/");
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<List<XeTheoNgay>> GetList()
        {
            _response = await _client.GetAsync($"api/getBSX");

            var json = await _response.Content.ReadAsStringAsync();
            MessageBox.Show(json.ToString());
            var listBSX = JsonConvert.DeserializeObject<List<XeTheoNgay>>(json);
            
            return listBSX;

        }
        public void Add(XeTheoNgay bienso)
        {
            var bienSo = JsonConvert.SerializeObject(bienso);
            MessageBox.Show(bienSo.ToString(), "", MessageBoxButtons.OK);
            var buffer = Encoding.UTF8.GetBytes(bienSo);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PostAsync("api/post", byteContent);
        }



        public void Delete(XeTheoNgay bienso)
        {
			var bienSo = JsonConvert.SerializeObject(bienso);
			var buffer = Encoding.UTF8.GetBytes(bienSo);
			var byteContent = new ByteArrayContent(buffer);
			byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
			_client.PostAsync($"api/post/delete", byteContent);

		}
        public async Task<XeTheoNgay> Get(int id)
        {
            _response = await _client.GetAsync($"api/biensoxe/select");

            var json = await _response.Content.ReadAsStringAsync();
            var listBSX = JsonConvert.DeserializeObject<XeTheoNgay>(json);
            return listBSX;
        }
        public void Update(XeTheoNgay bienso)
        {
            var bienSo = JsonConvert.SerializeObject(bienso);
            var buffer = Encoding.UTF8.GetBytes(bienSo);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PostAsync($"api/post/update", byteContent);
        }
    }
  
}
