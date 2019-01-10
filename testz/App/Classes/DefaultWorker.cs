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
        public Result Run(int[] array, IAllocator allocator)
        {
            int[] defaultArray = Clone(array);
            int loops = 1;
            int equalsLoop = -1;

            var results = new List<string>();

            allocator.Run(array);
            
            while (equalsLoop == -1)
            {
                results.Add(StringifyArray(array));
                allocator.Run(array);
                loops++;
                
                equalsLoop = FindEqualsIndex(results, StringifyArray(array));
            }
            var result = new Result { Array = defaultArray, Loops = loops, EqualsLoop = loops - equalsLoop - 1, ResultArray = array };
            return result;
        }

        protected int[] Clone(int[] array)
        {
            int[] result = new int[array.Length];
            Buffer.BlockCopy(array, 0, result, 0, array.Length * sizeof(int));
            return result;
        }

        protected int FindEqualsIndex(List<string> list, string stringigyArray)
        {
            return list.FindIndex(x => x == stringigyArray);
        }

        protected string StringifyArray(int[] array)
        {
            return string.Join(",", array);
        }
    }
}
