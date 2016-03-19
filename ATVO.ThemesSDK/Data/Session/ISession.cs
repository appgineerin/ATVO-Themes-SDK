using ATVO.ThemesSDK.Data.Location;
using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Session
{
    public interface ISession : INotifyPropertyChanged
    {
        ISessionInfo Info { get; }
        ISessionOptions Options { get; }
        ITrack Track { get; }
        IWeather Weather { get; }
    }
}
