using System;
using System.ComponentModel;
using System.Windows.Media;

namespace ATVO.ThemesSDK.Data.Entity
{
    public interface IClass : INotifyPropertyChanged, IEquatable<IClass>, IComparable<IClass>
    {
        byte Id { get; }
        byte Order { get; }
        int RelativeSpeed { get; }
        string Name { get; }
        Color Color { get; }
        int StrengthOfClass { get; }
    }
}
