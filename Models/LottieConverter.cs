using SkiaSharp.Extended.UI.Controls;
using System.Globalization;

namespace WeatherApp1.Models
{
    // LottieConverter contains the LottieIconConverter class.
    internal class LottieConverter
    {
        // LottieIconConverter converts weather icon codes to corresponding Lottie animations.
        public class LottieIconConverter : IValueConverter
        {
            // Convert method maps the weather icon code to a Lottie file.
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                var code = (string)value;
                var lottieImageSource = new SKFileLottieImageSource();

                // Depending on the icon code from the API, it selects a corresponding Lottie file.
                switch (code)
                {
                    case "01d": lottieImageSource.File = "01d.json"; break;
                    case "01n": lottieImageSource.File = "01n.json"; break;
                    case "02d": lottieImageSource.File = "02d.json"; break;
                    case "02n": lottieImageSource.File = "02n.json"; break;
                    case "03d": lottieImageSource.File = "03d.json"; break;
                    case "03n": lottieImageSource.File = "03n.json"; break;
                    case "04d": lottieImageSource.File = "04d.json"; break;
                    case "04n": lottieImageSource.File = "04n.json"; break;
                    case "09d": lottieImageSource.File = "09d.json"; break;
                    case "10d": lottieImageSource.File = "10d.json"; break;
                    case "11d": lottieImageSource.File = "11d.json"; break;
                    case "13d": lottieImageSource.File = "13d.json"; break;
                    case "50d": lottieImageSource.File = "50d.json"; break;
                    default: lottieImageSource.File = "default.json"; break; // Default case for any unidentified codes.
                }

                return lottieImageSource;
            }

            // ConvertBack method is not implemented as it's not needed in this context.
            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }
    }
}
