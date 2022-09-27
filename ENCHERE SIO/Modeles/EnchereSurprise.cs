using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.Modeles
{
    public class EnchereSurprise : Enchere
    {
        #region Attribut
        public static List<EnchereSurprise> CollClasse = new List<EnchereSurprise>();
        private double _tempsTour;
        private List<CaseSurprise> _lesCasesSurprise;
        #endregion

        #region Constructeur
        public EnchereSurprise(double prixDeDepart, DateTime dateFin, double prixActuel, double prixReserve, char etat, DateTime dateDebut, double tempsTour) :
            base(prixDeDepart, dateFin, prixActuel, prixReserve, etat, dateDebut)
        {
            CollClasse.Add(this);
            _tempsTour = tempsTour;
            _lesCasesSurprise = new List<CaseSurprise>();
        }

        public double TempsTour { get => _tempsTour; set => _tempsTour = value; }
        public List<CaseSurprise> LesCasesSurprise { get => _lesCasesSurprise; set => _lesCasesSurprise = value; }
        #endregion

        #region Getter/setter
        #endregion

        #region Methode
        #endregion


    }
}
