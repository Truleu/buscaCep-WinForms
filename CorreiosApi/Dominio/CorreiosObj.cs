using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorreiosApi.Dominio
{
    public class CorreiosObj 
    {
        [JsonProperty("uf")]
        public string Uf { get; set; }
        [JsonProperty("localidade")]
        public string Localidade { get; set; }
        [JsonProperty("logradouroDNEC")]
        public string LogradouroDNEC { get; set; }
        [JsonProperty("bairro")]
        public string Bairro { get; set; }
        [JsonProperty("cep")]
        public string Cep { get; set; }

    }
}
