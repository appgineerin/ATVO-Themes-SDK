using ATVO.ThemesSDK.Data.Enums;
using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Entity
{
    public interface ICarMovement : INotifyPropertyChanged
    {
        float Speed { get; }
        bool IsAccelerating { get; }
        bool IsBraking { get; }
        double TrackPct { get; }
        int Gear { get; }
        TrackLocation TrackLocation { get; }
        bool IsInPits { get; }
    }
}
