namespace System
{
#if WINDOWS_PHONE
    /// <summary>
    /// Provides static methods for creating tuple objects.
    /// </summary>
    public static class Tuple
    {
        /// <summary>
        /// Creates a new 2-tuple, or pair.
        /// </summary>
        /// <typeparam name="T1">The type of the first component of the tuple.</typeparam>
        /// <typeparam name="T2">The type of the second component of the tuple.</typeparam>
        /// <param name="item1">The value of the first component of the tuple.</param>
        /// <param name="item2">The value of the second component of the tuple.</param>
        /// <returns>A 2-tuple whose value is (item1, item2).</returns>
        public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
        {
            return new Tuple<T1, T2>(item1, item2);
        }

        /// <summary>
        /// Creates a new 3-tuple, or triple.
        /// </summary>
        /// <typeparam name="T1">The type of the first component of the tuple.</typeparam>
        /// <typeparam name="T2">The type of the second component of the tuple.</typeparam>
        /// <typeparam name="T3">The type of the third component of the tuple.</typeparam>
        /// <param name="item1">The value of the first component of the tuple.</param>
        /// <param name="item2">The value of the second component of the tuple.</param>
        /// <param name="item3">The value of the third component of the tuple.</param>
        /// <returns>A 3-tuple whose value is (item1, item2, item3).</returns>
        public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
        {
            return new Tuple<T1, T2, T3>(item1, item2, item3);
        }
    }

    /// <summary>
    /// Represents a 2-tuple, or pair.
    /// </summary>
    /// <typeparam name="T1">The type of the tuple's first component.</typeparam>
    /// <typeparam name="T2">The type of the tuple's second component.</typeparam>
    public class Tuple<T1, T2> : IEquatable<Tuple<T1, T2>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tuple&lt;T1, T2&gt;"/> class.
        /// </summary>
        /// <param name="item1">The value of the tuple's first component.</param>
        /// <param name="item2">The value of the tuple's second component.</param>
        public Tuple(T1 item1, T2 item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        /// <summary>
        /// Gets the value of the current System.Tuple%lt;T1, T2&gt; object's first component.
        /// </summary>
        /// <value>The value of the current System.Tuple%lt;T1, T2&gt; object's first component.</value>
        public T1 Item1
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the value of the current System.Tuple%lt;T1, T2&gt; object's second component.
        /// </summary>
        /// <value>The value of the current System.Tuple%lt;T1, T2&gt; object's second component.</value>
        public T2 Item2
        {
            get;
            set;
        }

        #region IEquatable<Tuple<T1,T2>> Members

        public bool Equals(Tuple<T1, T2> other)
        {
            return this.Item1.Equals(other.Item1) &&
                   this.Item2.Equals(other.Item2);
        }

        #endregion
    }

    /// <summary>
    /// Represents a 3-tuple, or triple.
    /// </summary>
    /// <typeparam name="T1">The type of the tuple's first component.</typeparam>
    /// <typeparam name="T2">The type of the tuple's second component.</typeparam>
    /// <typeparam name="T3">The type of the tuple's third component.</typeparam>
    public class Tuple<T1, T2, T3> : IEquatable<Tuple<T1, T2, T3>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tuple&lt;T1, T2, T3&gt;"/> class.
        /// </summary>
        /// <param name="item1">The value of the tuple's first component.</param>
        /// <param name="item2">The value of the tuple's second component.</param>
        /// <param name="item3">The value of the tuple's third component.</param>
        public Tuple(T1 item1, T2 item2, T3 item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }

        /// <summary>
        /// Gets the value of the current System.Tuple&lt;T1, T2, T3&gt; object's first component.
        /// </summary>
        /// <value>The value of the current System.Tuple&lt;T1, T2, T3&gt; object's first component.</value>
        public T1 Item1
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the value of the current System.Tuple&lt;T1, T2, T3&gt; object's second component.
        /// </summary>
        /// <value>The value of the current System.Tuple&lt;T1, T2, T3&gt; object's second component.</value>
        public T2 Item2
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the value of the current System.Tuple&lt;T1, T2, T3&gt; object's third component.
        /// </summary>
        /// <value>The value of the current System.Tuple&lt;T1, T2, T3&gt; object's third component.</value>
        public T3 Item3
        {
            get;
            set;
        }

        #region IEquatable<Tuple<T1,T2,T3>> Members

        public bool Equals(Tuple<T1, T2, T3> other)
        {
            return this.Item1.Equals(other.Item1) &&
                   this.Item2.Equals(other.Item2) &&
                   this.Item3.Equals(other.Item3);
        }

        #endregion
    }
#endif
}
