using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            List<decimal> dataset = new List<decimal>();
            decimal sum = 0m;
              decimal mean = 0m;
        double sd = 0d;
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
                    sum += decimal.Multiply(twoNumber-mean,twoNumber-mean);

                }
                Console.WriteLine(decimal.ToDouble(sum));
                Console.WriteLine(decimal.ToDouble(sum) / (totalElement > 1 ? (totalElement) : 1));
                sd = Math.Sqrt(decimal.ToDouble(sum) / (totalElement > 1 ? (totalElement ) : 1));

                object actual = sd;
                object expected = sd;
                Console.WriteLine(sd);
                Console.ReadLine();
            }
            catch (Exception es)
            {

                mean = 0;//if out of memory issue
                sd = 0;

            }
        }
        }
    }

