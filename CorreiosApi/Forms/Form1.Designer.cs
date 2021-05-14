
namespace CorreiosApi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pesquisaCep = new System.Windows.Forms.Button();
            this.estadoBox = new System.Windows.Forms.ComboBox();
            this.cidadeBox = new System.Windows.Forms.ComboBox();
            this.cepButton = new System.Windows.Forms.RadioButton();
            this.enderecoButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.ufLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textCep = new System.Windows.Forms.MaskedTextBox();
            this.textResultado = new System.Windows.Forms.RichTextBox();
            this.tipUf = new System.Windows.Forms.ToolTip(this.components);
            this.cepLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.buscaMobButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pesquisaCep
            // 
            this.pesquisaCep.Location = new System.Drawing.Point(177, 380);
            this.pesquisaCep.Name = "pesquisaCep";
            this.pesquisaCep.Size = new System.Drawing.Size(104, 58);
            this.pesquisaCep.TabIndex = 7;
            this.pesquisaCep.Text = "Busca";
            this.pesquisaCep.UseVisualStyleBackColor = true;
            this.pesquisaCep.Click += new System.EventHandler(this.pesquisaCep_Click);
            // 
            // estadoBox
            // 
            this.estadoBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.estadoBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.estadoBox.DropDownHeight = 120;
            this.estadoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoBox.DropDownWidth = 50;
            this.estadoBox.FormattingEnabled = true;
            this.estadoBox.IntegralHeight = false;
            this.estadoBox.Location = new System.Drawing.Point(90, 220);
            this.estadoBox.Name = "estadoBox";
            this.estadoBox.Size = new System.Drawing.Size(56, 24);
            this.estadoBox.Sorted = true;
            this.estadoBox.TabIndex = 4;
            this.estadoBox.SelectedIndexChanged += new System.EventHandler(this.estadoBox_SelectedIndexChanged);
            // 
            // cidadeBox
            // 
            this.cidadeBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cidadeBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cidadeBox.DropDownHeight = 120;
            this.cidadeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cidadeBox.FormattingEnabled = true;
            this.cidadeBox.IntegralHeight = false;
            this.cidadeBox.Location = new System.Drawing.Point(177, 220);
            this.cidadeBox.Name = "cidadeBox";
            this.cidadeBox.Size = new System.Drawing.Size(200, 24);
            this.cidadeBox.Sorted = true;
            this.cidadeBox.TabIndex = 5;
            this.cidadeBox.SelectedIndexChanged += new System.EventHandler(this.cidadeBox_SelectedIndexChanged);
            // 
            // cepButton
            // 
            this.cepButton.AutoSize = true;
            this.cepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cepButton.Location = new System.Drawing.Point(45, 57);
            this.cepButton.Name = "cepButton";
            this.cepButton.Size = new System.Drawing.Size(56, 21);
            this.cepButton.TabIndex = 2;
            this.cepButton.Text = "CEP";
            this.cepButton.UseVisualStyleBackColor = true;
            this.cepButton.CheckedChanged += new System.EventHandler(this.cepButton_CheckedChanged);
            // 
            // enderecoButton
            // 
            this.enderecoButton.AutoSize = true;
            this.enderecoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoButton.Location = new System.Drawing.Point(195, 57);
            this.enderecoButton.Name = "enderecoButton";
            this.enderecoButton.Size = new System.Drawing.Size(90, 21);
            this.enderecoButton.TabIndex = 3;
            this.enderecoButton.Text = "Endereço";
            this.enderecoButton.UseVisualStyleBackColor = true;
            this.enderecoButton.CheckedChanged += new System.EventHandler(this.enderecoButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cepButton);
            this.groupBox1.Controls.Add(this.enderecoButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "     Escolha como será feita a consulta";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(550, 106);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(131, 29);
            this.Resultado.TabIndex = 8;
            this.Resultado.Text = "Resultado";
            // 
            // ufLabel
            // 
            this.ufLabel.AutoSize = true;
            this.ufLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ufLabel.Location = new System.Drawing.Point(102, 190);
            this.ufLabel.Name = "ufLabel";
            this.ufLabel.Size = new System.Drawing.Size(33, 20);
            this.ufLabel.TabIndex = 10;
            this.ufLabel.Text = "UF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Município";
            // 
            // textCep
            // 
            this.textCep.Location = new System.Drawing.Point(90, 311);
            this.textCep.Name = "textCep";
            this.textCep.Size = new System.Drawing.Size(287, 22);
            this.textCep.TabIndex = 6;
            this.textCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCep_KeyDown);
            // 
            // textResultado
            // 
            this.textResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResultado.Location = new System.Drawing.Point(435, 155);
            this.textResultado.Name = "textResultado";
            this.textResultado.ReadOnly = true;
            this.textResultado.Size = new System.Drawing.Size(367, 344);
            this.textResultado.TabIndex = 9;
            this.textResultado.Text = "";
            // 
            // tipUf
            // 
            this.tipUf.Tag = "5";
            // 
            // cepLabel
            // 
            this.cepLabel.AutoSize = true;
            this.cepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cepLabel.Location = new System.Drawing.Point(160, 288);
            this.cepLabel.Name = "cepLabel";
            this.cepLabel.Size = new System.Drawing.Size(118, 20);
            this.cepLabel.TabIndex = 12;
            this.cepLabel.Text = "Digite o CEP";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(160, 288);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(114, 20);
            this.endLabel.TabIndex = 13;
            this.endLabel.Text = "Digite a Rua";
            // 
            // buscaMobButton
            // 
            this.buscaMobButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscaMobButton.Location = new System.Drawing.Point(736, 11);
            this.buscaMobButton.Name = "buscaMobButton";
            this.buscaMobButton.Size = new System.Drawing.Size(95, 45);
            this.buscaMobButton.TabIndex = 14;
            this.buscaMobButton.Text = "Busca CEP Mobile";
            this.buscaMobButton.UseVisualStyleBackColor = true;
            this.buscaMobButton.Click += new System.EventHandler(this.buscaMobButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 528);
            this.Controls.Add(this.buscaMobButton);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.cepLabel);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.textCep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ufLabel);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.cidadeBox);
            this.Controls.Add(this.estadoBox);
            this.Controls.Add(this.pesquisaCep);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private string inputUser;

        #endregion
        private System.Windows.Forms.Button pesquisaCep;
        private System.Windows.Forms.ComboBox estadoBox;
        private System.Windows.Forms.ComboBox cidadeBox;
        private System.Windows.Forms.RadioButton cepButton;
        private System.Windows.Forms.RadioButton enderecoButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Label ufLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textCep;
        private System.Windows.Forms.RichTextBox textResultado;
        private System.Windows.Forms.ToolTip tipUf;
        private System.Windows.Forms.Label cepLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Button buscaMobButton;
    }
}

