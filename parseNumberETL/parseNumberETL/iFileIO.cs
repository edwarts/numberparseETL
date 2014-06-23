using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace parseNumberETL
{
    /// <summary>
    ///  this is the basic interface to read data from files
    /// </summary>
    interface iFileIO
    {
        bool CheckExist(string filePath);
        string ReadFileLine(string filePath);
        decimal ReadOneNumber(string filePath);
        List<decimal> ReadAllNumber(string filePath);

    }
}
