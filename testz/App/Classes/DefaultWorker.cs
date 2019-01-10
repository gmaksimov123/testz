using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testz.App.Interfaces;

namespace testz.App.Classes
{
    public class DefaultWorker : IWorker
    {
        public void Run(int[] array, IAllocator allocator)
        {
            int[] defaultArray = Clone(array);
            var results = new List<int[]>();

            array = allocator.Run(array);
            while (!HasEquals(results, array))
            {
                results.Add(array);
                array = allocator.Run(array);
            }
            results.Add(array);

        }

        protected int[] Clone(int[] array)
        {
            int[] result = new int[array.Length];
            Buffer.BlockCopy(array, 0, result, 0, array.Length * sizeof(int));
            return result;
        }

        protected bool HasEquals(List<int[]> list, int[] array)
        {
            return list.Any(x => x.SequenceEqual(array));
        }
    }
}
