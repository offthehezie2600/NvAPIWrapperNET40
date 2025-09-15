using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace corlib.System.Collections.Generic
{
    public interface IReadOnlyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        TValue this[TKey key] { get; set; }

        int Count { get; }
        ICollection<TKey> Keys { get; }
        ICollection<TValue> Values { get; }

        bool ContainsKey(TKey key);
        bool TryGetValue(TKey key, out TValue value);
        
    }
}