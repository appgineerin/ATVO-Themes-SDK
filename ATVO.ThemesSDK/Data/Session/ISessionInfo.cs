using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Session
{
    public interface ISessionInfo : INotifyPropertyChanged
    {
        int SeriesId { get; }
        int SeasonId { get; }
        int SessionId { get; }
        int SubSessionId { get; }
        int LeagueId { get; }
        bool IsOfficial { get; }
        int RaceWeek { get; }
        string EventType { get; }
        string Category { get; }
        string SimMode { get; }
        bool IsTeamRacing { get; }
        int MinDrivers { get; }
        int MaxDrivers { get; }
        string DCRuleSet { get; }
        bool QualifierMustStartRace { get; }
        int NumCarClasses { get; }
        int NumCarTyps { get; }
    }
}
