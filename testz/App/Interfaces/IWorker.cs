using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testz.App.Classes;

namespace testz.App.Interfaces
{
    public interface IWorker
    {
        Result Run(int[] array, IAllocator allocator);
    }
}
