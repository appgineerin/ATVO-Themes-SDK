using ATVO.ThemesSDK.Data.Camera;
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

        ICameraManager CameraManager { get; }

        void Start();
        void Stop();
        object GetData(string key);
        T GetData<T>(string key, T def = default(T));
    }
}
