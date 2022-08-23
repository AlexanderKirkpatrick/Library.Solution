using System.Collections.Generic;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Library.Models
{
  public class BestSeller
  {
    public string Title { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }

    public static List<BestSeller> GetBestSellers(string apiKey)
    {
      var apiCallTask = ApiHelper.ApiCall(apiKey);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<BestSeller> bestSellerList = JsonConvert.DeserializeObject<List<BestSeller>>(jsonResponse["results"].ToString());

      return bestSellerList;

    }
  }
}