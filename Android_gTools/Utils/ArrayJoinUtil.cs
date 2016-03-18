using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Android_gTools.Utils
{
    /// <summary>
    ///     数组字符串工具
    /// </summary>
    public class ArrayJoinUtil
    {
        public List<string> mWords = new List<string>();
        public string oldWords;

        /// <summary>
        ///     初始化内部数据
        /// </summary>
        /// <param name="StrWords"></param>
        public void init(string StrWords)
        {
            mWords.Clear();
            oldWords = StrWords;
            var words = StrWords.Split(',');
            mWords.AddRange(words);
        }

        /// <summary>
        ///     添加一个词
        /// </summary>
        /// <param name="Word"></param>
        /// <returns></returns>
        public bool add(string Word)
        {
            var isOk = false;
            if (!string.IsNullOrEmpty(Word)&&!hasKey(Word))
            {
                isOk = true;
                mWords.Add(Word);
            }
            return isOk;
        }

        /// <summary>
        ///     是否包含这个词
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool hasKey(string key)
        {
            bool isOk = false;
            if (oldWords != "")
            {
                isOk = Regex.IsMatch(key, string.Join("|", mWords));
            }
            return isOk;
        }

        /// <summary>
        ///     转化为字符串
        /// </summary>
        /// <returns></returns>
        public string toString(string join=",")
        {
            return string.Join(join, mWords);
        }
    }
}