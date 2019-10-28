using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Cryptographie.Crypto
{
    public class Perso : Crypto
    {
        public const string TOO_LOW = "TROP_PETIT";
        public const string ERREUR_CALCUL = "ERREUR_CALCUL";
        
        private int p, q;
        private int phiDeN;
        private int clePubliqueE;
        private int clePubliqueN;
        private int[] clePrivee = new int[2];

        private new string nomCryptage = "RSA";
        
        public Perso(string message, int cle = 463361)
        {
            this.message = message;
            
            SetCle(cle.ToString());
        }

        private void ClePublique()
        {
            // p,q < e < phiDeN
            // e et phiDeN sont premiers entre eux = pgcd(E, phiDeN)
            // e est la cle publique
            // permet de chiffrer
            // e
            bool trouveE = false;
            int pgcd1 = 0;

            if (p < q)
                clePubliqueE = p + 1;
            else
                clePubliqueE = q + 1;

            while (pgcd1 != 1)
            {
                while (trouveE == false)
                {
                    if ((p < clePubliqueE) && (q < clePubliqueE) && (clePubliqueE < phiDeN))
                        trouveE = true;

                    clePubliqueE++; // tant que rien n'est trouvé on incrémente
                }
                
                pgcd1 = pgcd(clePubliqueE, phiDeN); // résultat pgcd
            }
        }

        private void ClePrivee()
        {
            // clé privée : (d, N)
            // d = (e ^ -1) mod phiDeN
            // permet de déchiffrer
            int d = 0;
            int compteur = 0;

            while (compteur == 0)
            {
                if ((clePubliqueE * d % phiDeN == 1) && (p < d) && (q < d) && (d < phiDeN))
                    compteur++;

                d++;
            }

            d--;

            clePrivee[0] = d;
            clePrivee[1] = clePubliqueN;
        }

        public string Chiffrer(string messageAChiffrer)
        {
            int longueur = messageAChiffrer.Length;
            
            byte[] messageASCII = Encoding.ASCII.GetBytes(messageAChiffrer); // transforme la chaine en un tableau de caractères ASCII
            
            BigInteger messageChiffre = new BigInteger();
            BigInteger lettreCryptee;
            
            int compteur = 0;

            int longueurPrefixe;
            int nombreAAjouter;

            while (compteur < longueur && messageASCII[compteur] != 0) // parcours chaque lettre
            {
                //lettreCryptee = (BigInteger.Pow(messageASCII[compteur], clePubliqueE)) % clePubliqueN;
                lettreCryptee = ExponentiationRapide(messageASCII[compteur], clePubliqueE, clePubliqueN); // lettre cryptée

                // si le code ascii est > à n
                if(messageASCII[compteur] > clePubliqueN)
                    return TOO_LOW;
                
                // si le bloc crypté est > PhiDeN
                if (lettreCryptee > phiDeN)
                    return ERREUR_CALCUL;
                
                // longueur préfixe pour indiquer la longueur de la chaine a lire
                longueurPrefixe = lettreCryptee.ToString().Length;
                nombreAAjouter = longueurPrefixe;
                for (int i = 0; i < longueurPrefixe; i++) // génère le préfixe
                    nombreAAjouter *= 10;

                lettreCryptee += nombreAAjouter; // ajoute le préfixe au nombre calculé

                messageChiffre = Concatene(messageChiffre, lettreCryptee); // concatene chaque nombre chiffre pour renvoyer toute la chaine d'un coup
                
                compteur++;
            }

            return messageChiffre.ToString();
        }
        
        public string Dechiffrer(string message)
        {
            int longueurMessage = message.Length;
            
            int nombreChiffre;
            int position = 0;
            int compteur = 0;
            int longueurCode = Int32.Parse(message.Substring(0, 1));
            // lis le premier chiffre qui donne la longueur et lui retire 1 pour prendre un tableau un peu plus large
            byte[] messageCaractere = new byte[longueurMessage / (longueurCode - 1)]; // tableau contenant le message dechiffré
            while (position < longueurMessage)
            {
                longueurCode = Int32.Parse(message.Substring(position, 1)); // on lit le premier caractère à la position courante
                nombreChiffre = int.Parse(message.Substring(position + 1, longueurCode)); // on extrait le code à déchiffrer
                
                nombreChiffre = ExponentiationRapide(nombreChiffre, clePrivee[0], clePubliqueN); // déchiffre le code pour obtenir le code ascii
                
                messageCaractere[compteur] = (byte) nombreChiffre;
                
                position += longueurCode + 1;
                compteur++;
            }

            StringBuilder stringBuilder = new StringBuilder();
            foreach (char valeur in messageCaractere)
            {
                stringBuilder.Append(valeur);
            }
            
            //Encoding.Convert(Encoding.ASCII, Encoding.UTF8, messageCaractere);
            
            return stringBuilder.ToString();
        }
        
        private int ExponentiationRapide (BigInteger bases, BigInteger exponentielle, BigInteger modulo) {
            int resultat;
  
            for (resultat = 1; exponentielle > 0; exponentielle /= 2)
            {
                if (exponentielle % 2 != 0)
                    resultat = (int) ((resultat * bases) % modulo);
                bases = (bases * bases) % modulo;
            }
            return resultat;
        }

        private BigInteger Concatene(BigInteger nombre1, BigInteger nombre2)
        {
            BigInteger longueurNombre2 = nombre2.ToString().Length;

            for (int i = 0; i < longueurNombre2; i++)
            {
                nombre1 *= 10;
            }
            
            nombre1 += nombre2;
            
            return nombre1;
        }
        
        private int pgcd(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            return a;
        }

        private void Factoriser(int n)
        {
            for (int i = 2; p * q != n; i++)
            {
                if ((double) ((double) n / (double) i) % 1 == 0)
                {
                    p = i;
                    q = n / i;
                }
            }
        }

        public List<string> GenereNombresPremiers(string min, int nombre)
        {
            int nombreMinimum = Int32.Parse(min);
            List<string> nombres = new List<string>();

            for (int i = 0; i < nombre; i++)
            {
                nombres.Add(ProchainNombrePremier(nombreMinimum));
            }

            return nombres;
        }

        private string ProchainNombrePremier(int nombreMinimum)
        {
            bool trouve = false;
            int nombreCourant = nombreMinimum;
            int i;

            while (trouve == false)
            {
                i = 3;
                int racineATrouver = (int) Math.Ceiling(Math.Sqrt(nombreCourant));
                
                for (; i <= racineATrouver; i += 2)
                {
                    if ((nombreCourant % i) == 0) // si il est divisible
                        i = racineATrouver; // on arrete de tester pour passer au nombre suivant
                }

                if (i == racineATrouver)
                    nombreCourant++;
                else
                    trouve = true;
            }

            return nombreCourant.ToString();
        }

        public override string NomCryptage => nomCryptage;

        public void SetCle(string cleN)
        {
            clePubliqueN = Int32.Parse(cleN);
            
            Factoriser(clePubliqueN);
            
            phiDeN = (p - 1) * (q - 1);
            
            ClePublique();
            ClePrivee();
        }
    }
}