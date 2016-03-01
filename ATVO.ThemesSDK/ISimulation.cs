using System.Threading;

namespace ATVO.ThemesSDK
{
    public interface ISimulation
    {
        Mutex DataMutex { get; }
        object SharedDataLock { get; }

        byte UpdateRate { get; set; }
        bool IsConnected { get; set; }
    }
}
