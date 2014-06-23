using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace parseNumberETL
{
    public class FileIO:iFileIO
    {
        public bool CheckExist(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    return true;
                }
            }
            catch(Exception es)
            {
                return false;
            }
            return false;
        }

        public string ReadFileLine(string filePath)
        {
            throw new NotImplementedException();
        }

        public decimal ReadOneNumber(string filePath)
        {
            throw new NotImplementedException();
        }

        public List<decimal> ReadAllNumber(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
