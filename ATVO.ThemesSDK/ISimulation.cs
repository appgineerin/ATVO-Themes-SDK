using ATVO.ThemesSDK.Calculators;
using ATVO.ThemesSDK.Data;
using ATVO.ThemesSDK.Data.Camera;
using ATVO.ThemesSDK.Data.Enums;
using ATVO.ThemesSDK.Data.Session;
using ATVO.ThemesSDK.Event;
using System.ComponentModel;
using System.Threading;

namespace ATVO.ThemesSDK
{
    public interface ISimulation : INotifyPropertyChanged
    {
        Mutex DataMutex { get; }
        object SharedDataLock { get; }

        byte UpdateRate { get; set; }
        bool HideSimUI { get; set; }
        bool IsConnected { get; }

        ITelemetry Telemetry { get; }
        ICameraManager CameraManager { get; }
        ITimeDelta TimeDelta { get; }
        ISession Session { get; }
        ISimEventManager EventManager { get; }
        int CurrentRadioCarIdx { get; }

        void Start();
        void Stop();
        object GetData(string key);
        T GetData<T>(string key, T def = default(T));
        void BroadcastMessage(BroadcastMessageType type, int var1, int var2);
        void BroadcastMessage(BroadcastMessageType type, int var1, int var2, int var3);
        void AddEvent(EventType type);
    }
}
