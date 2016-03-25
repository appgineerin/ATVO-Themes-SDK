using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Lap
{
    public interface ISector : INotifyPropertyChanged
    {
        byte Index { get; }
        float Time { get; }
        int ReplayPosition { get; }
    }
}
