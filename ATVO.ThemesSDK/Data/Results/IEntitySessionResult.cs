using ATVO.ThemesSDK.Data.Entity;
using ATVO.ThemesSDK.Data.Lap;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Results
{
    public interface IEntitySessionResult : INotifyPropertyChanged, IComparable<IEntitySessionResult>
    {
        IEntity Entity { get; }
        ISessionResult Session { get; }
        int Position { get; }
        int LivePosition { get; }
        int HighestPosition { get; }
        int LowestPosition { get; }
        int StartPosition { get; }
        int ClassPosition { get; }
        int LiveClassPosition { get; }
        int ClassHighestPosition { get; }
        int ClassLowestPosition { get; }
        int ClassStartPosition { get; }
        int LapsLed { get; }
        int ClassLapsLed { get; }
        float Gap { get; }
        float LiveGap { get; }
        int GapLaps { get; }
        int LiveGapLaps { get; }
        float ClassGap { get; }
        float LiveClassGap { get; }
        int ClassGapLaps { get; }
        int LiveClassGapLaps { get; }
        float Interval { get; }
        float LiveInterval { get; }
        int IntervalLaps { get; }
        int LiveIntervalLaps { get; }
        float FastestLapTime { get; }
        float LastLapTime { get; }
        double CurrentLapTime { get; }
        ILap CurrentLap { get; }
        ILap PreviousLap { get; }
        ILap FastestLap { get; }
        ReadOnlyObservableCollection<ILap> Laps { get; }
        double CurrentTrackPct { get; }
        int PitStopCount { get; }
        IPitStop CurrentPitStop { get; }
        ReadOnlyObservableCollection<IPitStop> PitStops { get; }
        bool Finished { get; }
        bool Out { get; }
        bool DidNotStart { get; }
        int Incidents { get; }
        TimeSpan AirTime { get; set; }
        string ReasonOutString { get; }
        double InvisibleSince { get; }
    }
}
