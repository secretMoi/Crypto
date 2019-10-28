namespace Cryptographie.Crypto
{
    public class Crypto
    {
        protected string message;
        protected int cle;

        protected string crypte;
        
        protected string nomCryptage;

        public string Crypte => crypte;
        
        public virtual string NomCryptage => nomCryptage;
    }
}