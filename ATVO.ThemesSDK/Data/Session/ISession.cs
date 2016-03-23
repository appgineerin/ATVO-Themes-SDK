using ATVO.ThemesSDK.Data.Entity;
using ATVO.ThemesSDK.Data.Enums;
using ATVO.ThemesSDK.Data.Location;
using ATVO.ThemesSDK.Data.Results;
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
        ISessionResult Current { get; }
        ReadOnlyObservableCollection<ISessionResult> SessionResults { get; }
        ReadOnlyObservableCollection<IEntity> Entities { get; }
        ReadOnlyObservableCollection<ISessionEvent> SessionEvents { get; }
        int StrengthOfField { get; }

        ISessionResult GetSession(SessionType type);
        int GetSessionIndex(SessionType type);
    }
}
