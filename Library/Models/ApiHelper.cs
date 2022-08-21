using System.Threading.Tasks;
using RestSharp;

namespace Library.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall(string apiKey)
    {
      RestClient client = new RestClient("https://api.nytimes.com/svc/books/v3");
      RestRequest request = new RestRequest($"lists/current/overview.json?api-key={apiKey}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}