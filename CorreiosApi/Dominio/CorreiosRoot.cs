using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorreiosApi.Dominio
{
    public class CorreiosRoot
    {
        public IList<CorreiosObj> Dados { get; set; }
    }
}
