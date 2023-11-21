using Newtonsoft.Json;
using NewsApp.Models;

namespace NewsApp.Services;

public class ApiService
{
	public async Task<Root> GetNews(string categoryName)
	{
		var httpClient = new HttpClient();
		var response = await httpClient.GetStringAsync($"https://gnews.io/api/v4/top-headlines?country=tw&category={categoryName.ToLower()}&apikey=49825f404f25f86ed3ca14139b42b8fb");
		return JsonConvert.DeserializeObject<Root>(response);
	}
}