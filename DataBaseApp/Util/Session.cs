using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionUtil
{
    public class Session
    {
        private static Dictionary<String, Object> tempDT = null;
        public Session()
        {

        }

        private static void createDT()
        {
            tempDT = new Dictionary<string, object>();
        }

        public static void put(String key, Object value)
        {
            if (tempDT == null)
            {
                createDT();
            }
            if (check(key))
            {
                remove(key);
            }
            tempDT.Add(key, value);
        }

        public static Object get(String key)
        {
            if (tempDT == null)
            {
                createDT();
            }
            return tempDT.Where(t => t.Key.Equals(key)).First().Value;
        }

        public static Boolean remove(String key)
        {
            if (tempDT == null)
            {
                createDT();
            }

            return tempDT.Remove(key);

        }

        public static Boolean check(String key)
        {
            if (tempDT == null)
            {
                createDT();
            }
            return tempDT.Keys.Contains(key);
        }

        private static string ConvertObjectToString(object value)
        {
            try
            {
                if (value != null)
                {
                    return value.ToString().Trim();
                }
            }
            catch { }
            return "";
        }
    }
}
