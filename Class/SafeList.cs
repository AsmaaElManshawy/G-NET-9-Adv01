using System;

namespace Assignment_1.Class
{
    internal class SafeList<T>
    {
        // Question 14

        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= items.Count)
                return default;

            return items[index];
        }
    }
}
