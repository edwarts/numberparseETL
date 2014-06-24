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
            return "";
        }

        public decimal ReadOneNumber(string filePath)
        {
            throw new NotImplementedException();
        }

        public List<decimal> ReadAllNumber(string filePath)
        {
            List<decimal> numberlist = new List<decimal>();
            try
            {

                FileStream fs = new FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);

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
                return numberlist;
            }
            catch (Exception es)
            {
                return numberlist;

            }
        }
    }
}
