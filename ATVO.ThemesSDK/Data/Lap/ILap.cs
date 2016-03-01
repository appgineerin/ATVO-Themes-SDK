using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Lap
{
    public interface ILap : INotifyPropertyChanged, IComparable<ILap>, IEquatable<ILap>, IFormattable
    {
        uint Number { get; }
        byte Position { get; }
        byte ClassPosition { get; }
        TimeSpan Time { get; }
        ReadOnlyObservableCollection<ISector> Sectors { get; }
    }
}
