using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Class
{
    internal class Worker<T> where T : IDisposable
    {
        public void Process(T item)
        {
            item.Dispose();
        }
    }
}
