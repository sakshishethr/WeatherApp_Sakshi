using System.Text.Json.Serialization;

namespace WeatherApp1.Models.ApiModel
{
    //API used : https://openweathermap.org/current#name
    public class WeatherApiResponseRoot
    {
        [JsonPropertyName("coord")]
        public WeatherApiResponseCoord Coord { get; set; }

        [JsonPropertyName("weather")]
        public WeatherApiResponseWeather[] Weather { get; set; }

        [JsonPropertyName("_base")]
        public string _Base { get; set; }

        [JsonPropertyName("main")]
        public WeatherApiResponseMain Main { get; set; }

        [JsonPropertyName("visibility")]
        public int Visibility { get; set; }

        [JsonPropertyName("wind")]
        public WeatherApiResponseWind Wind { get; set; }

        [JsonPropertyName("clouds")]
        public WeatherApiResponseClouds Clouds { get; set; }

        [JsonPropertyName("dt")]
        public int Dt { get; set; }

        [JsonPropertyName("sys")]
        public WeatherApiResponseSys Sys { get; set; }

        [JsonPropertyName("timezone")]
        public int Timezone { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("cod")]
        public int Cod { get; set; }
    }

    public class WeatherApiResponseCoord
    {
        [JsonPropertyName("lon")]
        public float Lon { get; set; }

        [JsonPropertyName("lat")]
        public float Lat { get; set; }
    }

    public class WeatherApiResponseMain
    {
        [JsonPropertyName("temp")]
        public float Temp { get; set; }

        [JsonPropertyName("feels_like")]
        public float Feels_like { get; set; }

        [JsonPropertyName("temp_min")]
        public float Temp_min { get; set; }

        [JsonPropertyName("temp_max")]
        public float Temp_max { get; set; }

        [JsonPropertyName("pressure")]
        public int Pressure { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }

        [JsonPropertyName("sea_level")]
        public int Sea_level { get; set; }

        [JsonPropertyName("grnd_level")]
        public int Grnd_level { get; set; }
    }

    public class WeatherApiResponseWind
    {
        [JsonPropertyName("speed")]
        public float Speed { get; set; }

        [JsonPropertyName("deg")]
        public int Deg { get; set; }

        [JsonPropertyName("gust")]
        public float Gust { get; set; }
    }

    public class WeatherApiResponseClouds
    {
        [JsonPropertyName("all")]
        public int All { get; set; }
    }

    public class WeatherApiResponseSys
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("sunrise")]
        public int Sunrise { get; set; }

        [JsonPropertyName("sunset")]
        public int Sunset { get; set; }
    }

    public class WeatherApiResponseWeather
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("main")]
        public string Main { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }

}
