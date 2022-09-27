using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.Modeles
{
    public class EnchereClassique : Enchere
    {
        #region Attribut
        private double _montant;
        private List<EnchereClassique> _ListDernieresEnchere;
        #endregion

        #region getter/setter
        public double Montant { get => _montant; set => _montant = value; }
        public List<EnchereClassique> ListDernieresEnchere { get => _ListDernieresEnchere; set => _ListDernieresEnchere = value; }
        #endregion

        #region constructeur
        public EnchereClassique(double prixDeDepart, DateTime dateFin, double prixActuel, double prixReserve, char etat, DateTime dateDebut) :
            base(prixDeDepart, dateFin, prixActuel, prixReserve, etat, dateDebut)
        {
            _ListDernieresEnchere = new List<EnchereClassique>();
            _montant = 0;
        }
        #endregion

        #region methodes
        #endregion
    }
}
