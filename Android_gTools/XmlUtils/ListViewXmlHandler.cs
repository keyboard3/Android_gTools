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
    public class ListViewXmlHandler : BaseXmlHandler
    {
        public static String modifier = "private";
        public static String prefix = "";
        public static String subffix = "";
        public static bool isUpper = false;
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
                    entity = new ListViewXmlHandler();
                }
            }
            return entity;
        }

        private ListViewXmlHandler()
        {
            //RegexStr = "\bid\b|\btext\b";
        }

        public override string handler(ElementEntity tnode)
        {
            List<ElementEntity> list = XmlTreeHandler.getAllElement(tnode, XmlTreeHandler.elementStatus.hasId);
            //生成getViewItem中的部分代码
            StringBuilder builder =new StringBuilder();
            builder.Append("\n\n\n");
            //生成viewHolder对象
            builder.Append(getViewHoler(list));
            return builder.ToString();
        }

        private String getViewHoler(List<ElementEntity> list)
        {
            string result = "";
            StringBuilder builder = new StringBuilder();

            foreach (var item in list)
            {
                String id = item.id;
                if (isUpper)//首字母是否大写
                {
                    id = item.id.firstToUpper();
                }
                builder.Append(string.Format("\n            " + modifier + " {1} " + prefix + "{0}" + subffix + ";", id, item.type));
            }
            StringBuilder tempbuilder = new StringBuilder();

            foreach (var item in list)
            {
                String id = item.id;
                if (isUpper)//首字母是否大写
                {
                    id = item.id.firstToUpper();
                }
                tempbuilder.Append(string.Format("\n                this." + prefix + "{0} = ({1}) convertView.findViewById(R.id.{0});", id,
                    item.type));
            }
            result = string.Format(@"
        class ViewHoler {{{0}
            public ViewHoler(View convertView){{{1}  
                convertView.setTag(this);           
            }}
        }}", builder, tempbuilder);
            return result;
        }

        [Obsolete]
        private StringBuilder getView(List<ElementEntity> list)
        {
            StringBuilder builder = new StringBuilder();
            
            builder.Append(string.Format(@"
        @Override
		public View getView(int position, View convertView, ViewGroup parent) {{
            ViewHoler holer;
            if (convertView == null) {{
                    //convertView = View.inflate(mActivity, R.layout.list_**, null);
                    holer = new ViewHoler();
            }} else {{
                    holer = (ViewHoler) convertView.getTag();
            }}
            //自行填写完整
			return convertView;
		}}
            "));

            return builder;
        }
    }
}