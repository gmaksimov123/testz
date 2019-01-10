using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testz.App.Classes;

namespace testz
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new DefaultWorker();
            var allocator = new DefaultAllocator();

            var result = worker.Run(new int[] { 0, 2, 7, 0 }, allocator);
            ShowResult(result);

            result = worker.Run(new int[] { 0, 5, 10, 0, 11, 14, 13, 4, 11, 8, 8, 7, 1, 4, 12, 11 }, allocator);
            ShowResult(result);
            Console.Read();
        }
        static void ShowResult(Result result)
        {
            Console.WriteLine(result.ToString());
        }
    }
}
