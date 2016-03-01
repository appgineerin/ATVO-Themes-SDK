using System;
using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace ATVO.ThemesSDK.Data.Entity
{
    public interface IClub : INotifyPropertyChanged, IEquatable<IClub>
    {
        string Name { get; }
        BitmapSource LogoLarge { get; }
        BitmapSource LogoSmall { get; }
    }
}
