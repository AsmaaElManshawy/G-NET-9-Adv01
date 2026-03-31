using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Class
{
    internal class ValueContainer<T> where T : struct
    {
        // Question 07
        public T Value { get; set; }
    }
}
