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
            this.bCryptePerso = new System.Windows.Forms.Button();
            this.bCrypterNet = new System.Windows.Forms.Button();
            this.lCrypt = new System.Windows.Forms.Label();
            this.tCrypte = new System.Windows.Forms.TextBox();
            this.bDecrypteNet = new System.Windows.Forms.Button();
            this.bDecryptePerso = new System.Windows.Forms.Button();
            this.lDecrypt = new System.Windows.Forms.Label();
            this.tDeCrypte = new System.Windows.Forms.TextBox();
            this.tCle = new System.Windows.Forms.TextBox();
            this.bListeNombresPremiers = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.lCle.Location = new System.Drawing.Point(177, 154);
            this.lCle.Name = "lCle";
            this.lCle.Size = new System.Drawing.Size(100, 23);
            this.lCle.TabIndex = 3;
            this.lCle.Text = "Clé Publique";
            // 
            // bCryptePerso
            // 
            this.bCryptePerso.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))),
                ((int) (((byte) (75)))), ((int) (((byte) (105)))));
            this.bCryptePerso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bCryptePerso.Location = new System.Drawing.Point(283, 197);
            this.bCryptePerso.Name = "bCryptePerso";
            this.bCryptePerso.Size = new System.Drawing.Size(131, 93);
            this.bCryptePerso.TabIndex = 4;
            this.bCryptePerso.Text = "button1";
            this.bCryptePerso.UseVisualStyleBackColor = false;
            this.bCryptePerso.Click += new System.EventHandler(this.bCryptePerso_Click);
            // 
            // bCrypterNet
            // 
            this.bCrypterNet.Location = new System.Drawing.Point(657, 197);
            this.bCrypterNet.Name = "bCrypterNet";
            this.bCrypterNet.Size = new System.Drawing.Size(131, 93);
            this.bCrypterNet.TabIndex = 5;
            this.bCrypterNet.Text = "button2";
            this.bCrypterNet.UseVisualStyleBackColor = true;
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
            // bDecrypteNet
            // 
            this.bDecrypteNet.Location = new System.Drawing.Point(657, 408);
            this.bDecrypteNet.Name = "bDecrypteNet";
            this.bDecrypteNet.Size = new System.Drawing.Size(131, 93);
            this.bDecrypteNet.TabIndex = 9;
            this.bDecrypteNet.Text = "button3";
            this.bDecrypteNet.UseVisualStyleBackColor = true;
            // 
            // bDecryptePerso
            // 
            this.bDecryptePerso.Location = new System.Drawing.Point(283, 408);
            this.bDecryptePerso.Name = "bDecryptePerso";
            this.bDecryptePerso.Size = new System.Drawing.Size(131, 93);
            this.bDecryptePerso.TabIndex = 8;
            this.bDecryptePerso.Text = "button4";
            this.bDecryptePerso.UseVisualStyleBackColor = true;
            this.bDecryptePerso.Click += new System.EventHandler(this.bDecryptePerso_Click);
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
            // bListeNombresPremiers
            // 
            this.bListeNombresPremiers.Location = new System.Drawing.Point(645, 155);
            this.bListeNombresPremiers.Name = "bListeNombresPremiers";
            this.bListeNombresPremiers.Size = new System.Drawing.Size(142, 23);
            this.bListeNombresPremiers.TabIndex = 12;
            this.bListeNombresPremiers.Text = "Liste nombres premiers";
            this.bListeNombresPremiers.UseVisualStyleBackColor = true;
            this.bListeNombresPremiers.Click += new System.EventHandler(this.bListeNombresPremiers_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))), ((int) (((byte) (75)))),
                ((int) (((byte) (105)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 100);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (50)))), ((int) (((byte) (49)))),
                ((int) (((byte) (69)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 576);
            this.panel2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))), ((int) (((byte) (122)))),
                ((int) (((byte) (183)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))),
                ((int) (((byte) (122)))), ((int) (((byte) (183)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(9, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (232)))),
                ((int) (((byte) (166)))));
            this.panel3.Location = new System.Drawing.Point(1, 38);
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
            this.Controls.Add(this.bListeNombresPremiers);
            this.Controls.Add(this.lDecrypt);
            this.Controls.Add(this.tDeCrypte);
            this.Controls.Add(this.bDecrypteNet);
            this.Controls.Add(this.bDecryptePerso);
            this.Controls.Add(this.lCrypt);
            this.Controls.Add(this.tCrypte);
            this.Controls.Add(this.bCrypterNet);
            this.Controls.Add(this.bCryptePerso);
            this.Controls.Add(this.lCle);
            this.Controls.Add(this.tCle);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.tMessage);
            this.Name = "Form1";
            this.Text = "Padlock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lDecrypt;
        private System.Windows.Forms.TextBox tDeCrypte;
        private System.Windows.Forms.Button bDecrypteNet;
        private System.Windows.Forms.Button bDecryptePerso;
        private System.Windows.Forms.Label lCrypt;
        private System.Windows.Forms.TextBox tCrypte;
        private System.Windows.Forms.Button bCryptePerso;
        private System.Windows.Forms.Button bCrypterNet;
        private System.Windows.Forms.TextBox tMessage;
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.Label lCle;
        private System.Windows.Forms.TextBox tCle;
        private System.Windows.Forms.Button bListeNombresPremiers;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
    }
}