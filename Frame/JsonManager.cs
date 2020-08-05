using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Frame
{
    class JsonManager
    {

        private JsonManager()
        {
        }

        public static List<string> GetChromeJsonValue(string name)
        {
            string jsonString = File.ReadAllText(name);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            return ser.Deserialize<List<string>>(jsonString);
        }

        public static JObject GetConfiguration(string name)
        {
            string jsonString = File.ReadAllText(name);
            return JObject.Parse(jsonString);
        }
    }
}