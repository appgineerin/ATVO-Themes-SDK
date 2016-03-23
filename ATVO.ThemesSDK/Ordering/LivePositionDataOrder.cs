using System.Collections.Generic;
using System.Linq;
using ATVO.ThemesSDK.Data.Results;

namespace ATVO.ThemesSDK.Ordering
{
    internal sealed class LivePositionDataOrder : AbstractDataOrder, IDataOrder
    {
        public override IEnumerable<IEntitySessionResult> Sort(IEnumerable<IEntitySessionResult> results)
        {
            return results.OrderBy(r => r.LivePosition);
        }
    }
}
