using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Entity
{
    public interface IPitStop : INotifyPropertyChanged
    {
        int LapNumber { get; }
        double PitStopTime { get; }
        double PitLaneTime { get; }
    }
}
