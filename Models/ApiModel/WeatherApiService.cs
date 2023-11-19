using System.Net.Http.Json;

namespace WeatherApp1.Models.ApiModel
{
    // Class responsible for handling API requests to fetch weather data.
    internal class WeatherApiService
    {
        // HttpClient instance used to make HTTP requests.
        private readonly HttpClient _httpClient;

        // Constructor initializes the HttpClient with the base URL of the API.
        public WeatherApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Constants.API_BASE_URL);
        }

        // Asynchronously retrieves weather information for a specified city.
        public async Task<WeatherApiResponseRoot> GetWeatherInfo(string city)
        {
            // Check for internet connectivity before making a request.
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
                return null; // Returns null if there's no internet connection.

            // Asynchronously gets weather data from the API and deserializes the JSON response into WeatherApiResponseRoot object.
            return await _httpClient.GetFromJsonAsync<WeatherApiResponseRoot>($"data/2.5/weather?q={city}&units=metric&appid={Constants.API_KEY}");
        }
    }
}
