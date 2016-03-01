using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Location
{
    public interface IWeather : INotifyPropertyChanged
    {
        string Sky { get; }
        float AirTemp { get; }
        int Humidity { get; }
        int Fog { get; }
        float AirPressure { get; }
        float WindSpeed { get; }
        float WindDirection { get; }
    }
}
