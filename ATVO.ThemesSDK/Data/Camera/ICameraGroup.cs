﻿using System;
using System.ComponentModel;

namespace ATVO.ThemesSDK.Data.Camera
{
    public interface ICameraGroup : INotifyPropertyChanged, IEquatable<ICameraGroup>, IComparable<ICameraGroup>
    {
        byte Id { get; }
        string Name { get; }
    }
}
