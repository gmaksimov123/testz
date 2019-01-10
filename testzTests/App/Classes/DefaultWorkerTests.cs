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
        }
    }
}