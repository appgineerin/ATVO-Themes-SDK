using System;
using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Laps
{
    public interface ISector : INotifyPropertyChanged, IEquatable<ISector>, IComparable<ISector>, IFormattable
    {
        byte Index { get; }
        TimeSpan Time { get; }
        int ReplayPosition { get; }
    }
}
