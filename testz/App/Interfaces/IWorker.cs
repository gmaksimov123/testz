using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testz.App.Interfaces
{
    public interface IWorker
    {
        public void Run (int[] array, IAllocator allocator)
    }
}
