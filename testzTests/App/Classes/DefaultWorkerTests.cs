using Microsoft.VisualStudio.TestTools.UnitTesting;
using testz.App.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace testz.App.Classes.Tests
{
    [TestClass()]
    public class DefaultWorkerTests
    {
        [TestMethod()]
        public void RunTest()
        {
            var worker = new DefaultWorker();
            var allocator = new DefaultAllocator();

            var result = worker.Run(new int[] { 0, 2, 7, 0 }, allocator);
            Assert.AreEqual(5, result.Loops);
            Assert.AreEqual(4, result.EqualsLoop);

            result = worker.Run(new int[] { 0, 5, 10, 0, 11, 14, 13, 4, 11, 8, 8, 7, 1, 4, 12, 11 }, allocator);
            Assert.AreEqual(7864, result.Loops);
            Assert.AreEqual(1695, result.EqualsLoop);
        }
    }
}