using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace MetalArchivesSearcher
{
    public class DataScraper
    {
        public async Task<bool> DoesExist(string bandName, int limitAmount = 1)
        {
            var httpClient = new HttpClient();
            var request =
                await httpClient.GetStringAsync(
                    $"https://www.metal-archives.com/search/ajax-band-search/?field=name&query={bandName}");
            if (request == "0")
            {
                Thread.Sleep(500*limitAmount);
                return await DoesExist(bandName, limitAmount+1);
            }

            var parsedData = JObject.Parse(request);
            return parsedData["iTotalRecords"].ToObject<int>() > 0;
        }
    }
}