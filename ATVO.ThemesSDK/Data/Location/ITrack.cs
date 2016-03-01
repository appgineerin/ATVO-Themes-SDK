using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Location
{
    public interface ITrack : INotifyPropertyChanged, IFormattable
    {
        byte Id { get; }
        float Length { get; }
        int Turns { get; }
        string Name { get; }
        string City { get; }
        string Country { get; }
        float Altitude { get; }
        float TrackTemp { get; }
        IEnumerable<ISector> Sectors { get; }
        IList<ISector> SelectedSectors { get; }
    }
}
