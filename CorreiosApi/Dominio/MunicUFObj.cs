using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorreiosApi
{
    public class MunicUFObj
    {
        [JsonProperty("nome")]
        public string Nome { get; set; }
    }
}
