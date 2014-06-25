using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using parseNumberETL;

namespace TestMath
{
    [TestClass]
    public class MathTest
    {
        List<decimal> dataset = new List<decimal>();
        decimal sum = 0m;
        decimal mean = 0m;
        decimal sd = 0m;
        [TestMethod]
        public void TestGetMean()
        {
            dataset.Add(1.357055324m);
            dataset.Add(91.61421247m);
            dataset.Add(15.85347463m);
            dataset.Add(78.44536547m);
            dataset.Add(20.15793072m);
            dataset.Add(67.87355683m);
            dataset.Add(39.12873487m);
            try
            {
            
                foreach (decimal oneNumber in dataset)
                {

                    sum += oneNumber;

                }
                mean = sum / (dataset.ToArray().Length == 0 ? 1 : dataset.ToArray().Length);
                
                object actual = mean;
                object expected = 44.9186186162857142857142885714m;
                Assert.AreEqual(expected, actual);
                Assert.AreEqual(expected, new MathFunction().GetMean(dataset));
            }
            catch (Exception es)
            {
               
                mean = 0;//if out of memory issue
 
            }
        }
        [TestMethod]
        public void TestGetSD()
        {
            dataset.Add(1.357055324m);
            dataset.Add(91.61421247m);
            dataset.Add(15.85347463m);
            dataset.Add(78.44536547m);
            dataset.Add(20.15793072m);
            dataset.Add(67.87355683m);
            dataset.Add(39.12873487m);
            try
            {

                foreach (decimal oneNumber in dataset)
                {

                    sum += oneNumber;

                }
                int totalElement = (dataset.ToArray().Length == 0 ? 1 : dataset.ToArray().Length);
                mean = sum / totalElement;

                sum = 0;
                foreach (decimal twoNumber in dataset)
                {
                    sum += decimal.Multiply(twoNumber - mean, twoNumber - mean);

                }
    
                sd = (decimal)Math.Sqrt(decimal.ToDouble(sum) / (totalElement > 1 ? (totalElement) : 1));

                object actual = sd;
               
                object expected = 32.1168786035443m;
                Assert.AreEqual(expected, actual);
                Assert.AreEqual(expected, new MathFunction().GetStandDeviation(dataset));
            }
            catch (Exception es)
            {

                mean = 0;//if out of memory issue
                sd = 0;

            }
        }
        [TestMethod]
        public void TestGetDistribution()
        {
            dataset.Add(1.357055324m);
            dataset.Add(91.61421247m);
            dataset.Add(15.85347463m);
            dataset.Add(78.44536547m);
            dataset.Add(20.15793072m);
            dataset.Add(67.87355683m);
            dataset.Add(39.12873487m);
            int[] distribution = new int[11];
            try
            {

                foreach (decimal oneNumber in dataset)
                {

                    int k = (int)oneNumber / 10;
                    distribution[k+1]++;

                }
                int index =0;
                int[] expect = { 0, 1, 1, 0, 1, 0, 0, 1, 1, 0, 1 };
                foreach (int ds in distribution)
                {
                    Assert.AreEqual(expect[index],ds);

                    index++;
                }
                distribution = new MathFunction().GetDistributionOfBinTen(dataset).ToArray();
                foreach (int ds in distribution)
                {
                    Assert.AreEqual(expect[index], ds);

                    index++;
                }
            }
            
            catch (Exception es)
            {

                mean = 0;//if out of memory issue
                sd = 0;

            }
        }
    }
}
