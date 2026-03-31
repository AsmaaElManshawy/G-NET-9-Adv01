using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Class
{
    internal class Container<T>
    {
        #region Question 02

        /*
         * 
         * Q2: Write a generic class Container<T> with Add and Get methods.
         * 
         * 
         */
        #endregion

        private T item;
        public void Add(T newItem)
        {
            item = newItem;
        }
        public T Get()
        {
            return item;
        }
    }
}
