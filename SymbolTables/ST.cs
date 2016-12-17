using System;
using System.Collections;
using System.Collections.Generic;

namespace SymbolTables
{
    public class ST<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        public ST()
        {
            BackingStore = new Dictionary<TKey, TValue>();
        }

        private Dictionary<TKey, TValue> BackingStore { get; }
        public int Count => BackingStore.Count;

        public void Put(TKey key, TValue value)
        {
            if (BackingStore.ContainsKey(key))
            {
                BackingStore[key] = value;
                return;
            }

            BackingStore.Add(key, value);
        }

        public Dictionary<TKey, TValue>.KeyCollection Keys => BackingStore.Keys;

        public TValue Get(TKey s)
        {
            if (s == null)
            {
                throw new InvalidOperationException("Invalid Argument");
            }

            if (BackingStore.ContainsKey(s))
            {
                return BackingStore[s];
            }

            return default(TValue);
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return BackingStore.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return BackingStore.GetEnumerator();
        }
    }
}
