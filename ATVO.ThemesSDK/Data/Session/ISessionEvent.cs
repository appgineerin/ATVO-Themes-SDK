using ATVO.ThemesSDK.Data.Entity;
using ATVO.ThemesSDK.Data.Enums;
using System;
using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Session
{
    public interface ISessionEvent : INotifyPropertyChanged, IComparable<ISessionEvent>
    {
        DateTime Timestamp { get; }
        long ReplayPos { get; }
        string Description { get; }
        IEntity Entity { get; }
        SessionType SessionType { get; }
        SessionEventType EventType { get; }
        int LapNumber { get; }
        int Rewind { get; }
    }
}
