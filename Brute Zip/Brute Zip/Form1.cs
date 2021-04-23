using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Ionic.Zip;
using System.IO;
using System.Reflection;

namespace Brute_Zip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string caminho = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        public bool achou = false;
        public string senhaAchada = "";
        public string str2 = "";

        public bool erro = false;
        public bool feito = false;
        public bool Nda = false;
        private void BtnList_Click(object sender, EventArgs e)
        {
            bool escolheu = false;
            using (OpenFileDialog op = new OpenFileDialog())
            {
                op.Filter = "txt files (*.txt)|*.txt";
                op.Title = "Abra a wordlist";
                if(op.ShowDialog() == DialogResult.OK)
                {
                    TxtWordlist.Text = op.FileName;
                    escolheu = true;
                }
            }
            if (escolheu)
            {
                LblStatus.Text = "Carregando";
                progressbar();
            }
        }
        private void ataque()
        {
            StreamReader str = new StreamReader(TxtWordlist.Text.Trim()); ;
            using (ZipFile archive = new ZipFile(TxtFile.Text.Trim()))
            {
                while ((str2 = str.ReadLine()) != null)
                {
                    archive.Password = str2;
                    archive.Encryption = EncryptionAlgorithm.PkzipWeak; 

                    try
                    {
                        archive.ExtractAll(caminho, ExtractExistingFileAction.OverwriteSilently); 
                        achou = true;
                        break;
                    }
                    catch (Exception ex)
                    {
                        erro = true; 
                    }

                }
                if(!achou)
                    Nda = true;
            }
        }

        private void BtnFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog op = new OpenFileDialog())
            {
                op.Filter = "zip files (*.zip)|*.zip";
                op.Title = "Escolha o arquivo zip";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    TxtFile.Text = op.FileName;  
                }
            }
        }
        private void progressbar()
        {
            string str = "";
            int tamanho = 0;
            StreamReader stream = new StreamReader(TxtWordlist.Text.Trim());
            while((str = stream.ReadLine()) != null)
            {
                tamanho++;
            }
            progressBar1.Maximum = tamanho;
            LblStatus.Text = "";
            feito = true;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (TxtFile.Text.Length > 0 & TxtWordlist.Text.Length > 0)
            {
                if (feito)
                {
                    LblStatus.Text = "Status: atacando...";
                    progressBar1.Visible = true;
                    label1.Visible = true;
                    foreach (var button in this.Controls.OfType<Button>())
                        button.Enabled = false;
                    TxtLog.EnableAutoDragDrop = true;
                    Thread t = new Thread(ataque);
                    t.Start();
                }
            }
            else
            {
                MessageBox.Show("Escolhe os arquivos para o brute-force. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (achou)
            {
                achou = false;
                TxtLog.AppendText("Senha encontrada! --> " + str2);
                MessageBox.Show("Senha encontrada! ---> " + str2 + "\n\nArquivo descompactado em: " + caminho, "Senha achada!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LblStatus.Text = "Status: Senha quebrada --> " + str2;
                PicClipboard.Visible = true;
                PicClear.Visible = true;
            }
            if(erro)
            {
                TxtLog.AppendText("Senha errada --> " + str2 + "\n"); 
                progressBar1.Value = progressBar1.Value + 1;
                erro = false;
            }
            if(Nda)
            {
                Nda = false;
                LblStatus.Text = "Status: Senha não encontrada";
                int max = progressBar1.Maximum;
                int atual = progressBar1.Value;
                int conta = max - atual;
                progressBar1.Value = atual + conta;
                PicClear.Visible = true;
                MessageBox.Show("Senha não foi encontrada na wordlist :(", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PicClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(str2);
            MessageBox.Show("Senha copiada! ---> " + str2, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PicClear_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
