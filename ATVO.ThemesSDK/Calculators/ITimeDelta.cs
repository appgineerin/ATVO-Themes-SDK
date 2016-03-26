using System;

namespace ATVO.ThemesSDK.Calculators
{
    public interface ITimeDelta
    {
        TimeSpan GetDelta(int caridx1, int caridx2);
    }
}
