using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace ENCHERE_SIO.Modeles
{
    [Table("User")]
    public sealed class User
    {
        #region Attributes
        private List<Enchere> _mesEncheres;
        private int _id;
        private SecureString _password;
        private string _mail;
        private string _nom;
        private string _prenom;
        #endregion

        #region Constructor
        //public User(string mail, string nom, string prenom, string password)
        //    : this(mail, nom, prenom, ConvertPasswordToSecureString(password))
        //{

        //}
        //public User(string mail, string nom, string prenom, SecureString password)
        //{
        //    _mesEncheres = new List<Enchere>();
        //    _mail = mail;
        //    _nom = nom;
        //    _prenom = prenom;
        //    _password = password;
        //}
        #endregion

        #region Getters/Setters
        [PrimaryKey,AutoIncrement]
        public int Id { get { return _id; } }   
        public string Mail { get => _mail; set => _mail = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        [ManyToMany(typeof(Participer))]
        public List<Enchere> MesEncheres { get => _mesEncheres; set => _mesEncheres = value; }
        public SecureString Password { get => _password; set => _password = value; }
        #endregion

        #region Methods
        public User AjoutUser(string leMail, string leNom, string lePrenom, string mdp, SecureString password)
        {
            ConvertPasswordToSecureString(mdp);
            this._id = 0;
            this._mail = leMail;
            this._nom = leNom;
            this._prenom = lePrenom;
            this._mesEncheres = new List<Enchere>();
            this.Password = password;
            return this;
        }
        /// <summary>
        /// Ne laisse pas le mdp sous forme de texte brut
        /// </summary>
        /// <param name="password"></param>
        /// <returns>
        /// 1- création d'un secure string
        /// 2- attribution caractère par caractère du password
        /// 3- on rend immuable le mdp (ne peut être modifié)
        /// </returns>
        public static SecureString ConvertPasswordToSecureString(string password)
        {
            var secureString = new SecureString();
            foreach (var c in password.ToCharArray())
            {
                secureString.AppendChar(c);
            }
            secureString.MakeReadOnly();
            return secureString;
        }
        #endregion
    }
}
