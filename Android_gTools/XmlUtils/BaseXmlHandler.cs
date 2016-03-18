using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Android_gTools.DoMain;

namespace Android_gTools.XmlUtils
{
    /// <summary>
    /// 处理安卓布局xml处理的基类
    /// </summary>
    public abstract class BaseXmlHandler
    {
        public string RegexStr = "";

        /// <summary>
        /// 根据结点处理字符串
        /// </summary>
        /// <param name="tnode"></param>
        /// <returns></returns>
        public virtual string excute(TreeNode tnode)
        {
            ElementEntity node = tnode.Tag as ElementEntity;
            return handler(node);
        }

        public abstract string handler(ElementEntity tnode);
    }
}
    