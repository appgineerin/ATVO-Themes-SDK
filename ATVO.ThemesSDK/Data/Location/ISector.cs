using System;

namespace ATVO.ThemesSDK.Data.Location
{
    public interface ISector : IEquatable<ISector>, IComparable<ISector>
    {
        byte Index { get; }
        float Location { get; }
    }
}
