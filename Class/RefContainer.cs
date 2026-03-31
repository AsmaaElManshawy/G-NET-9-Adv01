using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Class
{
    internal class RefContainer<T> where T : class
    {
        // Question 08
        public T Value { get; set; }
    }
}
