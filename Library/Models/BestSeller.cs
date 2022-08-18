using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Library.Models
{
  public class BestSeller
  {
    public string Book_Title { get; set; }
    public string Book_Author { get; set; }
    public string Publication_Dt { get; set; }
    public string Summary { get; set; }
    public string Url { get; set; }

    public static List<BestSeller> GetBestSellers(string query, string type)
    {
      var apiCallTask = ApiHelper.ApiCall(query, type);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<BestSeller> BestSellerList = JsonConvert.DeserializeObject<List<BestSeller>>(jsonResponse["results"].ToString());

      return BestSellerList;

    }
  }
}