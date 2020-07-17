using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DTD.Evaluate.Extentions
{
    public static class HttpExtentions
    {
        public static async Task<T> ReadAsAsyncJson<T>(this HttpContent content)
        {
            
            string x = await content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(x);
        }


        public static async Task<HttpResponseMessage> PostAsAsyncJson<T>(this HttpClient client, string uri, T t)
        {
          
            string json = JsonConvert.SerializeObject(t);

            HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            return await client.PostAsync(uri, httpContent);
        }


        public static async Task<HttpResponseMessage> PutAsAsyncJson<T>(this HttpClient client, string uri, T t)
        {
            string json = JsonConvert.SerializeObject(t);
            HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            return await client.PutAsync(uri, httpContent);
        }

        public static async Task<HttpStatusCode> DeleteAsAsyncJson<T>(this HttpClient client, string uri, string id)
        {
            var response = await client.DeleteAsync(uri + "/" + id);
            return response.StatusCode;

        }
    }
}
