using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetApplicationStarterPack.sunjava1.General
{
    public static class ObjectPack
    {
        public static T DeepCopy<T>(this object obj)
        {
            string str = JsonConvert.SerializeObject(obj);
            return JsonConvert.DeserializeObject<T>(str);
        }
    }
}
