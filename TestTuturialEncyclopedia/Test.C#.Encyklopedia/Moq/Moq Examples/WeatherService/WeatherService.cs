namespace TestTuturialEncyclopedia.Test.C_.Encyklopedia.Moq.Moq_Examples.WeatherService;

public interface IWeatherProvider
{
    string GetCurrentWeather(string city);
}

public class WeatherService
{
    private readonly IWeatherProvider _weatherProvider;

    public WeatherService(IWeatherProvider weatherProvider)
    {
        _weatherProvider = weatherProvider;
    }

    public string GetWeatherMessage(string city)
    {
        var weather = _weatherProvider.GetCurrentWeather(city);
        if (weather == "Sunny")
        {
            return "It's a beautiful day!";
        }
        else if (weather == "Rainy")
        {
            return "Don't forget your umbrella.";
        }
        else
        {
            return "Weather is unpredictable today.";
        }
    }
}