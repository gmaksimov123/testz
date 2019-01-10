using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testz.App.Interfaces;

namespace testz.App.Classes
{
    public class DefaultAllocator : IAllocator
    {
        public DefaultAllocator()
        {
        }

        public int[] Run(int[] array)
        {
            int allocationIndex = FindMaxIndex(array);
            int allocationValue = array[allocationIndex];
            array[allocationIndex] = 0;

            int index = allocationIndex + 1;
            int lastIndex = array.Length - 1;

            while (allocationValue > 0)
            {
                if (index > lastIndex)
                {
                    index = 0;
                }
                array[index]++;
                allocationValue--;
                index++;
            }
            return array;
        }

        protected int FindMaxIndex(int[] array)
        {
            int maxIndex = 0;
            int lastIndex = array.Length;
            for (int i = 0; i <= lastIndex; i++)
            {
                if (array[maxIndex] < array[i])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
    }
}
