using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Location
{
    public interface IWeather : INotifyPropertyChanged
    {
        string WeatherType { get; }
        string Skies { get; }
        string TrackTemp { get; }
        string AirTemp { get; }
        string AirPressure { get; }
        string WindSpeed { get; }
        string WindDirection { get; }
        string RelativeHumidity { get; }
        string FogLevel { get; }
    }
}
