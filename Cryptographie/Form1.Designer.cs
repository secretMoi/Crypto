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
            this.SuspendLayout();
            // 
            // tMessage
            // 
            this.tMessage.Location = new System.Drawing.Point(118, 9);
            this.tMessage.Name = "tMessage";
            this.tMessage.Size = new System.Drawing.Size(504, 23);
            this.tMessage.TabIndex = 0;
            // 
            // lMessage
            // 
            this.lMessage.Location = new System.Drawing.Point(12, 9);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(100, 23);
            this.lMessage.TabIndex = 1;
            this.lMessage.Text = "Texte à crypter";
            // 
            // lCle
            // 
            this.lCle.Location = new System.Drawing.Point(12, 38);
            this.lCle.Name = "lCle";
            this.lCle.Size = new System.Drawing.Size(100, 23);
            this.lCle.TabIndex = 3;
            this.lCle.Text = "Clé Publique";
            // 
            // bCryptePerso
            // 
            this.bCryptePerso.Location = new System.Drawing.Point(118, 96);
            this.bCryptePerso.Name = "bCryptePerso";
            this.bCryptePerso.Size = new System.Drawing.Size(131, 93);
            this.bCryptePerso.TabIndex = 4;
            this.bCryptePerso.Text = "button1";
            this.bCryptePerso.UseVisualStyleBackColor = true;
            this.bCryptePerso.Click += new System.EventHandler(this.bCryptePerso_Click);
            // 
            // bCrypterNet
            // 
            this.bCrypterNet.Location = new System.Drawing.Point(492, 96);
            this.bCrypterNet.Name = "bCrypterNet";
            this.bCrypterNet.Size = new System.Drawing.Size(131, 93);
            this.bCrypterNet.TabIndex = 5;
            this.bCrypterNet.Text = "button2";
            this.bCrypterNet.UseVisualStyleBackColor = true;
            // 
            // lCrypt
            // 
            this.lCrypt.Location = new System.Drawing.Point(12, 234);
            this.lCrypt.Name = "lCrypt";
            this.lCrypt.Size = new System.Drawing.Size(100, 23);
            this.lCrypt.TabIndex = 7;
            this.lCrypt.Text = "Texte crypté";
            // 
            // tCrypte
            // 
            this.tCrypte.Location = new System.Drawing.Point(118, 234);
            this.tCrypte.Name = "tCrypte";
            this.tCrypte.Size = new System.Drawing.Size(504, 23);
            this.tCrypte.TabIndex = 6;
            // 
            // bDecrypteNet
            // 
            this.bDecrypteNet.Location = new System.Drawing.Point(492, 307);
            this.bDecrypteNet.Name = "bDecrypteNet";
            this.bDecrypteNet.Size = new System.Drawing.Size(131, 93);
            this.bDecrypteNet.TabIndex = 9;
            this.bDecrypteNet.Text = "button3";
            this.bDecrypteNet.UseVisualStyleBackColor = true;
            // 
            // bDecryptePerso
            // 
            this.bDecryptePerso.Location = new System.Drawing.Point(118, 307);
            this.bDecryptePerso.Name = "bDecryptePerso";
            this.bDecryptePerso.Size = new System.Drawing.Size(131, 93);
            this.bDecryptePerso.TabIndex = 8;
            this.bDecryptePerso.Text = "button4";
            this.bDecryptePerso.UseVisualStyleBackColor = true;
            this.bDecryptePerso.Click += new System.EventHandler(this.bDecryptePerso_Click);
            // 
            // lDecrypt
            // 
            this.lDecrypt.Location = new System.Drawing.Point(12, 445);
            this.lDecrypt.Name = "lDecrypt";
            this.lDecrypt.Size = new System.Drawing.Size(100, 23);
            this.lDecrypt.TabIndex = 11;
            this.lDecrypt.Text = "Texte décrypté";
            // 
            // tDeCrypte
            // 
            this.tDeCrypte.Location = new System.Drawing.Point(118, 445);
            this.tDeCrypte.Name = "tDeCrypte";
            this.tDeCrypte.Size = new System.Drawing.Size(504, 23);
            this.tDeCrypte.TabIndex = 10;
            // 
            // tCle
            // 
            this.tCle.Location = new System.Drawing.Point(118, 38);
            this.tCle.Name = "tCle";
            this.tCle.Size = new System.Drawing.Size(131, 23);
            this.tCle.TabIndex = 2;
            // 
            // bListeNombresPremiers
            // 
            this.bListeNombresPremiers.Location = new System.Drawing.Point(479, 38);
            this.bListeNombresPremiers.Name = "bListeNombresPremiers";
            this.bListeNombresPremiers.Size = new System.Drawing.Size(142, 23);
            this.bListeNombresPremiers.TabIndex = 12;
            this.bListeNombresPremiers.Text = "Liste nombres premiers";
            this.bListeNombresPremiers.UseVisualStyleBackColor = true;
            this.bListeNombresPremiers.Click += new System.EventHandler(this.bListeNombresPremiers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 496);
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
    }
}