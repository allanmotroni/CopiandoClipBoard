namespace CopiandoClipBoard
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
            this.checkBoxSempreVisivel = new System.Windows.Forms.CheckBox();
            this.checkBoxVerificarAreaTransferencia = new System.Windows.Forms.CheckBox();
            this.richTextBoxTexto = new System.Windows.Forms.RichTextBox();
            this.timerAreaTransferencia = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.checkBoxQuebrarLinha = new System.Windows.Forms.CheckBox();
            this.linkLabelLimparAreaTransferencia = new System.Windows.Forms.LinkLabel();
            this.btnExportarTxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxSempreVisivel
            // 
            this.checkBoxSempreVisivel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxSempreVisivel.AutoSize = true;
            this.checkBoxSempreVisivel.Location = new System.Drawing.Point(214, 300);
            this.checkBoxSempreVisivel.Name = "checkBoxSempreVisivel";
            this.checkBoxSempreVisivel.Size = new System.Drawing.Size(96, 17);
            this.checkBoxSempreVisivel.TabIndex = 5;
            this.checkBoxSempreVisivel.Text = "Sempre visível";
            this.checkBoxSempreVisivel.UseVisualStyleBackColor = true;
            this.checkBoxSempreVisivel.CheckedChanged += new System.EventHandler(this.checkBoxSempreVisivel_CheckedChanged);
            // 
            // checkBoxVerificarAreaTransferencia
            // 
            this.checkBoxVerificarAreaTransferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxVerificarAreaTransferencia.AutoSize = true;
            this.checkBoxVerificarAreaTransferencia.Location = new System.Drawing.Point(12, 300);
            this.checkBoxVerificarAreaTransferencia.Name = "checkBoxVerificarAreaTransferencia";
            this.checkBoxVerificarAreaTransferencia.Size = new System.Drawing.Size(172, 17);
            this.checkBoxVerificarAreaTransferencia.TabIndex = 3;
            this.checkBoxVerificarAreaTransferencia.Text = "Verificar Área de Transferência";
            this.checkBoxVerificarAreaTransferencia.UseVisualStyleBackColor = true;
            this.checkBoxVerificarAreaTransferencia.CheckedChanged += new System.EventHandler(this.checkBoxVerificarAreaTransferencia_CheckedChanged);
            // 
            // richTextBoxTexto
            // 
            this.richTextBoxTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxTexto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxTexto.Location = new System.Drawing.Point(2, 1);
            this.richTextBoxTexto.Name = "richTextBoxTexto";
            this.richTextBoxTexto.Size = new System.Drawing.Size(318, 259);
            this.richTextBoxTexto.TabIndex = 0;
            this.richTextBoxTexto.Text = "";
            this.richTextBoxTexto.WordWrap = false;
            this.richTextBoxTexto.TextChanged += new System.EventHandler(this.richTextBoxTexto_TextChanged);
            // 
            // timerAreaTransferencia
            // 
            this.timerAreaTransferencia.Tick += new System.EventHandler(this.timerAreaTransferencia_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantidade de linhas";
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Enabled = false;
            this.labelQuantidade.Location = new System.Drawing.Point(125, 263);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(13, 13);
            this.labelQuantidade.TabIndex = 4;
            this.labelQuantidade.Text = "0";
            // 
            // checkBoxQuebrarLinha
            // 
            this.checkBoxQuebrarLinha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxQuebrarLinha.AutoSize = true;
            this.checkBoxQuebrarLinha.Location = new System.Drawing.Point(12, 323);
            this.checkBoxQuebrarLinha.Name = "checkBoxQuebrarLinha";
            this.checkBoxQuebrarLinha.Size = new System.Drawing.Size(89, 17);
            this.checkBoxQuebrarLinha.TabIndex = 4;
            this.checkBoxQuebrarLinha.Text = "Quebrar linha";
            this.checkBoxQuebrarLinha.UseVisualStyleBackColor = true;
            this.checkBoxQuebrarLinha.CheckedChanged += new System.EventHandler(this.checkBoxQuebrarLinha_CheckedChanged);
            // 
            // linkLabelLimparAreaTransferencia
            // 
            this.linkLabelLimparAreaTransferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabelLimparAreaTransferencia.AutoSize = true;
            this.linkLabelLimparAreaTransferencia.Location = new System.Drawing.Point(169, 263);
            this.linkLabelLimparAreaTransferencia.Name = "linkLabelLimparAreaTransferencia";
            this.linkLabelLimparAreaTransferencia.Size = new System.Drawing.Size(141, 13);
            this.linkLabelLimparAreaTransferencia.TabIndex = 2;
            this.linkLabelLimparAreaTransferencia.TabStop = true;
            this.linkLabelLimparAreaTransferencia.Text = "Limpar área de transferência";
            this.linkLabelLimparAreaTransferencia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLimparAreaTransferencia_LinkClicked);
            // 
            // btnExportarTxt
            // 
            this.btnExportarTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportarTxt.Location = new System.Drawing.Point(214, 323);
            this.btnExportarTxt.Name = "btnExportarTxt";
            this.btnExportarTxt.Size = new System.Drawing.Size(82, 23);
            this.btnExportarTxt.TabIndex = 6;
            this.btnExportarTxt.Text = "Exportar TXT";
            this.btnExportarTxt.UseVisualStyleBackColor = true;
            this.btnExportarTxt.Click += new System.EventHandler(this.btnExportarTxt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 349);
            this.Controls.Add(this.btnExportarTxt);
            this.Controls.Add(this.linkLabelLimparAreaTransferencia);
            this.Controls.Add(this.checkBoxQuebrarLinha);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxTexto);
            this.Controls.Add(this.checkBoxVerificarAreaTransferencia);
            this.Controls.Add(this.checkBoxSempreVisivel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copiando para Área de Transferência";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxSempreVisivel;
        private System.Windows.Forms.CheckBox checkBoxVerificarAreaTransferencia;
        private System.Windows.Forms.RichTextBox richTextBoxTexto;
        private System.Windows.Forms.Timer timerAreaTransferencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.CheckBox checkBoxQuebrarLinha;
        private System.Windows.Forms.LinkLabel linkLabelLimparAreaTransferencia;
        private System.Windows.Forms.Button btnExportarTxt;
    }
}

