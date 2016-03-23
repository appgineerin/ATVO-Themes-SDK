using System.Linq;
using System.Collections.Generic;
using ATVO.ThemesSDK.Data.Results;

namespace ATVO.ThemesSDK.Ordering
{
    internal abstract class AbstractDataOrder : IDataOrder
    {
        public abstract IEnumerable<IEntitySessionResult> Sort(IEnumerable<IEntitySessionResult> results);

        public IEntitySessionResult FindPosition(IEnumerable<IEntitySessionResult> results, int position)
        {
            return Sort(results).Skip(position - 1).FirstOrDefault();
        }

        public IEntitySessionResult FindPosition(IEnumerable<IEntitySessionResult> results, int position, string className)
        {
            return FindPosition(results.Where(r => r.Entity.Car.Class.Name == className), position);
        }
    }
}
