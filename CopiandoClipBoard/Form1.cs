using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CopiandoClipBoard
{
    public partial class Form1 : Form
    {
        private bool verificarAreaTranferencia;
        public bool VerificarAreaTransferencia
        {
            get { return this.verificarAreaTranferencia; }
            set
            {
                this.verificarAreaTranferencia = value;
                timerAreaTransferencia.Enabled = value;
            }
        }

        private string textoAreaTransferencia;
        public string TextoAreaTransferencia
        {
            get { return this.textoAreaTransferencia; }
            set { this.textoAreaTransferencia = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxSempreVisivel_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBoxSempreVisivel.Checked;
        }

        private void checkBoxVerificarAreaTransferencia_CheckedChanged(object sender, EventArgs e)
        {
            this.VerificarAreaTransferencia = checkBoxVerificarAreaTransferencia.Checked;
        }

        private void timerAreaTransferencia_Tick(object sender, EventArgs e)
        {
            string textoAtual = Clipboard.GetText();

            if (!string.IsNullOrEmpty(textoAtual))
            {
                if (TextoAreaTransferencia != textoAtual)
                {
                    AdicionarTexto(textoAtual);
                    TextoAreaTransferencia = textoAtual;
                }
            }
        }

        private void AdicionarTexto(string textoAtual)
        {
            richTextBoxTexto.Text += textoAtual + Environment.NewLine;

        }

        private void richTextBoxTexto_TextChanged(object sender, EventArgs e)
        {
            AtualizarContegemLinhas();
        }

        private void AtualizarContegemLinhas()
        {
            int linhas = richTextBoxTexto.Lines.Length;
            if (linhas <= 1)
            {
                labelQuantidade.Text = (richTextBoxTexto.Lines.Length).ToString();
            }
            else if (linhas > 1)
            {
                if (richTextBoxTexto.Lines[linhas - 1].Length > 0)
                    labelQuantidade.Text = (richTextBoxTexto.Lines.Length).ToString();
                else
                    labelQuantidade.Text = (richTextBoxTexto.Lines.Length - 1).ToString();
            }
        }

        private void checkBoxQuebrarLinha_CheckedChanged(object sender, EventArgs e)
        {
            richTextBoxTexto.WordWrap = checkBoxQuebrarLinha.Checked;
            richTextBoxTexto.Refresh();
        }

        private void linkLabelLimparAreaTransferencia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.Clear();
        }

        private void btnExportarTxt_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBoxTexto.Lines.Count() == 0) throw new Exception("A lista está vazia!");

                SaveFileDialog f = new SaveFileDialog();
                f.Filter = "Arquivo Texto (.txt)| .txt";
                f.FileName = string.Empty;                

                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string caminho = f.FileName;
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(caminho))
                    {
                        foreach (string linha in richTextBoxTexto.Lines)
                        {
                            sw.WriteLine(linha);
                        }
                        sw.Close();
                    }
                    MessageBox.Show("Arquivo salvo com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
