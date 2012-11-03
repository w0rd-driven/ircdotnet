using System;
using System.Collections;

namespace System.Collections.Generic
{
#if WINDOWS_PHONE
    /// <summary>
    /// Provides the base interface for the abstraction of sets.
    /// </summary>
    /// <typeparam name="T">The type of elements in the set.</typeparam>
    public interface ISet<T> : ICollection<T>, IEnumerable<T>, IEnumerable
    {
        new bool Add(T item);

        void ExceptWith(IEnumerable<T> other);

        void IntersectWith(IEnumerable<T> other);

        bool IsProperSubsetOf(IEnumerable<T> other);

        bool IsProperSupersetOf(IEnumerable<T> other);

        bool IsSubsetOf(IEnumerable<T> other);

        bool IsSupersetOf(IEnumerable<T> other);

        bool Overlaps(IEnumerable<T> other);

        bool SetEquals(IEnumerable<T> other);

        void SymmetricExceptWith(IEnumerable<T> other);

        void UnionWith(IEnumerable<T> other);
    }
#endif
}
