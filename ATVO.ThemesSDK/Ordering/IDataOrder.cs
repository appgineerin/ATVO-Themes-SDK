using ATVO.ThemesSDK.Data.Results;
using System.Collections.Generic;

namespace ATVO.ThemesSDK.Ordering
{
    public interface IDataOrder
    {
        IEnumerable<IEntitySessionResult> Sort(IEnumerable<IEntitySessionResult> results);
        IEntitySessionResult FindPosition(IEnumerable<IEntitySessionResult> results, int position);
        IEntitySessionResult FindPosition(IEnumerable<IEntitySessionResult> results, int position, string className);
    }
}
