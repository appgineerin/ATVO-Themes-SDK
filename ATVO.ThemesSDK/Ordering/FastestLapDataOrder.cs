using System.Collections.Generic;
using System.Linq;
using ATVO.ThemesSDK.Data.Results;

namespace ATVO.ThemesSDK.Ordering
{
    internal sealed class FastestLapDataOrder : AbstractDataOrder, IDataOrder
    {
        public override IEnumerable<IEntitySessionResult> Sort(IEnumerable<IEntitySessionResult> results)
        {
            return results.Where(r => r.FastestLapTime > 1).OrderBy(r => r.FastestLapTime);
        }
    }
}
