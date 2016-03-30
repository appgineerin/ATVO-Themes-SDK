using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Lap
{
    public interface ILap : INotifyPropertyChanged
    {
        int Number { get; }
        int Position { get; }
        int ClassPosition { get; }
        float Time { get; }
        float Gap { get; }
        int GapLaps { get; }
        int ReplayPosition { get; }
        ReadOnlyObservableCollection<ISector> Sectors { get; }
    }
}
