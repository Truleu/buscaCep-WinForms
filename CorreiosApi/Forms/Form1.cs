using CorreiosApi.API;
using CorreiosApi.Dominio;
using CorreiosApi.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace CorreiosApi
{
    public partial class Form1 : Form
    {
        Requisicao requisicao = new Requisicao();
        ReqEstados reqEstados = new ReqEstados();
        ReqMunicUF reqMunic = new ReqMunicUF();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var requisits = new ReqEstados().Obter();
            estadoBox.Items.Add("");
            foreach (var requisit in requisits)
            {
                estadoBox.Items.Add(requisit.Sigla);
            }
            RadioButton[] radioButtons = new RadioButton[] { cepButton, enderecoButton };
            if (!radioButtons.Any(rb => rb.Checked))
            {
                estadoBox.Enabled = false;
                cidadeBox.Enabled = false;
                textCep.Enabled = false;
            }
        }

        private void cepButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cepButton.Checked)
            {
                estadoBox.Text = "";
                cidadeBox.Text = "";
                estadoBox.Enabled = false;
                cidadeBox.Enabled = false;
                textCep.Enabled = true;
                textCep.Clear();
                textResultado.Clear();
                cepLabel.Visible = true;
                endLabel.Visible = false;
            }
        }
        private void enderecoButton_CheckedChanged(object sender, EventArgs e)
        {
            if (enderecoButton.Checked)
            {
                estadoBox.Enabled = true;
                cidadeBox.Enabled = false;
                textCep.Enabled = false;
                estadoBox.Text = "";
                cidadeBox.Text = "";
                textCep.Clear();
                textCep.Mask = "";
                textResultado.Clear();
                endLabel.Visible = true;
                cepLabel.Visible = false;
            }
        }
        private void textCep_KeyDown(object sender, KeyPressEventArgs e)
        {
            int i;
            if (cepButton.Checked)
            {
                if (int.TryParse(e.KeyChar.ToString(), out i))
                {
                    textCep.Mask = "00000-000";
                }
            }
        }
        private void pesquisaCep_Click(object sender, EventArgs e)
        {
            textResultado.Clear();

            string requiString;
            this.inputUser = textCep.Text;
            if (!String.IsNullOrEmpty(inputUser))
            {
                requisicao.UrlBase(inputUser);
            }
            else
            {
                MessageBox.Show("Preencha o campo de pesquisa", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var requi = requisicao.Obter();
            try
            {
                if (requi.Cep == null)
                {
                    if (enderecoButton.Checked)
                    {
                    requisicao.UrlEnd(estadoBox.SelectedItem.ToString(), cidadeBox.SelectedItem.ToString(), inputUser);
                    var requiEnd = requisicao.ObterEnd();
                        foreach (var requiE in requiEnd)
                        {
                            var requiStringEnd = $"CEP: {requiE.Cep} \r\nLogradouro: {requiE.Logradouro} \r\nComplemento: {requiE.Complemento} \r\nBairro: {requiE.Bairro} \r\nLocalidade: {requiE.Localidade} \r\nUF: {requiE.Uf} \r\nDDD: {requiE.Ddd} \r\n-\r\n";
                            textResultado.AppendText(requiStringEnd);
                        }
                    }
                    else
                    {
                        textResultado.Font = new Font("Arial", 18, FontStyle.Bold);
                        textResultado.ForeColor = System.Drawing.Color.DarkRed;
                        textResultado.AppendText("CEP não encontrado");
                    }
                    return;
                }
                else
                {
                    requiString = $"CEP: {requi.Cep} \r\nLogradouro: {requi.Logradouro} \r\nComplemento: {requi.Complemento} \r\nBairro: {requi.Bairro} \r\nLocalidade: {requi.Localidade} \r\nUF: {requi.Uf} \r\nDDD: {requi.Ddd}";
                    textResultado.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
                    textResultado.ForeColor = System.Drawing.Color.Black;
                    textResultado.AppendText(requiString);
                }
            }
            catch
            {
                textResultado.Font = new Font("Arial", 18, FontStyle.Bold);
                textResultado.ForeColor = System.Drawing.Color.DarkRed;
                textResultado.AppendText("CEP não encontrado");
            }
        }

        private void estadoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectEst = estadoBox.SelectedItem.ToString();
            reqMunic.UrlBase(selectEst);
            var requiMunics = new ReqMunicUF().Obter();
            cidadeBox.Items.Clear();
            foreach (var requiMunic in requiMunics)
            {
                cidadeBox.Items.Add(requiMunic.Nome);
            }
            if (estadoBox.SelectedIndex > -1)
            {
                cidadeBox.Enabled = true;
            }
        }
        private void cidadeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cidadeBox.SelectedIndex > -1)
            {
                textCep.Enabled = true;
            }
        }

        private void buscaMobButton_Click(object sender, EventArgs e)
        {
            FormMobile formMobile = new FormMobile();
            formMobile.ShowDialog();
        }
    }
}
