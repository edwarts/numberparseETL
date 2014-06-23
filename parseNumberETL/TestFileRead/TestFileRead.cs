using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using parseNumberETL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFileRead
{
    [TestClass]
    public class TestFileRead
    {
        static string fileToTest = "C:\\Users\\Administrator\\workspace\\numberparseETL\\parseNumberETL\\TestFileRead\\SampleData.csv";
        [TestMethod]
        public void TestCheckExist()
        {
            //check file Exist
            iFileIO ifs = new FileIO();
            bool expect=true;
            bool actual= ifs.CheckExist(fileToTest);
            Assert.AreEqual(expect, actual);

        }
    }
}
