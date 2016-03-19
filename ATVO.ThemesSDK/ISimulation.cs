using ATVO.ThemesSDK.Data;
using ATVO.ThemesSDK.Data.Camera;
using ATVO.ThemesSDK.Data.Session;
using System.ComponentModel;
using System.Threading;

namespace ATVO.ThemesSDK
{
    public interface ISimulation : INotifyPropertyChanged
    {
        Mutex DataMutex { get; }
        object SharedDataLock { get; }

        byte UpdateRate { get; set; }
        bool IsConnected { get; }

        ITelemetry Telemetry { get; }
        ICameraManager CameraManager { get; }
        ISession Session { get; }
        string TelemetryDiskFile { get; }

        void Start();
        void Stop();
        object GetData(string key);
        T GetData<T>(string key, T def = default(T));
    }
}
