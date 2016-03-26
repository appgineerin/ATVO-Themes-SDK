using ATVO.ThemesSDK.Data.Enums;
using System;

namespace ATVO.ThemesSDK.Event
{
    public interface ISimEventManager
    {
        void RegisterEventHandler(EventType eventType, Action handler);
        void RegisterEventHandler(EventType eventType, Action<int> handler);
        bool RemoveHandler(Action handler);
        bool RemoveHandler(Action<int> handler);
        bool RemoveHandler(EventType eventType, Action handler);
        bool RemoveHandler(EventType eventType, Action<int> handler);
    }
}
