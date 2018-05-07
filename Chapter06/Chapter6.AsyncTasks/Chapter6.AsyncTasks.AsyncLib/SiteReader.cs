using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Chapter6.AsyncTasks.AsyncLib
{
    public class SiteReader
    {
        private HttpClient _httpClient = new HttpClient();

        public async Task<string> ReadSiteContent(string url)
        {
            var htmlContent = await _httpClient.GetStringAsync(url);

            return htmlContent;
        }
    }
}
