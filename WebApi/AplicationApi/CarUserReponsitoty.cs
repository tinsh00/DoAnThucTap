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
    class CarUserReponsitoty
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public CarUserReponsitoty()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://127.0.0.1:5000/");
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        //[AllowAnonymous]
        public async Task<List<CarUser>> GetList()
        {
            _response = await _client.GetAsync($"api/getAllUser");
            //var data =_response.Content.ReadAsStringAsync().Result;
            //var listUser = new List<CarUser>();
            //JsonConvert.PopulateObject(data.ToString(), listUser);
            var json = await _response.Content.ReadAsStringAsync();
            //MessageBox.Show(json.ToString());
            var listUser = JsonConvert.DeserializeObject<List<CarUser>>(json);
            //MessageBox.Show(listUser.ToString());
            return listUser;

        }
        public void Add(CarUser user)
        {
            var U = JsonConvert.SerializeObject(user);
            //MessageBox.Show(U.ToString(), "", MessageBoxButtons.OK);
            var buffer = Encoding.UTF8.GetBytes(U);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PostAsync("api/postUser", byteContent);
        }



        public void Delete(CarUser user)
        {
            var User = JsonConvert.SerializeObject(user);
            var buffer = Encoding.UTF8.GetBytes(User);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PostAsync($"api/post/deleteUser", byteContent);

        }
        public async Task<CarUser> Get(int id)
        {
            _response = await _client.GetAsync($"api/biensoxe/select");

            var json = await _response.Content.ReadAsStringAsync();
            var listUser = JsonConvert.DeserializeObject<CarUser>(json);
            return listUser;
        }
        public void Update(CarUser user)
        {
            var User = JsonConvert.SerializeObject(user);
            var buffer = Encoding.UTF8.GetBytes(User);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PostAsync($"api/post/updateUser", byteContent);
        }
    }
}
