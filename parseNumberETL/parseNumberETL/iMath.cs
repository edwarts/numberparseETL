using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace parseNumberETL
{
    interface iMath
    {
        decimal GetMean(List<decimal> data);
        decimal GetStandDeviation(List<decimal> data);
        List<int> GetDistributionOfBinTen(List<decimal> data);
    }
}
