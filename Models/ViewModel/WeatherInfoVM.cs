using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SkiaSharp.Extended.UI.Controls;
using System.Globalization;
using System.Net;
using WeatherApp1.Models.ApiModel;

namespace WeatherApp1.Models.ViewModel
{
    internal partial class WeatherInfoVM : ObservableObject
    {
        readonly WeatherApiService _weatherApiService;

        public WeatherInfoVM()
        {
            _weatherApiService = new WeatherApiService();
        }

        [ObservableProperty]
        string searchCity;

        [ObservableProperty]
        SKFileLottieImageSource weatherIcon;

        [ObservableProperty]
        string temperature;

        [ObservableProperty]
        string weatherName;

        [ObservableProperty]
        string location;

        [ObservableProperty]
        string wind;

        [ObservableProperty]
        string humidity;

        [ObservableProperty]
        string minTemp;
        [ObservableProperty]
        string maxTemp;

        [RelayCommand]
        async Task FetchWeatherInfo()
        {
            try
            {
                var weatherApiResponse = await _weatherApiService.GetWeatherInfo(SearchCity);

                if (weatherApiResponse != null)
                {
                    //get all the necessary data to be binded: the icon, weather desc, temp, location, humdiity, wind speed, min-max temp

                    string getIcon = weatherApiResponse.Weather[0].Icon;
                    LottieConverter.LottieIconConverter lottieConverter = new LottieConverter.LottieIconConverter();
                    var lottieImageSource = (SKFileLottieImageSource)lottieConverter.Convert(getIcon, typeof(SKFileLottieImageSource), null, CultureInfo.CurrentCulture);
                    WeatherIcon = lottieImageSource;

                    WeatherName = weatherApiResponse.Weather[0].Description;
                    WeatherName = char.ToUpper(WeatherName[0]) + WeatherName.Substring(1);

                    Temperature = $"{Math.Round(weatherApiResponse.Main.Temp)}°C";

                    Location = $"{weatherApiResponse.Name}, {weatherApiResponse.Sys.Country}";

                    Wind = $"{weatherApiResponse.Wind.Speed} km/h";

                    Humidity = $"{weatherApiResponse.Main.Humidity}%";

                    MinTemp = $"{Math.Round(weatherApiResponse.Main.Temp_min)}°C";
                    MaxTemp = $"{Math.Round(weatherApiResponse.Main.Temp_max)}°C";
                }
            }
            catch (WebException ex)
                {
                    // Handle the exception, log the error, or display an error message
                    Console.WriteLine("WebException: " + ex.Message);
                }
            
        }
    }
}
