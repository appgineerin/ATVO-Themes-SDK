using System;
using System.ComponentModel;
using System.Windows.Media;

namespace ATVO.ThemesSDK.Data.Entity
{
    public interface ILicense : INotifyPropertyChanged, IEquatable<ILicense>, IFormattable, IComparable<ILicense>
    {
        float SafetyRating { get; }
        int IRating { get; }
        Color LicenseColor { get; }
        Color TextColor { get; }
    }
}
