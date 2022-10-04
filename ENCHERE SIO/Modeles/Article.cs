using SQLite;
using SQLiteNetExtensions.Attributes;
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
        private Enchere _uneEnchere;
        private Magasin _unMagasin;
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

        [ForeignKey(typeof(Enchere))]
        public int IdEnchere { get; set; }

        [ForeignKey(typeof(Magasin))]
        public int IdMagasin { get; set; }

        [OneToOne(nameof(IdEnchere))]
        public Enchere UneEnchere { get => _uneEnchere; set => _uneEnchere = value; }

        [ManyToOne(nameof(IdMagasin))]
        public Magasin UnMagasin { get => _unMagasin; set => _unMagasin = value; }
        #endregion

        #region Methode
        public Article AjoutArticle(double leMontant, string leNom, string url, Magasin magasin)
        {
            this._montant = leMontant;
            this._id = 0;
            this._nom = leNom;
            this._photoURL = url;
            this._unMagasin = magasin;
            return this;
        }
        #endregion


    }
}
