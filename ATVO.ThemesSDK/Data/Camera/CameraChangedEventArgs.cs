using System;

namespace ATVO.ThemesSDK.Data.Camera
{
    public sealed class CameraChangedEventArgs : EventArgs
    {
        public ICameraGroup OldCameraGroup { get; }
        public ICameraGroup NewCameraGroup { get; }

        public CameraChangedEventArgs(ICameraGroup oldCameraGroup, ICameraGroup newCameraGroup)
        {
            OldCameraGroup = oldCameraGroup;
            NewCameraGroup = newCameraGroup;
        }
    }
}
