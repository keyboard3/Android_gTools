using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Android_gTools.JsonUtils
{
    public class JsonUtil
    {
        public static string parseJson(string str)
        {
            string result = "";
            try
            {
                result = parseJObject(getName(), str);
            }
            catch (Exception)
            {
            }
            return result;
        }

        public static int ID=0;
        public static string Name = "Javaben";

        public static string  getName()
        {
            if (ID == 0)
            {
                return Name;
            }
            return Name+(++ID);
        }

        private static string parseJObject(string name,string value)
        {
            string result = "";
            try
            {
                string temp = "";
                JObject obj = JObject.Parse(value);
                foreach (JProperty prop in obj.Properties())
                {
                    JToken token = prop.Value;
                    if (token.Type == JTokenType.Object)
                    {
                        temp += parseJObject(prop.Name, token.ToString()) + "\n";
                    }
                    else if (token.Type == JTokenType.Array)
                    {
                        temp += parseJArray(prop.Name, token.ToString()) + "\n";
                    }
                    else
                    {
                        temp += parseJValue(token.Type.ToString(), prop.Name);
                    }
                }
                result = string.Format("\npublic class {0}{{\n{1}}}\n", name, temp);
            }
            catch (Exception)
            {
                result = "";
            }
            return result;
        }
        private static string parseJArray(string name, string value)
        {
            string result = "";
            try
            {
                string className = getName();
                result = string.Format("\npublic ArrayList<{0}> {1};\n", className, name);
                JArray array = JArray.Parse(value);
                JObject item = array.Children<JObject>().First();
                result += parseJObject(className, item.ToString());
            }
            catch (Exception)
            {
                result = "";
            }
            return result;
        }

        private static string parseJValue(string name, string value)
        {
            return string.Format("public {0} {1};\n", name, value);
        }
    }
}