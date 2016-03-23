using ATVO.ThemesSDK.Data.Results;
using System.Collections.Generic;
using System.Linq;

namespace ATVO.ThemesSDK.Ordering
{
    internal sealed class FastestPitLaneTimeDataOrder : AbstractDataOrder, IDataOrder
    {
        public override IEnumerable<IEntitySessionResult> Sort(IEnumerable<IEntitySessionResult> results)
        {
            return results.Where(r => r.PitStops.Count > 0).OrderBy(r => r.PitStops.Aggregate((curr, next) => curr == null || next.PitLaneTime < curr.PitLaneTime ? next : curr));
        }
    }
}
