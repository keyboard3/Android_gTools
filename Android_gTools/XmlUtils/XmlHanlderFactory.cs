using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Android_gTools.XmlUtils
{
    /// <summary>
    /// xml处理的工厂类
    /// </summary>
    public class XmlHanlderFactory
    {
        public static BaseXmlHandler getOnClickXmlHandler()
        {
            return OnClickXmlHandler.getInstance();
        }
        public static BaseXmlHandler getStyleXmlHandler()
        {
            return StyleXmlHandler.getInstance();
        }
        public static BaseXmlHandler getVaribleXmlHandler()
        {
            return VaribleXmlHandler.getInstance();
        }

        public static BaseXmlHandler getListViewXmlHandler()
        {
            return ListViewXmlHandler.getInstance();
        }
    }
}
