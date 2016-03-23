using ATVO.ThemesSDK.Data.Entity;
using ATVO.ThemesSDK.Data.Enums;
using ATVO.ThemesSDK.Ordering;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Results
{
    public interface ISessionResult : INotifyPropertyChanged
    {
        ReadOnlyObservableCollection<IEntitySessionResult> Results { get; }
        IEntity Leader { get; }
        IEntity LiveLeader { get; }
        SessionType Type { get; }
        SessionState State { get; }
        SessionFlags Flags { get; }
        IDriver FastestLapDriver { get; }
        int FastestLapNumber { get; }
        float FastestLapTime { get; }
        int Id { get; }
        int LeadChanges { get; }
        int Cautions { get; }
        int CautionLaps { get; }
        double SessionLength { get; }
        double SessionTime { get; }
        double SessionTimeRemaining { get; }
        double SessionStartTime { get; }
        int LapsTotal { get; }
        int LapsCompleted { get; }
        int FinishLine { get; }
        int CurrentReplayPosition { get; }
        bool PitOccupied { get; }

        IEntitySessionResult GetClassLeader(string className);
        IEntitySessionResult GetLiveClassLeader(string className);
        IEntitySessionResult GetResult(int position, IDataOrder order);
        IEntitySessionResult GetResult(int position, IDataOrder order, string className);
    }
}
