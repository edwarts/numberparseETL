using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using parseNumberETL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Threading;

namespace TestFileRead
{
    [TestClass]
    public class TestFileRead
    {
        //change this file path to your sampleData.csv filePath
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
        [TestMethod]
        public void TestReadAllNumbers()
        {


            iFileIO ifs = new FileIO();
            List<decimal> numberlist = new List<decimal>();
            FileStream fs = new FileStream(fileToTest, System.IO.FileMode.Open, System.IO.FileAccess.Read);

            //StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            //string fileContent = sr.ReadToEnd();
            //encoding = sr.CurrentEncoding;
            //one line record every time
            string strLine = "";
            //record header and table line
            string[] aryLine = null;
            string[] tableHead = null;

            //whether read the first line
            bool IsFirst = true;
            //read CSV by line
            while ((strLine = sr.ReadLine()) != null)
            {
                //strLine = Common.ConvertStringUTF8(strLine, encoding);
                //strLine = Common.ConvertStringUTF8(strLine);

                if (IsFirst == true)
                {
                    tableHead = strLine.Split(',');
                    IsFirst = false;
                    //go over first line
                    aryLine = strLine.Split(',');

                    for (int i = 0; i < aryLine.Length; i++)
                    {
                        numberlist.Add(Decimal.Parse(aryLine[i].ToString()));

                    }
                }
                else
                {
                    aryLine = strLine.Split(',');
                   
                    for (int i = 0; i < aryLine.Length; i++)
                    {
                        numberlist.Add(Decimal.Parse(aryLine[i].ToString()));
 
                    }
                       
                }
            }
          

            sr.Close();
            fs.Close();
            //test the total Number is correct;
            
            int totalNumberExpect=1000;
            int totalNumberActual = ifs.ReadAllNumber(fileToTest).ToArray().Length;
            Assert.AreEqual(totalNumberExpect, totalNumberActual);
            //test the special field is correct
            decimal fieldToTeTestExpect = 1.357055324m;
            decimal fieldToTeTestActual = ifs.ReadAllNumber(fileToTest).Take<decimal>(1).FirstOrDefault();
            Assert.AreEqual(fieldToTeTestExpect, fieldToTeTestActual);

      
        }
    }
}
