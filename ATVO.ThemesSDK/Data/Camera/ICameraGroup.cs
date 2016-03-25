using ATVO.ThemesSDK.Data.Entity;
using System;
using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Camera
{
    public interface ICameraGroup : INotifyPropertyChanged, IEquatable<ICameraGroup>, IComparable<ICameraGroup>
    {
        int Id { get; }
        string Name { get; }

        void Show();
        void Show(int numberPadded);
        void Show(IEntity entity);
    }
}
