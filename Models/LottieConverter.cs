using SkiaSharp.Extended.UI.Controls;
using System.Globalization;

namespace WeatherApp1.Models
{
    internal class LottieConverter
    {
        public class LottieIconConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                var code = (string)value;
                var lottieImageSource = new SKFileLottieImageSource();

                switch (code)
                {
                    case "01d":
                        lottieImageSource.File = "01d.json";
                        return lottieImageSource;
                    case "01n":
                        lottieImageSource.File = "01n.json";
                        return lottieImageSource;
                    case "02d":
                        lottieImageSource.File = "02d.json";
                        return lottieImageSource;
                    case "02n":
                        lottieImageSource.File = "02n.json";
                        return lottieImageSource;
                    case "03d":
                        lottieImageSource.File = "03d.json";
                        return lottieImageSource;
                    case "03n":
                        lottieImageSource.File = "03n.json";
                        return lottieImageSource;
                    case "04d":
                        lottieImageSource.File = "04d.json";
                        return lottieImageSource;
                    case "04n":
                        lottieImageSource.File = "04n.json";
                        return lottieImageSource;
                    case "09d":
                        lottieImageSource.File = "09d.json";
                        return lottieImageSource;
                    case "10d":
                        lottieImageSource.File = "10d.json";
                        return lottieImageSource;
                    case "11d":
                        lottieImageSource.File = "11d.json";
                        return lottieImageSource;
                    case "13d":
                        lottieImageSource.File = "13d.json";
                        return lottieImageSource;
                    case "50d":
                        lottieImageSource.File = "50d.json";
                        return lottieImageSource;
                    default:
                        return lottieImageSource.File = "09d.json";
                }
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }

    }
}
