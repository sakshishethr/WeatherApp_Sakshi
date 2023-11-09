using WeatherApp1.Models.ViewModel;

namespace WeatherApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new WeatherInfoVM();
        }        
    }
}