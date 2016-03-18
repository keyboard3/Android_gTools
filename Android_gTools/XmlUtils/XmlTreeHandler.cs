using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Android_gTools.DoMain;

namespace Android_gTools.XmlUtils
{
    public class XmlTreeHandler
    {
        /// <summary>
        /// 将xmlNode转化为布局元素
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static ElementEntity XmlNodeToElement(XmlNode node)
        {
            ElementEntity elementEntity=new ElementEntity();
            if (node != null)
            {
                 //转化属性
                XmlAttribute id_attribute = node.Attributes["android:id"];

                //转化基本信息
                elementEntity.type=node.Name;
                if (id_attribute != null)
                {
                    elementEntity.id = id_attribute.Value.Replace("@+id/", "");
                }
               
                //转化所有子信息
                //处理当前结点
                foreach (XmlAttribute item in node.Attributes)
                {
                    elementEntity.addAttribute(item.Name, item.InnerText);
                }
            }
            return elementEntity;
        }
        /// <summary>
        /// 获取当前结点下的所有子元素
        /// </summary>
        /// <param name="rootEntity"></param>
        /// <returns></returns>
        public static List<ElementEntity> getAllElement(ElementEntity rootEntity, elementStatus status = elementStatus.noId)
        {
            bool isOk = false;
            List<ElementEntity> list=new List<ElementEntity>();
            if (status == elementStatus.hasId)
            {
                isOk = true;
            }
            if (!(isOk && string.IsNullOrEmpty(rootEntity.id)))
            {
                list.Add(rootEntity);
            }
            foreach (var item in rootEntity.Elements)
            {
                
                list.AddRange(getAllElement(item,status));
            }
            return list;
        }

        /// <summary>
        /// 布局元素集合的状态
        /// </summary>
        public enum elementStatus
        {
            /// <summary>
            /// 只有id的集合
            /// </summary>
            hasId=1<<1,
            /// <summary>
            /// 包括没有id的集合
            /// </summary>
            noId=1<<2
        }
    }
}
