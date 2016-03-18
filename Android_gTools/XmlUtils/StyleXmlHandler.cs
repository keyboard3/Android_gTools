using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Android_gTools.DoMain;

namespace Android_gTools.XmlUtils
{
    /// <summary>
    /// 元素的样式提取类
    /// </summary>
    public class StyleXmlHandler:BaseXmlHandler
    {
        public static String styleName = "";
        public static String textRegexStr = "id";

        public static String lockVarible="0";
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
                    entity = new StyleXmlHandler();
                }
            }
            return entity;
        }
        private StyleXmlHandler()
        {
            //要过滤的名字
            RegexStr = "text";
        }

        public override string handler(ElementEntity tnode)
        {
            
            var styleBuilder = new StringBuilder();
            var oldArributeText = new StringBuilder();
           
            foreach (var itemNode in XmlTreeHandler.getAllElement(tnode))
            {
                if (itemNode.type == null) continue;
                oldArributeText.Append("<" + itemNode.type + "\n");
                //========生成style========
                styleBuilder.Append("/*样式代码*/\n\n");
                
                //头处理
                styleBuilder.Append(string.Format("<style name=\"{0}_style\">\n",styleName));
                //处理当前结点
                foreach (var item in itemNode.getAttributes())
                {
                    //不需要执行的跳过
                    if (Regex.IsMatch(item.Key, RegexStr))
                    {
                        oldArributeText.Append(String.Format("{0}=\"{1}\"\n", item.Key, item.Value));
                        continue;
                    }
                    if (Regex.IsMatch(item.Value, textRegexStr))
                    {
                        oldArributeText.Append(String.Format("{0}=\"{1}\"\n", item.Key, item.Value));
                        continue;
                    }
                    styleBuilder.Append(string.Format("<item name=\"{0}\">{1}</item>\n",
                        item.Key, item.Value));
                }
                //尾处理
                styleBuilder.Append("</style>\n\n");
                oldArributeText.Append(string.Format("android:style=\"@style/{0}_style\" />", styleName));
                styleBuilder.Append("\n\n");
                styleBuilder.Append("/*原来的xml元素代码*/\n\n");
            }
            
            return styleBuilder.Append(oldArributeText).ToString();
        }
    }
}
