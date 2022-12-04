using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Reflection.Metadata;

namespace ENCHERE_SIO.Modeles
{
    [Table("User")]
    public sealed class User
    {
        #region Attributes
        
        private int _id;
        private string _password; //changer en secure string plus tard
        private string _email;
        private string _pseudo;
        private string _photo;
        private bool tag;

        #endregion

        #region Constructor
        public User(int id, string password, string mail, string nom, bool tag = true)
        {
            _id = id;
            _password = password;
            _email = mail;
            this.tag = tag;
            //_pseudo = nom;
            //_photo = photo;
        }
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
        public string Email { get => _email; set => _email = value; }
        public string Pseudo { get => _pseudo; set => _pseudo = value; }

        [ManyToMany(typeof(Participer))]
        


        [OneToMany]
        public List<Participer> lesEncherirs { get; set; }
        public string Password { get => _password; set => _password = value; }
        public string Photo { get => _photo; set => _photo = value; }
        public bool Tag { get => tag; set => tag = value; }
        #endregion

        #region Methods
        //public User AjoutUser(string leMail, string leNom, string password)
        //{
        //    //ConvertPasswordToSecureString(mdp);
        //    this._id = 0;
        //    this._email = leMail;
        //    this._pseudo = leNom;
        //    //this._mesEncheres = new List<Enchere>();
        //    this._password = password;
        //    return this;
        //}
        /// <summary>
        /// Ne laisse pas le mdp sous forme de texte brut
        /// </summary>
        /// <param></param>
        /// <returns>
        /// 1- création d'un secure string
        /// 2- attribution caractère par caractère du password
        /// 3- on rend immuable le mdp (ne peut être modifié)
        /// </returns>
        //public static SecureString ConvertPasswordToSecureString(string password)
        //{
        //    var secureString = new SecureString();
        //    foreach (var c in password.ToCharArray())
        //    {
        //        secureString.AppendChar(c);
        //    }
        //    secureString.MakeReadOnly();
        //    return secureString;
        //}


        #endregion
    }
}
