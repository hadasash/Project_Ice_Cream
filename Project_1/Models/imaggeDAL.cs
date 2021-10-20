using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_1.Models
{
    public class imaggeDAL
    {
        public bool CheckImage(string ImageUrl)
        {
            bool result;
            string apiKey = "acc_7f32996113f74aa";
            string apiSecret = "4ac5da868fa47b900e6f6103483ef380";
            string imageUrl = ImageUrl;
            string basicAuthValue = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(String.Format("{0}:{1}", apiKey, apiSecret)));

            var client = new RestClient("https://api.imagga.com/v2/tags");
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddParameter("image_url", imageUrl);
            request.AddHeader("Authorization", String.Format("Basic {0}", basicAuthValue));

            IRestResponse response = client.Execute(request);
            result = ConvertToDictionary(response.Content);
            return result;
        }
        public bool ConvertToDictionary(string response)
        {
            List<string> result = new List<string>();
            Root TheTags = JsonConvert.DeserializeObject<Root>(response);
            foreach (Tag item in TheTags.result.tags)
            {
                if (item.tag.en == "ice cream" && item.confidence >30)
                    return true;
            }
            return false;
        }
    }
}

