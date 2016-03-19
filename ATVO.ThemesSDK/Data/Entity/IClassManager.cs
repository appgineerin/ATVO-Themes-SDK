using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Entity
{
    public interface IClassManager : INotifyPropertyChanged
    {
        ReadOnlyObservableCollection<IClass> Classes { get; }

        IClass GetClass(int index);
        IClass GetClass(string name);
    }
}
