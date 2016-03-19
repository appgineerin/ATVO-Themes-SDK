using ATVO.ThemesSDK.Data.Entity;
using ATVO.ThemesSDK.Data.Location;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Session
{
    public interface ISession : INotifyPropertyChanged
    {
        ISessionInfo Info { get; }
        ISessionOptions Options { get; }
        ITrack Track { get; }
        IWeather Weather { get; }
        IClassManager ClassManager { get; }
        ReadOnlyObservableCollection<IEntity> Entities { get; }
        int StrengthOfField { get; }
    }
}
