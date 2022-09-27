using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.Modeles
{
    [Table("CaseSurprise")]
    public class CaseSurprise
    {
        #region Attribut
        private int _id;
        private double _valeur;
        #endregion

        #region Constructeur
        //public CaseSurprise(double valeur)
        //{
        //    _valeur = valeur;
        //}


        #endregion

        #region Getter/setter
        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; set => _id = value; }
        public double Valeur { get => _valeur; set => _valeur = value; }
        [ForeignKey(typeof(EnchereSurprise))]
        public int EnchereSurpriseId { get; set; }
        #endregion

        #region Methode
        #endregion


    }
}
