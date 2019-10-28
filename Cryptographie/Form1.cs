using System;
using System.Windows.Forms;
using Cryptographie.Crypto;

namespace Cryptographie
{
    public partial class Form1 : Form
    {
        private Perso rsa;
        private Net net;
        ListeNombresPremiers fenetre;
        public Form1()
        {
            InitializeComponent();

            rsa = new Perso("a");
            net = new Net();
            
            fenetre = new ListeNombresPremiers();
            
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
            string messageChiffre = tCrypte.Text;
            string messageClair = rsa.Dechiffrer(messageChiffre);

            tDeCrypte.Text = messageClair;
        }
        
            /*ListView tableau = new ListView();
            tableau.View = View.List;
            tableau.GridLines = true;*/
        private void bListeNombresPremiers_Click(object sender, EventArgs e)
        {
            DataGridView grille = new DataGridView();
            
            fenetre.Show();
        }
    }
}