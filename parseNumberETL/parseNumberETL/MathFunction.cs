using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace parseNumberETL
{
    public class MathFunction:iMath
    {
        
        public decimal GetMean(List<decimal> data)
        {
             decimal sum = 0m;
              decimal mean = 0m;
            try
            {

                foreach (decimal oneNumber in data)
                {

                    sum += oneNumber;

                }
                mean = sum / (data.ToArray().Length == 0 ? 1 : data.ToArray().Length);

                return mean;
            }
            catch (Exception es)
            {

                return mean = 0;//if out of memory issue

            }
        }

        public decimal GetStandDeviation(List<decimal> data)
        {
            decimal sum = 0m;
            decimal mean = 0m;
            decimal sd = 0m;
            try
            {

                foreach (decimal oneNumber in data)
                {

                    sum += oneNumber;

                }
                int totalElement = (data.ToArray().Length == 0 ? 1 : data.ToArray().Length);
                mean = sum / totalElement;

                sum = 0;
                foreach (decimal twoNumber in data)
                {
                    sum += decimal.Multiply(twoNumber - mean, twoNumber - mean);

                }

                sd = (decimal)Math.Sqrt(decimal.ToDouble(sum) / (totalElement > 1 ? (totalElement) : 1)); // the standard deviation is from the whole set instead of sample
                return sd;
            }
            catch (Exception es)
            {

                mean = 0;//if out of memory issue
                return sd = 0;

            }
        }

        public List<int> GetDistributionOfBinTen(List<decimal> data)
        {
            int[] distribution = new int[11];
            try
            {

                foreach (decimal oneNumber in data)
                {

                    int k = (int)oneNumber / 10; //if 1/10 == 0, 1 is between 0 to 10, 20 /10 ==2 , 2 is between 20 to 30 etc
                    distribution[k + 1]++;

                }
                return distribution.ToList<int>();
               
            }

            catch (Exception es)
            {
                return distribution.ToList<int>();
                

            }
        }
    }
}
