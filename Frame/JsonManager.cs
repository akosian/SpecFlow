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
            StreamReader sr = new StreamReader("C:\\Users\\karma\\source\\repos\\Test\\Frame\\chromeConfiguration.json");
            string jsonString = sr.ReadToEnd();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            return ser.Deserialize<List<string>>(jsonString);
        }


        public static JObject GetConfiguration()
        {
            StreamReader sr = new StreamReader("C:\\Users\\karma\\source\\repos\\Test\\Frame\\config.json");
            string jsonString = sr.ReadToEnd();
            return JObject.Parse(jsonString);
        }
    }
}