using System;
using System.Windows.Media.Imaging;

namespace ATVO.ThemesSDK.Data.Entity
{
    public interface IDriver : IEntity, IEquatable<IDriver>
    {
        string Initials { get; }
        string ShortName { get; }
        string LastName { get; }
        string ThreeLetterCode { get; }
        bool IsDriving { get; }
        IClub Club { get; }
        ILicense License { get; }
        string Division { get; }
        BitmapSource Helmet { get; }
    }
}
