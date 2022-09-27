using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.Modeles
{
    [Table("Article")]
    public class Article
    {
        #region Attribut
        private double _montant;
        private string _nom;
        private string _photoURL;
        private int _id;
        #endregion

        #region Constructeur
        //public Article(double montant, string nom, string photoURL)
        //{
        //    _montant = montant;
        //    _nom = nom;
        //    _photoURL = photoURL;
        //}
        #endregion

        #region Getter/setter
        public double Montant { get => _montant; set => _montant = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string PhotoURL { get => _photoURL; set => _photoURL = value; }
        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; }
        #endregion

        #region Methode
        #endregion


    }
}
