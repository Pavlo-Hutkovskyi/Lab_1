using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalaizerClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AnalaizerClassLibrary.Tests
{
    [TestClass()]
    public class AnalaizerClassTests
    {

        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "testData.xml",
            "Operation", 
            DataAccessMethod.Sequential)]

        [TestMethod()]
        public void GetPriorityTest()
        {
            string result = Convert.ToString(TestContext.DataRow["expected"]);
            int expected = Convert.ToInt16(TestContext.DataRow["actual"]);
            int actual = AnalaizerClass.GetPriority(result);
            Debug.WriteLine($"{expected} {actual}");
            Assert.AreEqual(expected, actual);
        }
    }
}