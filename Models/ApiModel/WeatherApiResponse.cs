using System.Text.Json.Serialization;

namespace WeatherApp1.Models.ApiModel
{
    // Root class representing the entire JSON response from OpenWeatherMap API.
    public class WeatherApiResponseRoot
    {
        // Coordinate object containing longitude and latitude.
        [JsonPropertyName("coord")]
        public WeatherApiResponseCoord Coord { get; set; }

        // Array of weather conditions (id, main, description, icon).
        [JsonPropertyName("weather")]
        public WeatherApiResponseWeather[] Weather { get; set; }

        // Internal parameter from the API (not typically used).
        [JsonPropertyName("_base")]
        public string _Base { get; set; }

        // Main weather information like temperature, pressure, humidity, etc.
        [JsonPropertyName("main")]
        public WeatherApiResponseMain Main { get; set; }

        // Visibility, measured in meters.
        [JsonPropertyName("visibility")]
        public int Visibility { get; set; }

        // Wind information including speed and direction.
        [JsonPropertyName("wind")]
        public WeatherApiResponseWind Wind { get; set; }

        // Cloudiness information.
        [JsonPropertyName("clouds")]
        public WeatherApiResponseClouds Clouds { get; set; }

        // Time of data calculation, unix, UTC.
        [JsonPropertyName("dt")]
        public int Dt { get; set; }

        // System data like country, sunrise and sunset times.
        [JsonPropertyName("sys")]
        public WeatherApiResponseSys Sys { get; set; }

        // Shift in seconds from UTC.
        [JsonPropertyName("timezone")]
        public int Timezone { get; set; }

        // City ID.
        [JsonPropertyName("id")]
        public int Id { get; set; }

        // City name.
        [JsonPropertyName("name")]
        public string Name { get; set; }

        // API status code.
        [JsonPropertyName("cod")]
        public int Cod { get; set; }
    }

    // Represents geographic coordinates.
    public class WeatherApiResponseCoord
    {
        // Longitude.
        [JsonPropertyName("lon")]
        public float Lon { get; set; }

        // Latitude.
        [JsonPropertyName("lat")]
        public float Lat { get; set; }
    }

    // Main weather data like temperature, pressure, humidity.
    public class WeatherApiResponseMain
    {
        // Current temperature.
        [JsonPropertyName("temp")]
        public float Temp { get; set; }

        // Human perception of weather.
        [JsonPropertyName("feels_like")]
        public float Feels_like { get; set; }

        // Minimum temperature at the moment.
        [JsonPropertyName("temp_min")]
        public float Temp_min { get; set; }

        // Maximum temperature at the moment.
        [JsonPropertyName("temp_max")]
        public float Temp_max { get; set; }

        // Atmospheric pressure.
        [JsonPropertyName("pressure")]
        public int Pressure { get; set; }

        // Humidity percentage.
        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }

        // Sea level pressure.
        [JsonPropertyName("sea_level")]
        public int Sea_level { get; set; }

        // Ground level pressure.
        [JsonPropertyName("grnd_level")]
        public int Grnd_level { get; set; }
    }

    // Wind information including speed and direction.
    public class WeatherApiResponseWind
    {
        // Wind speed.
        [JsonPropertyName("speed")]
        public float Speed { get; set; }

        // Wind direction, degrees.
        [JsonPropertyName("deg")]
        public int Deg { get; set; }

        // Wind gust speed.
        [JsonPropertyName("gust")]
        public float Gust { get; set; }
    }

    // Cloudiness information.
    public class WeatherApiResponseClouds
    {
        // Cloudiness percentage.
        [JsonPropertyName("all")]
        public int All { get; set; }
    }

    // System data like country, sunrise and sunset time.
    public class WeatherApiResponseSys
    {
        // Country code.
        [JsonPropertyName("country")]
        public string Country { get; set; }

        // Sunrise time, unix, UTC.
        [JsonPropertyName("sunrise")]
        public int Sunrise { get; set; }

        // Sunset time, unix, UTC.
        [JsonPropertyName("sunset")]
        public int Sunset { get; set; }
    }

    // Weather condition information.
    public class WeatherApiResponseWeather
    {
        // Weather condition id.
        [JsonPropertyName("id")]
        public int Id { get; set; }

        // Group of weather parameters (Rain, Snow, Extreme, etc.).
        [JsonPropertyName("main")]
        public string Main { get; set; }

        // Weather condition within the group.
        [JsonPropertyName("description")]
        public string Description { get; set; }

        // Weather icon id.
        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }
}
