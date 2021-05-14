using CorreiosApi.Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CorreiosApi.API
{
    public class ReqEstados
    {
        public HttpWebRequest Criar(string metodo)
        {
            var link = "https://servicodados.ibge.gov.br/api/v1/localidades/estados";
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = metodo;

            return request;
        }
        public List<EstadosObj> Obter()
        {
            var req = Criar("GET");
            List<EstadosObj> resposta;

            try
            {
                using (var res = req.GetResponse())
                {
                    var strm = res.GetResponseStream();
                    var srmR = new StreamReader(strm);

                    var strResponse = srmR.ReadToEnd();

                    resposta = JsonConvert.DeserializeObject<List<EstadosObj>>(strResponse);
                }
                return resposta;
            } catch (WebException)
            {
                List<EstadosObj> falhou = new List<EstadosObj>();
                return falhou;
            }
        }
    }
}
