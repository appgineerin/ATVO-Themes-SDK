using System;
using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace ATVO.ThemesSDK.Data.Entity
{
    public interface ICar : INotifyPropertyChanged, IEquatable<ICar>, IFormattable
    {
        string Number { get; }
        string Name { get; }
        int NumberPadded { get; }
        int Id { get; }
        IClass Class { get; }
        BitmapSource Image { get; }
    }
}
