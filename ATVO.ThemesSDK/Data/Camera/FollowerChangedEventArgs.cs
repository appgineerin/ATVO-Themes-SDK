using ATVO.ThemesSDK.Data.Entity;
using System;

namespace ATVO.ThemesSDK.Data.Camera
{
    public sealed class FollowerChangedEventArgs : EventArgs
    {
        public IEntity OldEntity { get; }
        public IEntity NewEntity { get; }

        public FollowerChangedEventArgs(IEntity oldEntity, IEntity newEntity)
        {
            OldEntity = oldEntity;
            NewEntity = newEntity;
        }
    }
}
