using ATVO.ThemesSDK.Data.Entity;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Camera
{
    public interface ICameraManager : INotifyPropertyChanged
    {
        ReadOnlyObservableCollection<ICameraGroup> CameraGroups { get; }
        int CurrentGroupId { get; }
        ICameraGroup CurrentGroup { get; }
        IEntity FollowedEntity { get; }
        bool IsInReplay { get; }

        event EventHandler<CameraChangedEventArgs> CameraChanged;
        event EventHandler<FollowerChangedEventArgs> FollowerChanged;

        ICameraGroup GetCameraGroup(int id);
        ICameraGroup GetCameraGroup(string name);

        void Show(int id);
        void Show(string name);
        void Show(ICameraGroup cameraGroup);
        void Show(int id, int numberPadded);
        void Show(string name, int numberPadded);
        void Show(ICameraGroup cameraGroup, int numberPadded);
        void Show(int id, IEntity entity);
        void Show(string name, IEntity entity);
        void Show(ICameraGroup cameraGroup, IEntity entity);
        void Show(IEntity entity);
    }
}
