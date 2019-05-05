using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateProject.Util
{
    public class Util
    {
        public static String getPath(String path)
        {
            return path.Replace("\\", "/");
        }

        public static String setPath(String path)
        {
            return path.Replace("/", "\\");
        }


        public static String formatSize(long size)
        {
            long rankKB = 1024;
            long rankMB = rankKB * 1024;
            long rankGB = rankMB * 1024;
            long rankTB = rankGB * 1024;
            if (size <= 0)
            {
                return "-";
            }
            else if (size < rankMB)
            {
                return Math.Round(((Decimal)size / rankKB), 2) + " KB";
            }
            else if (size < rankGB)
            {
                return Math.Round(((Decimal)size / rankMB), 2) + " MB";
            }
            else if (size < rankTB)
            {
                return Math.Round(((Decimal)size / rankGB), 2, MidpointRounding.AwayFromZero) + " GB";
            }
            else
            {
                return Math.Round(((Decimal)size / rankTB), 2, MidpointRounding.AwayFromZero) + " TB";
            }
        }

        public static String ConvertObjToString(Object obj)
        {
            if (obj == null)
            {
                return "";
            }
            else
            {
                return obj.ToString().Trim();
            }
        }
    }
}
