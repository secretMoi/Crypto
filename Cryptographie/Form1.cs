using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Cryptographie.Crypto;
using Cryptographie.FormPerso;

namespace Cryptographie
{
    public partial class Form1 : Form
    {
        private readonly Perso rsa;
        private readonly Net net;
        ListeNombresPremiers fenetre;
        Dictionary<string, BordureTextBox> bordures;
        public Form1()
        {
            InitializeComponent();

            rsa = new Perso("a");
            net = new Net();
            
            fenetre = new ListeNombresPremiers();
            bordures = new Dictionary<string, BordureTextBox>();

            AjouteForm();

            bCryptePerso.Text = "Cryptage " + rsa.NomCryptage;
            bDecryptePerso.Text = "Décryptage " + rsa.NomCryptage;
            bCrypterNet.Text = "Cryptage " + net.NomCryptage;
            bDecrypteNet.Text = "Décryptage " + net.NomCryptage;
        }

        private void bCryptePerso_Click(object sender, EventArgs e)
        {
            string clePublique = tCle.Text;
            
            if(clePublique.Length > 0)
            {
                rsa.SetCle(clePublique);
                
                string messageClair = tMessage.Text;
                string messageChiffre = rsa.Chiffrer(messageClair);

                tCrypte.Text = messageChiffre;
            }
            else
            {
                MessageBox.Show("Veuillez entrer une clé",
                    "Erreur");
            }
        }

        private void bDecryptePerso_Click(object sender, EventArgs e)
        {
            if (tCrypte.Text.Length > 0)
            {
                string messageChiffre = tCrypte.Text;
                string messageClair = rsa.Dechiffrer(messageChiffre);

                tDeCrypte.Text = messageClair;
            }
            else
            {
                MessageBox.Show("Texte crypté vide",
                    "Erreur");
            }
        }
        
            /*ListView tableau = new ListView();
            tableau.View = View.List;
            tableau.GridLines = true;*/
        private void bListeNombresPremiers_Click(object sender, EventArgs e)
        {
            DataGridView grille = new DataGridView();
            
            fenetre.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(44, 43, 60);
        }

        private void tMessage_Enter(object sender, EventArgs e)
        {
            bordures["tMessage"].Etat = true;
            Invalidate();
        }

        private void tMessage_Leave(object sender, EventArgs e)
        {
            bordures["tMessage"].Etat = false;
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (BordureTextBox bordureTextBox in ListeBordures())
            {
                if (bordureTextBox.Etat)
                    bordureTextBox.Couleur = BordureTextBox.CouleurActive;
                else
                    bordureTextBox.Couleur = BordureTextBox.CouleurInactive;
                
                e.Graphics.DrawRectangle(bordureTextBox.Contour, new Rectangle(bordureTextBox.Position, bordureTextBox.Taille));
            }
        }

        private void AjouteForm()
        {
            bordures.Add(tMessage.Name, new BordureTextBox(tMessage, tMessage.Location, tMessage.Size));
            bordures.Add(tCle.Name, new BordureTextBox(tCle, tCle.Location, tCle.Size));
            bordures.Add(tCrypte.Name, new BordureTextBox(tCrypte, tCrypte.Location, tCrypte.Size));
            bordures.Add(tDeCrypte.Name, new BordureTextBox(tDeCrypte, tDeCrypte.Location, tDeCrypte.Size));
        }

        private List<BordureTextBox> ListeBordures()
        {
            List<BordureTextBox> figures = new List<BordureTextBox>();

            foreach (BordureTextBox figure in bordures.Values)
            {
                figures.Add(figure);
            }

            return figures;
        }

        private void tCle_Enter(object sender, EventArgs e)
        {
            bordures[tCle.Name].Etat = true;
            Invalidate();
        }

        private void tCle_Leave(object sender, EventArgs e)
        {
            bordures[tCle.Name].Etat = false;
            Invalidate();
        }

        private void tCrypte_Enter(object sender, EventArgs e)
        {
            bordures[tCrypte.Name].Etat = true;
            Invalidate();
        }

        private void tCrypte_Leave(object sender, EventArgs e)
        {
            bordures[tCrypte.Name].Etat = false;
            Invalidate();
        }

        private void tDeCrypte_Enter(object sender, EventArgs e)
        {
            bordures[tDeCrypte.Name].Etat = true;
            Invalidate();
        }

        private void tDeCrypte_Leave(object sender, EventArgs e)
        {
            bordures[tDeCrypte.Name].Etat = false;
            Invalidate();
        }
    }
}