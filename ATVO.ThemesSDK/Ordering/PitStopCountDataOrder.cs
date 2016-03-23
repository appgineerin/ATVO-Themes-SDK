using ATVO.ThemesSDK.Data.Results;
using System.Collections.Generic;
using System.Linq;

namespace ATVO.ThemesSDK.Ordering
{
    internal sealed class PitStopCountDataOrder : AbstractDataOrder, IDataOrder
    {
        public override IEnumerable<IEntitySessionResult> Sort(IEnumerable<IEntitySessionResult> results)
        {
            return results.OrderByDescending(r => r.PitStopCount);
        }
    }
}
