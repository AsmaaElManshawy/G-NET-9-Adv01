using System;

namespace Assignment_1.ExerciseQ20
{
    internal class CacheItem<TValue>
    {
        public TValue Value { get; set; }
        public DateTime Expiration { get; set; }

        public bool IsExpired => DateTime.Now > Expiration;
    }
}
