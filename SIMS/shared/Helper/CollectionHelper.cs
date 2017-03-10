using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS.Shared.Helper
{
    static class CollectionHelper
    {
        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> _source)
        {
            return _source ?? Enumerable.Empty<T>();
        }
    }

}
