using Microsoft.VisualStudio.TestTools.UnitTesting;
using testz.App.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testz.App.Classes.Tests
{
    [TestClass()]
    public class DefaultAllocatorTests
    {
        [TestMethod()]
        public void RunTest()
        {
            var allocator = new DefaultAllocator();
             
            Assert.IsTrue(allocator.Run(new int[] { 0, 2, 7, 0 }).SequenceEqual(new int[] { 2, 4, 1, 2 }));
        }
    }
}