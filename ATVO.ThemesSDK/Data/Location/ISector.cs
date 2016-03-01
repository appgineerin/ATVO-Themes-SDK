using System;

namespace ATVO.ThemesSDK.Data.Location
{
    public interface ISector : IEquatable<ISector>, IComparable<ISector>, IFormattable
    {
        float Location { get; }
    }
}
