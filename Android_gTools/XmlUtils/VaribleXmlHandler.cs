using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Android_gTools.DoMain;
using Android_gTools.Utils;

namespace Android_gTools.XmlUtils
{
    /// <summary>
    /// 变量提取
    /// </summary>
    public class VaribleXmlHandler : BaseXmlHandler
    {
        public enum javaTypeEnum
        {
            standard = 0,
            annotations = 1,
            xutils = 2
        }
        public static javaTypeEnum type = javaTypeEnum.standard;
        public static String modifier = "private";
        public static String prefix = "";
        public static String subffix = "";
        public static String lockVarible = "0";
        public static bool isUpper = false;
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
                    entity = new VaribleXmlHandler();
                }
            }
            return entity;
        }

        private VaribleXmlHandler()
        {
            RegexStr = "";
        }

        public override string excute(TreeNode tnode)
        {
            declaration.init("");//声明数组
            definition.init("");//定义数组
            string result = base.excute(tnode);
            switch (type)
            {
                case javaTypeEnum.standard:
                    result = "/*变量声明*/\n" + declaration.toString("") +
                    "\n\n/*变量定义*/\n" + string.Format(@"  private void bindViews() {{
       {0}    }}
", definition.toString(""));
                    break;
                case javaTypeEnum.annotations:
                    result = "/*变量声明*/\n" + declaration.toString("");
                    break;
                case javaTypeEnum.xutils:
                    result = "/*变量声明*/\n" + declaration.toString("");
                    break;
            }
           
            return result;
        }

        ArrayJoinUtil declaration = new ArrayJoinUtil();//声明数组
        ArrayJoinUtil definition = new ArrayJoinUtil();//定义数组
        public override string handler(ElementEntity tnode)
        {

            foreach (var item in XmlTreeHandler.getAllElement(tnode, XmlTreeHandler.elementStatus.hasId))
            {
                String resultDeclaration = "";
                String resultdefinition = "";
                String id = item.id;
                if (isUpper)//首字母是否大写
                {
                    id = item.id.firstToUpper();
                }
                switch (type)
                {
                    case javaTypeEnum.standard:
                        resultDeclaration = String.Format("" + modifier + " {0} " + prefix + "{1}" + subffix + ";\n", item.type, id);
                        resultdefinition = String.Format("" + prefix + "{0}=({1}) findViewById(R.id.{2});\n", id, item.type,item.id);
                        break;
                    case javaTypeEnum.annotations:
                        resultDeclaration = String.Format(@"    
    @ViewById
   {2} {0} {1};", item.type, item.id,modifier);
                        break;
                    case javaTypeEnum.xutils:
                        resultDeclaration = String.Format(@"
@ViewInject(R.id.{0})  
    "+modifier+" {1} " + prefix + "{2};" + subffix+"", item.id, item.type,id);
                        break; 
                }
                declaration.add(resultDeclaration);
                definition.add(resultdefinition);
            }
            return "";
        }
    }
}
