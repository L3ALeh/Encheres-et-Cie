using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.Modeles
{
    [Table("EnchereInversée")]
    public class EnchereInversée : Enchere
    {
        #region Attribut
        private Dictionary<User, int> _anciennesMises;
        #endregion

        #region Constructeur
        //public Enchereinversés(double prixDeDepart, DateTime dateFin, double prixActuel, double prixReserve, char etat, DateTime dateDebut) :
        //    base(prixDeDepart, dateFin, prixActuel, prixReserve, etat, dateDebut)
        //{
        //    CollClasse.Add(this);

        //}
        #endregion

        #region Getter/setter
        public Dictionary<User, int> AnciennesMises { get => _anciennesMises; set => _anciennesMises = value; }
        #endregion

        #region Methode
        public EnchereInversée AjoutEnchereInversee(double prixActu, double prixRes, char etat, DateTime dateDeb, DateTime dateFin, double prixDep)
        {
            base.AjoutEnchere(prixActu, prixRes, etat, dateDeb, dateFin, prixDep);
            this._anciennesMises = new Dictionary<User, int>();
            return this;
        }
        #endregion


    }
}
