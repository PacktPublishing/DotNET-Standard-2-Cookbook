using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Chapter7.RestAPI.RestLib
{
    public class PostsReader
    {
        private string _serviceURL;

        public PostsReader(string serviceURL)
        {
            _serviceURL = serviceURL;
        }

        public async Task<string> GetPostById(int id)
        {
            string output; 

            using (var httpClient = new HttpClient())
            {
                Uri uri = new Uri($"{_serviceURL}/posts/{id}");

                using (HttpResponseMessage response = await httpClient.GetAsync(uri))
                {
                    output = await response.Content.ReadAsStringAsync();
                }

            }

            return output;
        }
    }
}
