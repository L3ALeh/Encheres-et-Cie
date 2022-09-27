using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.Modeles
{
    public class Enchereinversés : Enchere
    {
        #region Attribut
        public static List<Enchereinversés> CollClasse = new List<Enchereinversés>();
        #endregion

        #region Constructeur
        public Enchereinversés(double prixDeDepart, DateTime dateFin, double prixActuel, double prixReserve, char etat, DateTime dateDebut) :
            base(prixDeDepart, dateFin, prixActuel, prixReserve, etat, dateDebut)
        {
            CollClasse.Add(this);
        }
        #endregion

        #region Getter/setter
        #endregion

        #region Methode
        #endregion


    }
}
