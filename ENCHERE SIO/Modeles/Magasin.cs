using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.Modeles
{
    [Table("Magasin")]
    public class Magasin
    {
        #region Attribut
        private double _lattitude;
        private double _longitude;
        private string _nom;
        private int _id;
        private string _adresse;
        private string _ville;
        private int _codePostal;
        private int _telephone;
        private List<Article> _lesArticles;
        #endregion

        #region Constructeur
        //public Magasin(double lattitude, double longitude, string nomMagasin)
        //{
        //    _lattitude = lattitude;
        //    _longitude = longitude;
        //    _nomMagasin = nomMagasin;   
        //}

        #endregion

        #region Getter/setter
        public double Lattitude { get => _lattitude; set => _lattitude = value; }
        public double Longitude { get => _longitude; set => _longitude = value; }
        public string Nom { get => _nom; set => _nom = value; }
        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; set => _id = value; }
        [ForeignKey(typeof(Article))]
        public int IdArticle { get; set; }

        [OneToMany(nameof(IdArticle))]
        public List<Article> LesArticles { get => _lesArticles; set => _lesArticles = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public string Ville { get => _ville; set => _ville = value; }
        public int CodePostal { get => _codePostal; set => _codePostal = value; }
        public int Telephone { get => _telephone; set => _telephone = value; }

        #endregion

        #region Methode
        public Magasin AjoutMagasin(double lattitude, double longitude, string nom, string adresse, string ville, int codePostal, int Telephone)
        {
            this._lattitude = lattitude;
            this._longitude = longitude;
            this._nom = nom;
            this._adresse = adresse;
            this._ville = ville;
            this._codePostal = codePostal;
            this._telephone = Telephone;
            this.LesArticles= new List<Article>();
            return this;
        }
        #endregion


    }
}
