using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CorreiosApi.API
{
    public class ReqMunicUF
    {
        private static string linkCompleto;
        public string UrlBase(string input)
        {
            linkCompleto = $"https://servicodados.ibge.gov.br/api/v1/localidades/estados/{input}/municipios";
            return linkCompleto;
        }

        public HttpWebRequest Criar(string metodo)
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp(linkCompleto);
            request.Method = metodo;
            Thread.Sleep(500);

            return request;
        }

        public List<MunicUFObj> Obter()
        {
            var req = Criar("GET");
            List <MunicUFObj> resposta;

            try
            {
                using (var res = req.GetResponse())
                {
                    var strm = res.GetResponseStream();
                    var srmR = new StreamReader(strm);

                    var strResponse = srmR.ReadToEnd();

                    resposta = JsonConvert.DeserializeObject<List<MunicUFObj>>(strResponse);
                }
                return resposta;
            }
            catch (WebException)
            {
                List<MunicUFObj> falhou = new List<MunicUFObj>();
                return falhou;
            }
        }
    }
}
