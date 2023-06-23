using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GE_C
{
    public class GE_Requests
    {
        public GE_Endpoints endpoints = new GE_Endpoints();
        public async Task<dynamic> Login(string username, string password)
        {

            // JSON Format
            var json = "{ \"corp_id\": \"1007d2ad150c4000\", \"email\": " + $"{username}" + ", \"password\": " + $"{password}" + "}";

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(endpoints.LoginURL()),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            // Builds Request
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (platform; rv:geckoversion) Gecko/geckotrail Firefox/firefoxversion");
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            // Get JSON Data
            string content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<dynamic>(content);
        }









    }
}
