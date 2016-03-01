using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Entity
{
    public interface IEntity : INotifyPropertyChanged, INotifyCollectionChanged, IReadOnlyCollection<IDriver>, IEquatable<IEntity>, IComparable<IEntity>, IFormattable
    {

    }
}
