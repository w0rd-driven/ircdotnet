using System;
using System.Collections.Generic;

namespace System.Linq
{
#if WINDOWS_PHONE
    public static class EnumerableEx
    {
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(
            this IEnumerable<TFirst> first,
            IEnumerable<TSecond> second,
            Func<TFirst, TSecond, TResult> selector)
        {
            if (selector == null)
            {
                throw new ArgumentNullException("selector");
            }

            using (IEnumerator<TFirst> first_enumerator = first.GetEnumerator())
            using (IEnumerator<TSecond> second_enumerator = second.GetEnumerator())
            {
                while (first_enumerator.MoveNext() && second_enumerator.MoveNext())
                {
                    yield return selector(first_enumerator.Current, second_enumerator.Current);
                }
            }
        }
    }
#endif
}

