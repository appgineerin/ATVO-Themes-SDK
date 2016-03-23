using System.Collections.Generic;
using System.Linq;
using ATVO.ThemesSDK.Data.Results;

namespace ATVO.ThemesSDK.Ordering
{
    internal sealed class LeadLapsDataOrder : AbstractDataOrder, IDataOrder
    {
        public override IEnumerable<IEntitySessionResult> Sort(IEnumerable<IEntitySessionResult> results)
        {
            return results.OrderByDescending(r => r.LapsLed);
        }
    }
}
