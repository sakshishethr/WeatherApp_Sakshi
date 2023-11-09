using System.Net.Http.Json;

namespace WeatherApp1.Models.ApiModel
{
    internal class WeatherApiService
    {
        private readonly HttpClient _httpClient;
        public WeatherApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Constants.API_BASE_URL);
        }

        public async Task<WeatherApiResponseRoot> GetWeatherInfo(string city)
        {
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
                return null;

            return await _httpClient.GetFromJsonAsync<WeatherApiResponseRoot>($"data/2.5/weather?q={city}&units=metric&appid={Constants.API_KEY}");
        }
    }
}
