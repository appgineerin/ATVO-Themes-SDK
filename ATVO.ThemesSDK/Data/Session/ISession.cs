using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATVO.ThemesSDK.Data.Session
{
    public interface ISession : INotifyPropertyChanged
    {
        ISessionOptions SessionOptions { get; }
    }
}
