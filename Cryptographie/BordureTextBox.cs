using System.Drawing;

namespace Cryptographie
{
    public class BordureTextBox
    {
        private Pen contour;

        private bool etat;
        private Point position;
        private Size taille;
        private Color couleur;
        private static Color couleurActive = Color.FromArgb(102, 45, 145);
        private static Color couleurInactive = Color.FromArgb(51, 122, 183);
        
        public BordureTextBox(Point position, Size taille)
        {
            this.position = position;
            this.taille = taille;
            this.couleur = couleurInactive;

            contour = new Pen(couleur);
        }

        public void Dessine(Graphics bordure)
        {
            bordure.DrawRectangle(contour, new Rectangle(position, taille));
        }

        public Color Couleur
        {
            get => couleur;
            set
            {
                couleur = value;
                contour = new Pen(couleur, 3);
            } 
        }

        public bool Etat
        {
            get => etat;
            set => etat = value;
        }
        
        public Pen Contour => contour;

        public Point Position => position;

        public Size Taille => taille;

        public static Color CouleurActive => couleurActive;

        public static Color CouleurInactive => couleurInactive;
    }
}