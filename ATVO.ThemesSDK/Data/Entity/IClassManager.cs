using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Media;

namespace ATVO.ThemesSDK.Data.Entity
{
    public interface IClassManager : INotifyPropertyChanged
    {
        ObservableCollection<IClass> Classes { get; }

        IClass GetClass(int index);
        IClass GetClass(string name);
        IClass CreateCustomClass(string name, int order, Color color);
    }
}
