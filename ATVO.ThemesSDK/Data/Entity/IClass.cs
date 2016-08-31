using System;
using System.ComponentModel;
using System.Windows.Media;

namespace ATVO.ThemesSDK.Data.Entity
{
    public interface IClass : INotifyPropertyChanged, IEquatable<IClass>, IComparable<IClass>
    {
        byte Id { get; set; }
        int Order { get; set; }
        int RelativeSpeed { get; set; }
        string Name { get; set; }
        Color Color { get; set; }
        int StrengthOfClass { get; set; }
        bool IsCustomClass { get; set; }
    }
}
