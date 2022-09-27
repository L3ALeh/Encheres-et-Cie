using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.Modeles
{
    [Table("EnchereSurprise")]
    public class EnchereSurprise : Enchere
    {
        #region Attribut
        private double _tempsTour;
        private List<CaseSurprise> _lesCasesSurprises;
        #endregion

        #region Constructeur
        //public EnchereSurprise(double prixDeDepart, DateTime dateFin, double prixActuel, double prixReserve, char etat, DateTime dateDebut, double tempsTour) :
        //    base(prixDeDepart, dateFin, prixActuel, prixReserve, etat, dateDebut)
        //{
        //    CollClasse.Add(this);
        //    _tempsTour = tempsTour;
        //    _lesCasesSurprise = new List<CaseSurprise>();
        //}

        public double TempsTour { get => _tempsTour; set => _tempsTour = value; }

        [ForeignKey(typeof(CaseSurprise))]
        public int IdCaseSurprise { get; set; }

        [OneToMany(nameof(IdCaseSurprise))]
        public List<CaseSurprise> LesCasesSurprises { get => _lesCasesSurprises; set => _lesCasesSurprises = value; }
        #endregion

        #region Getter/setter
        #endregion

        #region Methode
        public EnchereSurprise AjoutEnchereSurprise(double prixActu, double prixRes, char etat, DateTime dateDeb, DateTime dateFin, double prixDep, double temps)
        {
            base.AjoutEnchere(prixActu, prixRes, etat, dateDeb, dateFin, prixDep);
            this._tempsTour = temps;
            this._lesCasesSurprises = new List<CaseSurprise>();
            return this;
        }
        #endregion


    }
}
