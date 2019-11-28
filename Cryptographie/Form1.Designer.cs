namespace Cryptographie
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
            this.tMessage = new System.Windows.Forms.TextBox();
            this.lMessage = new System.Windows.Forms.Label();
            this.lCle = new System.Windows.Forms.Label();
            this.lCrypt = new System.Windows.Forms.Label();
            this.tCrypte = new System.Windows.Forms.TextBox();
            this.lDecrypt = new System.Windows.Forms.Label();
            this.tDeCrypte = new System.Windows.Forms.TextBox();
            this.tCle = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bDecrypteNet = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bDecryptePerso = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bCrypterNet = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bCryptePerso = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tMessage
            // 
            this.tMessage.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (44)))), ((int) (((byte) (43)))),
                ((int) (((byte) (60)))));
            this.tMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tMessage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tMessage.Location = new System.Drawing.Point(283, 110);
            this.tMessage.Name = "tMessage";
            this.tMessage.Size = new System.Drawing.Size(504, 26);
            this.tMessage.TabIndex = 0;
            this.tMessage.Enter += new System.EventHandler(this.tMessage_Enter);
            this.tMessage.Leave += new System.EventHandler(this.tMessage_Leave);
            // 
            // lMessage
            // 
            this.lMessage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lMessage.Location = new System.Drawing.Point(177, 110);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(100, 23);
            this.lMessage.TabIndex = 1;
            this.lMessage.Text = "Texte à crypter";
            // 
            // lCle
            // 
            this.lCle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lCle.Location = new System.Drawing.Point(177, 153);
            this.lCle.Name = "lCle";
            this.lCle.Size = new System.Drawing.Size(100, 23);
            this.lCle.TabIndex = 3;
            this.lCle.Text = "Clé Publique";
            // 
            // lCrypt
            // 
            this.lCrypt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lCrypt.Location = new System.Drawing.Point(177, 335);
            this.lCrypt.Name = "lCrypt";
            this.lCrypt.Size = new System.Drawing.Size(100, 23);
            this.lCrypt.TabIndex = 7;
            this.lCrypt.Text = "Texte crypté";
            // 
            // tCrypte
            // 
            this.tCrypte.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (44)))), ((int) (((byte) (43)))),
                ((int) (((byte) (60)))));
            this.tCrypte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tCrypte.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tCrypte.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tCrypte.Location = new System.Drawing.Point(283, 335);
            this.tCrypte.Name = "tCrypte";
            this.tCrypte.Size = new System.Drawing.Size(504, 26);
            this.tCrypte.TabIndex = 6;
            this.tCrypte.Enter += new System.EventHandler(this.tCrypte_Enter);
            this.tCrypte.Leave += new System.EventHandler(this.tCrypte_Leave);
            // 
            // lDecrypt
            // 
            this.lDecrypt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lDecrypt.Location = new System.Drawing.Point(177, 546);
            this.lDecrypt.Name = "lDecrypt";
            this.lDecrypt.Size = new System.Drawing.Size(100, 23);
            this.lDecrypt.TabIndex = 11;
            this.lDecrypt.Text = "Texte décrypté";
            // 
            // tDeCrypte
            // 
            this.tDeCrypte.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (44)))), ((int) (((byte) (43)))),
                ((int) (((byte) (60)))));
            this.tDeCrypte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDeCrypte.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tDeCrypte.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tDeCrypte.Location = new System.Drawing.Point(283, 546);
            this.tDeCrypte.Name = "tDeCrypte";
            this.tDeCrypte.Size = new System.Drawing.Size(504, 26);
            this.tDeCrypte.TabIndex = 10;
            this.tDeCrypte.Enter += new System.EventHandler(this.tDeCrypte_Enter);
            this.tDeCrypte.Leave += new System.EventHandler(this.tDeCrypte_Leave);
            // 
            // tCle
            // 
            this.tCle.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (44)))), ((int) (((byte) (43)))),
                ((int) (((byte) (60)))));
            this.tCle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tCle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tCle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tCle.Location = new System.Drawing.Point(283, 151);
            this.tCle.Name = "tCle";
            this.tCle.Size = new System.Drawing.Size(131, 26);
            this.tCle.TabIndex = 2;
            this.tCle.Enter += new System.EventHandler(this.tCle_Enter);
            this.tCle.Leave += new System.EventHandler(this.tCle_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))), ((int) (((byte) (75)))),
                ((int) (((byte) (105)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 100);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(700, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (50)))), ((int) (((byte) (49)))),
                ((int) (((byte) (69)))));
            this.panel2.Controls.Add(this.bDecrypteNet);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.bDecryptePerso);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.bCrypterNet);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.bCryptePerso);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 576);
            this.panel2.TabIndex = 14;
            // 
            // bDecrypteNet
            // 
            this.bDecrypteNet.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))),
                ((int) (((byte) (122)))), ((int) (((byte) (183)))));
            this.bDecrypteNet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))),
                ((int) (((byte) (122)))), ((int) (((byte) (183)))));
            this.bDecrypteNet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDecrypteNet.Location = new System.Drawing.Point(9, 359);
            this.bDecrypteNet.Name = "bDecrypteNet";
            this.bDecrypteNet.Size = new System.Drawing.Size(159, 30);
            this.bDecrypteNet.TabIndex = 7;
            this.bDecrypteNet.Text = "button2";
            this.bDecrypteNet.UseVisualStyleBackColor = false;
            this.bDecrypteNet.Click += new System.EventHandler(this.bDecrypteNet_Click_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (232)))),
                ((int) (((byte) (166)))));
            this.panel5.Location = new System.Drawing.Point(1, 359);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(6, 30);
            this.panel5.TabIndex = 6;
            // 
            // bDecryptePerso
            // 
            this.bDecryptePerso.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))),
                ((int) (((byte) (122)))), ((int) (((byte) (183)))));
            this.bDecryptePerso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))),
                ((int) (((byte) (122)))), ((int) (((byte) (183)))));
            this.bDecryptePerso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDecryptePerso.Location = new System.Drawing.Point(9, 323);
            this.bDecryptePerso.Name = "bDecryptePerso";
            this.bDecryptePerso.Size = new System.Drawing.Size(159, 30);
            this.bDecryptePerso.TabIndex = 5;
            this.bDecryptePerso.Text = "button1";
            this.bDecryptePerso.UseVisualStyleBackColor = false;
            this.bDecryptePerso.Click += new System.EventHandler(this.bDecryptePerso_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (232)))),
                ((int) (((byte) (166)))));
            this.panel6.Location = new System.Drawing.Point(1, 323);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(6, 30);
            this.panel6.TabIndex = 4;
            // 
            // bCrypterNet
            // 
            this.bCrypterNet.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))),
                ((int) (((byte) (122)))), ((int) (((byte) (183)))));
            this.bCrypterNet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))),
                ((int) (((byte) (122)))), ((int) (((byte) (183)))));
            this.bCrypterNet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCrypterNet.Location = new System.Drawing.Point(10, 151);
            this.bCrypterNet.Name = "bCrypterNet";
            this.bCrypterNet.Size = new System.Drawing.Size(159, 30);
            this.bCrypterNet.TabIndex = 3;
            this.bCrypterNet.Text = "button1";
            this.bCrypterNet.UseVisualStyleBackColor = false;
            this.bCrypterNet.Click += new System.EventHandler(this.bCrypterNet_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (232)))),
                ((int) (((byte) (166)))));
            this.panel4.Location = new System.Drawing.Point(2, 151);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(6, 30);
            this.panel4.TabIndex = 2;
            // 
            // bCryptePerso
            // 
            this.bCryptePerso.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))),
                ((int) (((byte) (122)))), ((int) (((byte) (183)))));
            this.bCryptePerso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))),
                ((int) (((byte) (122)))), ((int) (((byte) (183)))));
            this.bCryptePerso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCryptePerso.Location = new System.Drawing.Point(10, 115);
            this.bCryptePerso.Name = "bCryptePerso";
            this.bCryptePerso.Size = new System.Drawing.Size(159, 30);
            this.bCryptePerso.TabIndex = 1;
            this.bCryptePerso.Text = "button1";
            this.bCryptePerso.UseVisualStyleBackColor = false;
            this.bCryptePerso.Click += new System.EventHandler(this.bCrypterPerso_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (232)))),
                ((int) (((byte) (166)))));
            this.panel3.Location = new System.Drawing.Point(2, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(6, 30);
            this.panel3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (44)))), ((int) (((byte) (43)))),
                ((int) (((byte) (60)))));
            this.ClientSize = new System.Drawing.Size(946, 676);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lDecrypt);
            this.Controls.Add(this.tDeCrypte);
            this.Controls.Add(this.lCrypt);
            this.Controls.Add(this.tCrypte);
            this.Controls.Add(this.lCle);
            this.Controls.Add(this.tCle);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.tMessage);
            this.Name = "Form1";
            this.Text = "Padlock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lDecrypt;
        private System.Windows.Forms.TextBox tDeCrypte;
        private System.Windows.Forms.Button bDecrypteNet;
        private System.Windows.Forms.Label lCrypt;
        private System.Windows.Forms.TextBox tCrypte;
        private System.Windows.Forms.Button bCryptePerso;
        private System.Windows.Forms.Button bCrypterNet;
        private System.Windows.Forms.TextBox tMessage;
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.Label lCle;
        private System.Windows.Forms.TextBox tCle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bDecryptePerso;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}