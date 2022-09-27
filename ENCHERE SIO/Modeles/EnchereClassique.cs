using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.Modeles
{
    [Table("EnchereClassique")]
    public class EnchereClassique : Enchere
    {
        #region Attribut
        private double _montant;
        #endregion

        #region constructeur
        //public EnchereClassique(double prixDeDepart, DateTime dateFin, double prixActuel, double prixReserve, char etat, DateTime dateDebut) :
        //    base(prixDeDepart, dateFin, prixActuel, prixReserve, etat, dateDebut)
        //{
        //    _ListDernieresEnchere = new List<EnchereClassique>();
        //    _montant = 0;
        //}
        #endregion

        #region getter/setter
        public double Montant { get => _montant; set => _montant = value; }
        #endregion

        #region methodes
        public EnchereClassique AjoutEnchereClassique(double prixActu, double prixRes, char etat, DateTime dateDeb, DateTime dateFin, double prixDep, double leMontant)
        {
            base.AjoutEnchere(prixActu, prixRes, etat, dateDeb, dateFin, prixDep);
            this._montant= leMontant;
            return this;
        }
        #endregion
    }
}
