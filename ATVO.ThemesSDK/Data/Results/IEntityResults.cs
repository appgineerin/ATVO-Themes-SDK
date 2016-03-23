using ATVO.ThemesSDK.Data.Entity;
using ATVO.ThemesSDK.Data.Enums;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Results
{
    public interface IEntityResults : INotifyPropertyChanged
    {
        ReadOnlyObservableCollection<IEntitySessionResult> SessionResults { get; }
        IEntitySessionResult CurrentResult { get; }
        IEntity Entity { get; }

        bool HasResult(int sessionNumber);
        bool HasResult(SessionType sessionType);
        IEntitySessionResult GetResult(int sessionNumber);
        IEntitySessionResult GetResult(SessionType sessionType);
        IEntitySessionResult this[int sessionNumber] { get; }
        IEntitySessionResult this[SessionType sessionType] { get; }
    }
}
