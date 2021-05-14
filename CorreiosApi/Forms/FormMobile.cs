using CorreiosApi.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorreiosApi.Forms
{
    public partial class FormMobile : Form
    {
        Requisicao requisicao = new Requisicao();
        public FormMobile()
        {
            InitializeComponent();
            this.Text = "Nokia 2280";
        }

        private void pesquisaMobCep_Click(object sender, EventArgs e)
        {
            textMobResultado.Clear();

            string requiString;
            this.inputUser = textMobEndCep.Text.ToString();
            if (!String.IsNullOrEmpty(inputUser))
            {
                requisicao.UrlCorreios(inputUser);
            }
            else
            {
                textMobResultado.Font = new Font("Arial", 18, FontStyle.Bold);
                textMobResultado.ForeColor = System.Drawing.Color.DarkRed;
                textMobResultado.AppendText("Preencha o campo de pesquisa");
                return;
            }
            var requis = requisicao.ObterCorreios();
            textMobResultado.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            textMobResultado.ForeColor = System.Drawing.Color.Black;
            foreach (var requi in requis.Dados)
            {
                requiString = $"CEP: {requi.Cep} \r\nLogradouro: {requi.LogradouroDNEC} \r\nBairro: {requi.Bairro} \r\nLocalidade: {requi.Localidade} \r\nUF: {requi.Uf} \r\n-\r\n";
                textMobResultado.AppendText(requiString);
            }

        }

        private void retornaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
