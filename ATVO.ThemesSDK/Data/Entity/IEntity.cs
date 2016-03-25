using ATVO.ThemesSDK.Data.Results;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace ATVO.ThemesSDK.Data.Entity
{
    public interface IEntity : INotifyPropertyChanged, INotifyCollectionChanged, IReadOnlyCollection<IDriver>, IEquatable<IEntity>, IComparable<IEntity>
    {
        string Name { get; }
        int Id { get; }
        byte CarIdx { get; }
        bool IsFollowedEntity { get; }
        ICar Car { get; }
        ReadOnlyObservableCollection<IDriver> Drivers { get; }
        IDriver CurrentDriver { get; }
        IEntityResults Results { get; }
        BitmapSource Suit { get; }
    }
}
