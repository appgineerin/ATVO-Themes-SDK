using System;
using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace ATVO.ThemesSDK.Data.Entity
{
    public interface ICar : INotifyPropertyChanged, IEquatable<ICar>
    {
        string Number { get; }
        string Path { get; }
        string Name { get; }
        int NumberPadded { get; }
        int Id { get; }
        IClass Class { get; }
        ICarMovement Movement { get; }
        BitmapSource Image { get; }
    }
}
