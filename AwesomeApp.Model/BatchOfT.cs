using System;
using System.Collections.Generic;

namespace AwesomeApp.Common
{
    public class Batch<T>
    {

        public Batch(T[] items, bool hasMore)
            : this((IEnumerable<T>)items, hasMore)
        { }

        public Batch(IEnumerable<T> items, bool hasMore)
        {

            Items = items ?? throw new ArgumentNullException(nameof(items));
            HasMore = hasMore;
        }

        public IEnumerable<T> Items { get; private set; }

        public bool HasMore { get; private set; }
    }
}
