using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Android_gTools.DoMain;

namespace Android_gTools.XmlUtils
{
    /// <summary>
    /// 基本废弃 单击OnClick方法提取提取类  
    /// </summary>
    [Obsolete]
    public class OnClickXmlHandler:BaseXmlHandler
    {
        public static String lockVarible = "0";
        private static BaseXmlHandler entity = null;
        /// <summary>
        /// 单例模式获取
        /// </summary>
        /// <returns></returns>
        public static BaseXmlHandler getInstance()
        {
            if (entity == null)
            {
                lock (lockVarible)
                {
                    entity = new OnClickXmlHandler();
                }
            }
            return entity;
        }
        private OnClickXmlHandler()
        {
            RegexStr = "";
        }

        public override string handler(ElementEntity tnode)
        {
            StringBuilder builder=new StringBuilder();
            foreach (var item in XmlTreeHandler.getAllElement(tnode))
            {
                if (item.hasAttribute("android:onClick") && item.hasAttribute("android:text"))
                {
                    builder.Append(string.Format("\t\t\t/**\n\t\t\t* {0}\n\t\t\t* @param view\n\t\t\t*/\n\t\t\t", item.getAttribute("android:text")));
                }
                if (item.hasAttribute("android:onClick"))
                {
                    builder.Append(string.Format("public void {0}(View view){{\n\t\n\t\t\t}}\n", item.getAttribute("android:onClick")));
                }
            }
            return builder.ToString();
        }
    }
}
