using System;
using System.ComponentModel;
using System.Windows.Media;

namespace ATVO.ThemesSDK.Data.Entity
{
    public interface ILicense : INotifyPropertyChanged
    {
        float SafetyRating { get; }
        int IRating { get; }
        int Order { get; }
        string Display { get; }
        Color LicenseColor { get; }
        Color TextColor { get; }
    }
}
