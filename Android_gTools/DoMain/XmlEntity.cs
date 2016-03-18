using System;
using System.Collections.Generic;

namespace Android_gTools.DoMain
{
    /// <summary>
    /// android布局元素类
    /// </summary>
    public class ElementEntity
    {
        //item属性集合
        private Dictionary<string, string> DicItem = new Dictionary<string, string>();
        //孩子集合
        public List<ElementEntity> Elements = new List<ElementEntity>();
        public string id;
        public string type;

        /// <summary>
        ///     添加儿子
        /// </summary>
        /// <param name="entity"></param>
        public void addElement(ElementEntity entity)
        {
            Elements.Add(entity);
        }

        /// <summary>
        /// 添加属性
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void addAttribute(string name, string value)
        {
            DicItem[name] = value;
        }

        public bool hasAttribute(string name)
        {
            return DicItem.ContainsKey(name);
        }
        /// <summary>
        /// 获取属性
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string getAttribute(string name)
        {
            string result = "";
            if (DicItem.ContainsKey(name))
            {
                result = DicItem[name];
            }
            return result;
        }

        public Dictionary<string, string> getAttributes()
        {
            return DicItem;
        }
    }
}