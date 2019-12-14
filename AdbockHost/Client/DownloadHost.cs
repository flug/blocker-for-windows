using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AdbockHost.Client
{
    

    class DownloadHost
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task<string> GetDomains(string urlHostFile)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpResponseMessage response = await client.GetAsync(urlHostFile);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);
                return responseBody; 

             
            }
            catch (HttpRequestException e)
            {
                return null; 
                 
            }
        }
    }
}
