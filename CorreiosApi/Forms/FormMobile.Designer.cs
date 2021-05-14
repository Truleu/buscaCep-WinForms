
namespace CorreiosApi.Forms
{
    partial class FormMobile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMobile));
            this.textMobResultado = new System.Windows.Forms.RichTextBox();
            this.textMobEndCep = new System.Windows.Forms.MaskedTextBox();
            this.pesquisaMobCep = new System.Windows.Forms.Button();
            this.pesquisaMobLabel = new System.Windows.Forms.Label();
            this.retornaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textMobResultado
            // 
            this.textMobResultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textMobResultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.textMobResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMobResultado.Location = new System.Drawing.Point(17, 72);
            this.textMobResultado.Name = "textMobResultado";
            this.textMobResultado.ReadOnly = true;
            this.textMobResultado.Size = new System.Drawing.Size(367, 400);
            this.textMobResultado.TabIndex = 2;
            this.textMobResultado.TabStop = false;
            this.textMobResultado.Text = "";
            // 
            // textMobEndCep
            // 
            this.textMobEndCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textMobEndCep.Location = new System.Drawing.Point(34, 514);
            this.textMobEndCep.Name = "textMobEndCep";
            this.textMobEndCep.Size = new System.Drawing.Size(335, 22);
            this.textMobEndCep.TabIndex = 7;
            // 
            // pesquisaMobCep
            // 
            this.pesquisaMobCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pesquisaMobCep.BackColor = System.Drawing.Color.RoyalBlue;
            this.pesquisaMobCep.Font = new System.Drawing.Font("Courier New", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaMobCep.ForeColor = System.Drawing.Color.White;
            this.pesquisaMobCep.Location = new System.Drawing.Point(127, 547);
            this.pesquisaMobCep.Name = "pesquisaMobCep";
            this.pesquisaMobCep.Size = new System.Drawing.Size(150, 58);
            this.pesquisaMobCep.TabIndex = 8;
            this.pesquisaMobCep.Text = "Buscar";
            this.pesquisaMobCep.UseVisualStyleBackColor = false;
            this.pesquisaMobCep.Click += new System.EventHandler(this.pesquisaMobCep_Click);
            // 
            // pesquisaMobLabel
            // 
            this.pesquisaMobLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pesquisaMobLabel.AutoSize = true;
            this.pesquisaMobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaMobLabel.Location = new System.Drawing.Point(47, 487);
            this.pesquisaMobLabel.Name = "pesquisaMobLabel";
            this.pesquisaMobLabel.Size = new System.Drawing.Size(275, 20);
            this.pesquisaMobLabel.TabIndex = 9;
            this.pesquisaMobLabel.Text = "Digite um CEP ou um Endereço";
            // 
            // retornaButton
            // 
            this.retornaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.retornaButton.Location = new System.Drawing.Point(23, 12);
            this.retornaButton.Name = "retornaButton";
            this.retornaButton.Size = new System.Drawing.Size(75, 40);
            this.retornaButton.TabIndex = 10;
            this.retornaButton.Text = "<- Volta";
            this.retornaButton.UseVisualStyleBackColor = true;
            this.retornaButton.Click += new System.EventHandler(this.retornaButton_Click);
            // 
            // FormMobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(402, 620);
            this.Controls.Add(this.retornaButton);
            this.Controls.Add(this.pesquisaMobLabel);
            this.Controls.Add(this.pesquisaMobCep);
            this.Controls.Add(this.textMobEndCep);
            this.Controls.Add(this.textMobResultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 667);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 667);
            this.Name = "FormMobile";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMobile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private string inputUser;

        #endregion

        private System.Windows.Forms.RichTextBox textMobResultado;
        private System.Windows.Forms.MaskedTextBox textMobEndCep;
        private System.Windows.Forms.Button pesquisaMobCep;
        private System.Windows.Forms.Label pesquisaMobLabel;
        private System.Windows.Forms.Button retornaButton;
    }
}