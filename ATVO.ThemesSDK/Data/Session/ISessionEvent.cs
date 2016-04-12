using ATVO.ThemesSDK.Data.Entity;
using ATVO.ThemesSDK.Data.Enums;
using System;
using System.ComponentModel;
using ATVO.ThemesSDK.Data.Camera;

namespace ATVO.ThemesSDK.Data.Session
{
    public interface ISessionEvent : INotifyPropertyChanged, IComparable<ISessionEvent>
    {
        DateTime Timestamp { get; }
        long ReplayPos { get; }
        string Description { get; }
        IEntity Entity { get; }
        ICameraGroup CameraGroup { get; set; }
        SessionType SessionType { get; }
        SessionEventType EventType { get; }
        int LapNumber { get; }
        int Rewind { get; }
    }
}
