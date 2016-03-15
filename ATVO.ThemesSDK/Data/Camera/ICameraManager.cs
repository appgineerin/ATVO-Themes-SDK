using ATVO.ThemesSDK.Data.Entity;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Camera
{
    public interface ICameraManager : INotifyPropertyChanged
    {
        ReadOnlyObservableCollection<ICameraGroup> CameraGroups { get; }
        byte CurrentGroupId { get; }
        IEntity FollowedEntity { get; }
        bool IsInReplay { get; }

        event EventHandler<CameraChangedEventArgs> CameraChanged;
        event EventHandler<FollowerChangedEventArgs> FollowerChanged;

        ICameraGroup GetCameraGroup(byte id);
        ICameraGroup GetCameraGroup(string name);

        void Show(byte id);
        void Show(string name);
        void Show(ICameraGroup cameraGroup);
        void Show(byte id, int numberPadded);
        void Show(string name, int numberPadded);
        void Show(ICameraGroup cameraGroup, int numberPadded);
        void Show(byte id, IEntity entity);
        void Show(string name, IEntity entity);
        void Show(ICameraGroup cameraGroup, IEntity entity);
        void Show(int numberPadded);
        void Show(IEntity entity);
    }
}
