using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Cryptographie
{

    public partial class FEncryptage : Form
    {
       
        #region Cryptage/DecryptagePerso

        #region Clé

        private void bClé_Click(object sender, EventArgs e)
        {
                Random r = new Random();

                long i = r.Next(2,73);

                lClé.Text = i.ToString();
        }

        #endregion

        #region Variable globale
        static class Global
        {
            private static ulong[] valeur = new ulong[1000];

            public static ulong[] GlobalVar
            {
                get { return valeur; }
                set { valeur = value; }
            }
        }
        #endregion

        #region CryptagePerso

        private void bCryptPerso_Click(object sender, EventArgs e)
        {
            if (lClé.Text == "")
            {
                tbEncrypt.Text = "Veuillez générer une clé avant d'encrypter votre message !";
            }

           else if (tbTexte.Text == "")
            {
                tbEncrypt.Text = "Veuillez écrire un message dans la section Texte !";
            }
           
            else
            {
                int i = 0;

                int Clé = int.Parse(lClé.Text);

                ulong[] value = Cryptage(tbTexte.Text, Clé,i);

                Global.GlobalVar = value;

                string myStringOutput = String.Join("", value.Select(p => p.ToString()).ToArray());

                tbEncrypt.Text = myStringOutput;

            }
        }

         public ulong[] Cryptage(string texte, int code, int i)
        {
            char[] lettre = texte.ToCharArray();

            ulong[] crypt = new ulong[1000];

            for(i = 0; i < lettre.Length; i++)
            {

            switch(lettre[i])
                {
                    case 'A':
                    case 'a':
                    case 'à':
                        crypt[i] = Convert.ToUInt64(code + 13);
                        break;

                    case 'B':
                    case 'b':
                        crypt[i] = Convert.ToUInt64(code + 8);
                        break;

                    case 'C':
                    case 'c':
                        crypt[i] = Convert.ToUInt64(code + 20);
                        break;

                    case 'D':
                    case 'd':
                        crypt[i] = Convert.ToUInt64(code + 2);
                        break;
                    case 'E':
                    case 'e':
                    case 'é':
                    case 'è':
                    case 'ê':
                        crypt[i] = Convert.ToUInt64(code + 23);
                        break;

                    case 'F':
                    case 'f':
                        crypt[i] = Convert.ToUInt64(code + 26);
                        break;

                    case 'g':
                    case 'G':
                        crypt[i] = Convert.ToUInt64(code + 4);
                        break;

                    case 'H':
                    case 'h':
                        crypt[i] = Convert.ToUInt64(code + 6);
                        break;

                    case 'I':
                    case 'i':
                        crypt[i] = Convert.ToUInt64(code + 18);
                        break;

                    case 'J':
                    case 'j':
                        crypt[i] = Convert.ToUInt64(code + 22);
                        break;

                    case 'K':
                    case 'k':
                        crypt[i] = Convert.ToUInt64(code + 5);
                        break;

                    case 'L':
                    case 'l':
                        crypt[i] = Convert.ToUInt64(code + 15);
                        break;

                    case 'M':
                    case 'm':
                        crypt[i] = Convert.ToUInt64(code + 19);
                        break;

                    case 'N':
                    case 'n':
                        crypt[i] = Convert.ToUInt64(code + 10);
                        break;

                    case 'O':
                    case 'o':
                        crypt[i] = Convert.ToUInt64(code + 7);
                        break;

                    case 'P':
                    case 'p':
                        crypt[i] = Convert.ToUInt64(code + 25);
                        break;

                    case 'Q':
                    case 'q':
                        crypt[i] = Convert.ToUInt64(code + 3);
                        break;

                    case 'R':
                    case 'r':
                        crypt[i] = Convert.ToUInt64(code + 9);
                        break;

                    case 'S':
                    case 's':
                        crypt[i] = Convert.ToUInt64(code + 11);
                        break;

                    case 'T':
                    case 't':
                        crypt[i] = Convert.ToUInt64(code + 14);
                        break;

                    case 'U':
                    case 'u':
                    case 'ù':
                        crypt[i] = Convert.ToUInt64(code + 24);
                        break;

                    case 'V':
                    case 'v':
                        crypt[i] = Convert.ToUInt64(code + 16);
                        break;

                    case 'W':
                    case 'w':
                        crypt[i] = Convert.ToUInt64(code + 21);
                        break;

                    case 'X':
                    case 'x':
                        crypt[i] = Convert.ToUInt64(code + 17);
                        break;

                    case 'Y':
                    case 'y':
                        crypt[i] = Convert.ToUInt64(code + 1);
                        break;

                    case 'Z':
                    case 'z':
                        crypt[i] = Convert.ToUInt64(code + 12);
                        break;

                    default: crypt[i] = Convert.ToUInt64(00); break;

                }

            }

            return crypt;
        }

        #endregion

        #region DecrytagePerso

        private void bDecryptPerso_Click(object sender, EventArgs e)
        {
            if (lClé.Text == "")
            {
                tbDecrypt.Text = "Veuillez générer une clé avant d'encrypter votre message !";
            }

            else if (tbTexte.Text == "")
            {
                tbDecrypt.Text = "Veuillez écrire un message dans la section Texte !";
            }

            else if (tbEncrypt.Text == "")
            {
                tbDecrypt.Text = "Veuillez crypter le message avant de le decrypter !";
            }

            else
            {

                ulong[] value = new ulong[1000];

                int Clé = int.Parse(lClé.Text);

                value = Global.GlobalVar;

                string[] traduction = Decryptage(value, Clé);

                string result = String.Concat(traduction);

                tbDecrypt.Text = result;
            }
        }

        public string[] Decryptage(ulong[] value, int code)
        {
            string[] texte = new string[1000];

            int nombre_codé;

            for (int j = 0; j < texte.Length; j++)

            {

                nombre_codé = Convert.ToInt32(value[j]);

                if(nombre_codé != 0)

                nombre_codé = nombre_codé - code;

                switch (nombre_codé)
                {

                    case 13:
                        texte[j] = "a";
                        break;


                    case 8:
                        texte[j] = "b";
                        break;


                    case 20:
                        texte[j] = "c";
                        break;


                    case 2:
                        texte[j] = "d";
                        break;


                    case 23:
                        texte[j] = "e";
                        break;

             
                    case 26 :
                        texte[j] = "f";
                        break;

                
                    case 4 :
                        texte[j] = "g";
                        break;

                  
                    case 6 :
                        texte[j] = "h";
                        break;

               
                    case 18 :
                        texte[j] = "i";
                        break;

              
                    case 22 :
                        texte[j] = "j";
                        break;

                  
                    case 5 :
                        texte[j] = "k";
                        break;

                   
                    case 15 :
                        texte[j] = "l";
                        break;

                    
                    case 19 :
                        texte[j] = "m";
                        break;

                 
                    case 10 :
                        texte[j] = "n";
                        break;

                 
                    case 7 :
                        texte[j] = "o";
                        break;

                  
                    case 25 :
                        texte[j] = "p";
                        break;

               
                    case 3 :
                        texte[j] = "q";
                        break;

              
                    case 9 :
                        texte[j] = "r";
                        break;

                 
                    case 11 :
                        texte[j] = "s";
                        break;

                 
                    case 14 :
                        texte[j] = "t";
                        break;

               
                    case 24 :
                        texte[j] = "u";
                        break;

                
                    case 16 :
                        texte[j] = "v";
                        break;

             
                    case 21:
                        texte[j] = "w";
                        break;

                  
                    case 17 :
                        texte[j] = "x";
                        break;

               
                    case 1 :
                        texte[j] = "y";
                        break;

                 
                    case 12:
                        texte[j] = "z";
                        break;

                    default : texte[j] = " "; break;

                }

            }

            return texte;
        }

        #endregion

        #endregion

        #region CryptageLogiciel

        #region Encryptage
        private void bCryptC_Click(object sender, EventArgs e)
        {

            string hash = "O0eh3P";

                byte[] texte_envoi = UTF8Encoding.UTF8.GetBytes(tbTexte.Text);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripDes.CreateEncryptor();
                        byte[] results = transform.TransformFinalBlock(texte_envoi, 0, texte_envoi.Length);
                        tbEncrypt.Text = Convert.ToBase64String(results, 0, results.Length);
                    }
                }
        }

        #endregion

        #region Decryptage
        private void bDecryptC_Click(object sender, EventArgs e)
        {
            string hash = "O0eh3P";

            byte[] texte_recu = Convert.FromBase64String(tbEncrypt.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(texte_recu, 0, texte_recu.Length);
                    tbDecrypt.Text = UTF8Encoding.UTF8.GetString(results);
                }

            }

        }

        #endregion

        #endregion

        #region inutile

        public FEncryptage()
        {
            InitializeComponent();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

         private void lValue_Click(object sender, EventArgs e)
        {

        }

        private void FEncryptage_Load(object sender, EventArgs e)
        {

        }



        #endregion

    }
}
