using ATVO.ThemesSDK.Data.Results;
using System.Collections.Generic;
using System.Linq;

namespace ATVO.ThemesSDK.Ordering
{
    internal sealed class StartPositionDataOrder : AbstractDataOrder, IDataOrder
    {
        public override IEnumerable<IEntitySessionResult> Sort(IEnumerable<IEntitySessionResult> results)
        {
            return results.OrderBy(r => r.StartPosition);
        }
    }
}
