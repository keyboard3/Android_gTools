using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Android_gTools.Utils
{
    /**
     * String工具类
     */
    public static class StringUtil
    {
        public static String firstToUpper(this string value)
        {
            String result = value.Substring(0,1).ToUpper()+value.Substring(1);
            return result;
        }
    }
}
