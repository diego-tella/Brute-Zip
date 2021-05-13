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
        //Global Variables
        public string caminho = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        public bool found = false;
        public string str2 = "";

        public bool error = false;
        public bool done = false;
        public bool Nda = false;
        private void BtnList_Click(object sender, EventArgs e)
        {
            bool escolheu = false;
            using (OpenFileDialog op = new OpenFileDialog())
            {
                op.Filter = "txt files (*.txt)|*.txt";
                op.Title = "Open wordlist";
                if(op.ShowDialog() == DialogResult.OK)
                {
                    TxtWordlist.Text = op.FileName;
                    escolheu = true;
                }
            }
            if (escolheu)
            {
                LblStatus.Text = "Loading...";
                Thread t = new Thread(progressbar);
                t.Start();
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
                        found = true;
                        break;
                    }
                    catch (Exception ex)
                    {
                        error = true; 
                    }

                }
                if(!found)
                    Nda = true;
            }
        }

        private void BtnFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog op = new OpenFileDialog())
            {
                op.Filter = "zip files (*.zip)|*.zip";
                op.Title = "Choose the zip file";
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
            done = true;
            Thrd = true;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (TxtFile.Text.Length > 0 & TxtWordlist.Text.Length > 0)
            {
                if (done)
                {
                    LblStatus.Text = "Status: attacking...";
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
                MessageBox.Show("Choose the files for the brute-force attack. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool Thrd = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (found)
            {
                TxtLog.Lines = TxtLog.Lines.Take(TxtLog.Lines.Length - 2).ToArray();
                found = false;
                TxtLog.AppendText("\nPassword found! --> " + str2);
                MessageBox.Show("Password found! ---> " + str2 + "\n\nUnzipped file at: " + caminho, "Password found!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LblStatus.Text = "Status: Password Broken --> " + str2;
                PicClipboard.Visible = true;
                PicClear.Visible = true;
            }
            if(error)
            {
                TxtLog.AppendText("Wrong password --> " + str2 + "\n"); 
                progressBar1.Value = progressBar1.Value + 1;
                error = false;
            }
            if(Nda)
            {
                Nda = false;
                LblStatus.Text = "Status: Password was not found.";
                int max = progressBar1.Maximum;
                int atual = progressBar1.Value;
                int conta = max - atual;
                progressBar1.Value = atual + conta;
                PicClear.Visible = true;
                MessageBox.Show("Password was not found in the wordlist :(", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (done)
            {
                if (Thrd)
                {
                    LblStatus.Text = "";
                    Thrd = false;
                }
            }
        }

        private void PicClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(str2);
            MessageBox.Show("Password copied to clipboard! ---> " + str2, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PicClear_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
