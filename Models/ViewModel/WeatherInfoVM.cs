using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SkiaSharp.Extended.UI.Controls;
using System.Globalization;
using System.Net;
using WeatherApp1.Models.ApiModel;

namespace WeatherApp1.Models.ViewModel
{
    // ObservableObject allows property change notifications, a key aspect of MVVM.
    internal partial class WeatherInfoVM : ObservableObject
    {
        // Service for fetching weather data.
        readonly WeatherApiService _weatherApiService;

        // Constructor initializing the WeatherApiService.
        public WeatherInfoVM()
        {
            _weatherApiService = new WeatherApiService();
        }

        // Properties bound to the UI. ObservableProperty attribute automatically implements INotifyPropertyChanged.
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

        // RelayCommand attribute creates a command that can be bound to a UI element.
        [RelayCommand]
        async Task FetchWeatherInfo()
        {
            try
            {
                // Asynchronously fetch weather data for the specified city.
                var weatherApiResponse = await _weatherApiService.GetWeatherInfo(SearchCity);

                if (weatherApiResponse != null)
                {
                    // Extracting and formatting data from the response to update the UI.
                    string getIcon = weatherApiResponse.Weather[0].Icon;
                    LottieConverter.LottieIconConverter lottieConverter = new LottieConverter.LottieIconConverter();
                    var lottieImageSource = (SKFileLottieImageSource)lottieConverter.Convert(getIcon, typeof(SKFileLottieImageSource), null, CultureInfo.CurrentCulture);
                    WeatherIcon = lottieImageSource;

                    WeatherName = weatherApiResponse.Weather[0].Description;
                    // Capitalizing the first letter of the weather description.
                    WeatherName = char.ToUpper(WeatherName[0]) + WeatherName.Substring(1);

                    // Displaying temperature in Celsius.
                    Temperature = $"{Math.Round(weatherApiResponse.Main.Temp)}°C";

                    // Formatting location display.
                    Location = $"{weatherApiResponse.Name}, {weatherApiResponse.Sys.Country}";

                    // Displaying wind speed in km/h.
                    Wind = $"{weatherApiResponse.Wind.Speed} km/h";

                    // Displaying humidity percentage.
                    Humidity = $"{weatherApiResponse.Main.Humidity}%";

                    // Displaying minimum and maximum temperatures.
                    MinTemp = $"{Math.Round(weatherApiResponse.Main.Temp_min)}°C";
                    MaxTemp = $"{Math.Round(weatherApiResponse.Main.Temp_max)}°C";
                }
            }
            catch (WebException ex)
            {
                // Handling exceptions related to web requests.
                Console.WriteLine("WebException: " + ex.Message);
            }
        }
    }
}
