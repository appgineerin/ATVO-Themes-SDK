using System.Linq;
using System.Collections.Generic;
using ATVO.ThemesSDK.Data.Results;

namespace ATVO.ThemesSDK.Ordering
{
    internal sealed class FastestPitStopTimeDataOrder : AbstractDataOrder, IDataOrder
    {
        public override IEnumerable<IEntitySessionResult> Sort(IEnumerable<IEntitySessionResult> results)
        {
            return results.Where(r => r.PitStops.Count > 0).OrderBy(r => r.PitStops.Aggregate((curr, next) => curr == null || next.PitStopTime < curr.PitStopTime ? next : curr));
        }
    }
}
