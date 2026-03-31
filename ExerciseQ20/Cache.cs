using System;

namespace Assignment_1.ExerciseQ20
{
    internal class Cache<TKey, TValue>
    {
        private Dictionary<TKey, CacheItem<TValue>> cache = new Dictionary<TKey, CacheItem<TValue>>();

        public void Add(TKey key, TValue value, TimeSpan duration)
        {
            cache[key] = new CacheItem<TValue>
            {
                Value = value,
                Expiration = DateTime.Now.Add(duration)
            };
        }

        public TValue Get(TKey key)
        {
            if (cache.ContainsKey(key))
            {
                var item = cache[key];

                if (!item.IsExpired)
                    return item.Value;

                cache.Remove(key);
            }

            return default;
        }

        public bool Contains(TKey key)
        {
            return cache.ContainsKey(key) && !cache[key].IsExpired;
        }

        public void Remove(TKey key)
        {
            cache.Remove(key);
        }

    }
}
