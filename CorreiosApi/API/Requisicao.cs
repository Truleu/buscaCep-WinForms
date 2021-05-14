using CorreiosApi.Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace CorreiosApi.API
{
    public class Requisicao
    {
        private static string linkCompleto;
        public string UrlBase(string inputUser)
        {
            linkCompleto = $"https://viacep.com.br/ws/{inputUser}/json";
            return linkCompleto;
        }
        public string UrlEnd(string inputUf, string InputMun, string inputRua)
        {
            linkCompleto = $"https://viacep.com.br/ws/{inputUf}/{InputMun}/{inputRua}/json/";
            return linkCompleto;
        }
        public string UrlCorreios(string inputUser)
        {
            linkCompleto = $"https://buscacepinter.correios.com.br/app/endereco/carrega-cep-endereco.php?pagina=/app/endereco/index.php&cepaux=&mensagem_alerta=&endereco={inputUser}&tipoCEP=ALL";
            return linkCompleto;
        }

        public HttpWebRequest Criar(string metodo)
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp(linkCompleto);
            request.Method = metodo;

            return request;
        }

        public DadosObj Obter()
        {
            var req = Criar("GET");
            DadosObj resposta;
            try
            {
                using (var res = req.GetResponse())
                {
                    var strm = res.GetResponseStream();
                    var srmR = new StreamReader(strm);

                    var strResponse = srmR.ReadToEnd();

                    resposta = JsonConvert.DeserializeObject<DadosObj>(strResponse);
                }
                return resposta;

            }
            catch (WebException)
            {
                DadosObj falhou = new DadosObj();
                return falhou;
            }
        }

        // MÉTODO PARA BUSCA POR ENDEREÇO
        public List<DadosObj> ObterEnd()
        {
            var req = Criar("GET");
            List<DadosObj> resposta;

            try
            {
                using (var res = req.GetResponse())
                {
                    var strm = res.GetResponseStream();
                    var srmR = new StreamReader(strm);

                    var strResponse = srmR.ReadToEnd();

                    resposta = JsonConvert.DeserializeObject<List<DadosObj>>(strResponse);
                }
                return resposta;
            }
            catch (WebException)
            {
                List<DadosObj> falhou = new List<DadosObj>();
                MessageBox.Show("Digite um endereço válido", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return falhou;
            }
        }

        // MÉTODO PARA BUSCA PELO LINK DOS CORREIOS
        public CorreiosRoot ObterCorreios()
        {
            var req = Criar("GET");
            CorreiosRoot resposta;

            try
            {
                using (var res = req.GetResponse())
                {
                    var strm = res.GetResponseStream();
                    var srmR = new StreamReader(strm);

                    var strResponse = srmR.ReadToEnd();

                    resposta = JsonConvert.DeserializeObject<CorreiosRoot>(strResponse);
                }
                return resposta;
            }
            catch (WebException)
            {
                CorreiosRoot falhou = new CorreiosRoot();
                MessageBox.Show("Digite um endereço válido", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return falhou;
            }
        }
    }
}
