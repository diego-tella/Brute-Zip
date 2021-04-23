namespace Brute_Zip
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TxtWordlist = new System.Windows.Forms.TextBox();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.TxtLog = new System.Windows.Forms.RichTextBox();
            this.BtnFile = new System.Windows.Forms.Button();
            this.TxtFile = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PicClear = new System.Windows.Forms.PictureBox();
            this.PicClipboard = new System.Windows.Forms.PictureBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClipboard)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtWordlist
            // 
            this.TxtWordlist.Enabled = false;
            this.TxtWordlist.Location = new System.Drawing.Point(94, 50);
            this.TxtWordlist.Name = "TxtWordlist";
            this.TxtWordlist.Size = new System.Drawing.Size(100, 20);
            this.TxtWordlist.TabIndex = 0;
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(12, 47);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(75, 23);
            this.BtnList.TabIndex = 1;
            this.BtnList.Text = "Wordlist";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(12, 119);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(182, 23);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Começar ataque";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // TxtLog
            // 
            this.TxtLog.Location = new System.Drawing.Point(228, 47);
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.Size = new System.Drawing.Size(240, 144);
            this.TxtLog.TabIndex = 3;
            this.TxtLog.Text = "";
            // 
            // BtnFile
            // 
            this.BtnFile.Location = new System.Drawing.Point(12, 75);
            this.BtnFile.Name = "BtnFile";
            this.BtnFile.Size = new System.Drawing.Size(75, 23);
            this.BtnFile.TabIndex = 5;
            this.BtnFile.Text = "Arquivo ZIP";
            this.BtnFile.UseVisualStyleBackColor = true;
            this.BtnFile.Click += new System.EventHandler(this.BtnFile_Click);
            // 
            // TxtFile
            // 
            this.TxtFile.Enabled = false;
            this.TxtFile.Location = new System.Drawing.Point(94, 78);
            this.TxtFile.Name = "TxtFile";
            this.TxtFile.Size = new System.Drawing.Size(100, 20);
            this.TxtFile.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(44, 168);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(150, 23);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.PicClear);
            this.panel1.Controls.Add(this.PicClipboard);
            this.panel1.Controls.Add(this.LblStatus);
            this.panel1.Location = new System.Drawing.Point(-3, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 33);
            this.panel1.TabIndex = 7;
            // 
            // PicClear
            // 
            this.PicClear.Image = global::Brute_Zip.Properties.Resources.clear;
            this.PicClear.Location = new System.Drawing.Point(439, 3);
            this.PicClear.Name = "PicClear";
            this.PicClear.Size = new System.Drawing.Size(24, 25);
            this.PicClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicClear.TabIndex = 1;
            this.PicClear.TabStop = false;
            this.PicClear.Visible = false;
            this.PicClear.Click += new System.EventHandler(this.PicClear_Click);
            // 
            // PicClipboard
            // 
            this.PicClipboard.Image = global::Brute_Zip.Properties.Resources.clipboard;
            this.PicClipboard.Location = new System.Drawing.Point(409, 3);
            this.PicClipboard.Name = "PicClipboard";
            this.PicClipboard.Size = new System.Drawing.Size(24, 25);
            this.PicClipboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicClipboard.TabIndex = 9;
            this.PicClipboard.TabStop = false;
            this.PicClipboard.Visible = false;
            this.PicClipboard.Click += new System.EventHandler(this.PicClipboard_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.ForeColor = System.Drawing.Color.White;
            this.LblStatus.Location = new System.Drawing.Point(15, 6);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(0, 13);
            this.LblStatus.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lista";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Permanent Marker", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "BREAK ZIP v1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 243);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BtnFile);
            this.Controls.Add(this.TxtFile);
            this.Controls.Add(this.TxtLog);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.TxtWordlist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Break ZIP Password";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClipboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtWordlist;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.RichTextBox TxtLog;
        private System.Windows.Forms.Button BtnFile;
        private System.Windows.Forms.TextBox TxtFile;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicClear;
        private System.Windows.Forms.PictureBox PicClipboard;
        private System.Windows.Forms.Label label2;
    }
}

