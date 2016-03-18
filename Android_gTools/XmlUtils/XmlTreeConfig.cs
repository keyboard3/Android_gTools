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
    public class XmlTreeConfig
    {
        public XmlTreeConfig(TreeView treeView)
        {
            this.treeView = treeView;
        }
        
        TreeView treeView =null;
        XmlDocument doc;
        XmlElement root = null;
        TreeNode rootNode;
        string oldText = "";
        /// <summary>
        /// 去掉不正常的xml信息，保留正常的
        /// </summary>
        /// <param name="xmlOldStr"></param>
        public void Init(string xmlOldStr)
        {
            oldText = xmlOldStr;
            oldText = Regex.Replace(oldText, @"<!--([\S\s]+?)-->", "");
            oldText = Regex.Replace(oldText, @"<\?xml.+\?>", "");
            if (!oldText.Contains("root"))
                oldText = "<root xmlns:android=\"http://schemas.android.com/apk/res/android\">" + oldText + "</root>";
            InitTree();
        }
        /// <summary>
        /// 初始化xml文档结构
        /// </summary>
        private void InitTree()
        {
            /*
             * 主要思想就是：递归解析xml生成树节点，树节点绑定了布局元素信息对象
             */
            treeView.Nodes.Clear();
            //xml文档=结构
            doc = new XmlDocument();
            doc.LoadXml(oldText);
            root = doc.DocumentElement;

            ElementEntity rootElementEntity = new ElementEntity();
            
            rootNode = new TreeNode();
            rootNode.Text = root.Name;
            rootNode.Tag = rootElementEntity;

            searchThree(root, rootNode,rootElementEntity);
            treeView.Nodes.Add(rootNode);
            treeView.ExpandAll();
            treeView.SelectedNode = rootNode;
        }
        /// <summary>
        /// 递归加载树结构
        /// </summary>
        /// <param name="root"></param>
        /// <param name="rootNode"></param>
        private void searchThree(XmlNode root, TreeNode rootNode,ElementEntity element)
        {
            foreach (XmlNode item in root.ChildNodes)
            {
                //初始化当前结点
                TreeNode tNode = new TreeNode();
                tNode.Text = item.Name;
                //处理布局元素对象
                ElementEntity elementitem = XmlTreeHandler.XmlNodeToElement(item);
                element.addElement(elementitem);

                tNode.Tag = elementitem;//树里面放布局元素对象
                rootNode.Nodes.Add(tNode);
                //处理该结点的子节点
                searchThree(item, tNode, elementitem);
            }
        }
    }
}
