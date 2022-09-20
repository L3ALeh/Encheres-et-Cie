using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.Modeles
{
    public class Article
    {
        #region Attribut
        public static List<Article> CollClasse = new List<Article>();
        private double _montant;
        private string _nom;
        private string _photoURL;
        private int _id;
        #endregion

        #region Constructeur
        public Article(double montant, string nom, string photoURL)
        {
            CollClasse.Add(this);
            _montant = montant;
            _nom = nom;
            _photoURL = photoURL;
            _id = CollClasse.Count() + 1;
        }
        #endregion

        #region Getter/setter
        public double Montant { get => _montant; set => _montant = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string PhotoURL { get => _photoURL; set => _photoURL = value; }
        public int Id { get => _id; }
        #endregion

        #region Methode
        #endregion


    }
}
