﻿using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Location
{
    public interface ITrack : INotifyPropertyChanged
    {
        string Name { get; }
        int Id { get; }
        float Length { get; }
        string DisplayName { get; }
        string DisplayShortName { get; }
        string ConfigName { get; }
        string City { get; }
        string Country { get; }
        string Altitude { get; }
        string Latitude { get; }
        string Longitude { get; }
        float NorthOffset { get; }
        int Turns { get; }
        string PitSpeedLimit { get; }
        string Type { get; }
        bool HasTrackCleanup { get; }
        bool IsDynamicTrack { get; }

        ReadOnlyObservableCollection<ISector> Sectors { get; }
        ObservableCollection<ISector> SelectedSectors { get; }
    }
}
