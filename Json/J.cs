using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Json
{
    public class J
    {
        public static void Ser<T>(string path,T obj) => File.WriteAllText(path,JsonConvert.SerializeObject(obj));
        public  static T Des<T>(string path)
        {
            if (!File.Exists(path))
                File.WriteAllText(path, "");
                return JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
        }
    }
}
