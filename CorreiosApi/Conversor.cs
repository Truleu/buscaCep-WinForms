using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorreiosApi
{
    public static class Conversor
    {
        public static string Dump(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
