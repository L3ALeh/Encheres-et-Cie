using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.Modeles
{
    public class User
    {
        #region Attributes
        public static List<User> CollClass = new List<User>();
        private int _id;
        private string _password;
        private string _mail;
        private string _nom;
        private string _prenom;
        #endregion

        #region Constructor
        public User(string mail, string nom, string prenom, string password)
        {
            User.CollClass.Add(this);
            _id = User.CollClass.Count() + 1;
            _mail = mail;
            _nom = nom;
            _prenom = prenom;
            _password = password;
        }
        #endregion

        #region Getters/Setters
        public int Id { get { return _id; } }   
        public string Mail { get => _mail; set => _mail = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        #endregion

        #region Methods
        #endregion
    }
}
