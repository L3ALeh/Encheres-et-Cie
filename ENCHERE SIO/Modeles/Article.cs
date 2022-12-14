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
        private float _prixReel;
        private string _nom;
        private string _photo;
        private int _id;
        #endregion

        #region Constructeur
        public Article(float prixReel, string nom, string photo)
        {
            this._prixReel = prixReel;
            this._nom = nom;
            this._photo = photo;
        }
        #endregion

        #region Getter/setter
        public float PrixReel { get => _prixReel; set => _prixReel = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Photo { get => _photo; set => _photo = value; }

        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; set => _id = value; }

        [ForeignKey(typeof(Enchere))]
        public int IdEnchere { get; set; }

        [ForeignKey(typeof(Magasin))]
        public int IdMagasin { get; set; }

        #endregion

        #region Methode
        public Article AjoutArticle(float leMontant, string leNom, string url)
        {
            this._prixReel = leMontant;
            this._nom = leNom;
            this._photo = url;

            return this;
        }
        #endregion


    }
}
