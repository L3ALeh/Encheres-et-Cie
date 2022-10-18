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
        private string _nomMagasin;
        private int _id;
        private string _adresse;
        private string _ville;
        private int _codePostal;
        private int _portable;
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
        public string NomMagasin { get => _nomMagasin; set => _nomMagasin = value; }
        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; }
        [ForeignKey(typeof(Article))]
        public int IdArticle { get; set; }

        [OneToMany(nameof(IdArticle))]
        public List<Article> LesArticles { get => _lesArticles; set => _lesArticles = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public string Ville { get => _ville; set => _ville = value; }
        public int CodePostal { get => _codePostal; set => _codePostal = value; }
        public int Portable { get => _portable; set => _portable = value; }

        #endregion

        #region Methode
        public Magasin AjoutMagasin(double latt, double longi, string magasin)
        {
            this._lattitude = latt;
            this._longitude = longi;
            this._nomMagasin = magasin;
            this._id = 0;
            this.LesArticles= new List<Article>();
            return this;
        }
        #endregion


    }
}
