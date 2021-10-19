
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_1.Models
{
    public class weatherClass
    {
        public Main CheckWeather(string city)
        {
            Main result = null;
            string apiKey = "efe83d986e7db538087a0a3355daeff8";
          

            var client = new RestClient("https://api.openweathermap.org/data/2.5/weather");
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddParameter("q", city);
            request.AddParameter("appid", apiKey);
            request.AddParameter("units", "metric");
            IRestResponse response = client.Execute(request);
            result = ConvertToDictionary(response.Content);
           
            return result;
        }
        public Main ConvertToDictionary(string response)
        {
            List<string> result = new List<string>();
            WeatherRoot TheTags = JsonConvert.DeserializeObject<WeatherRoot>(response);

            return TheTags.main;
        }
    }
}

