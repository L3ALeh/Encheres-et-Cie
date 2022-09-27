using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.Modeles
{
    public class CaseSurprise
    {
        #region Attribut
        public static List<CaseSurprise> CollClasse = new List<CaseSurprise>();
        private int _id;
        private double _valeur;
        #endregion

        #region Constructeur
        public CaseSurprise(double valeur)
        {
            CollClasse.Add(this);
            _id = CollClasse.Count()+1;
            _valeur = valeur;
        }


        #endregion

        #region Getter/setter
        public int Id { get => _id; set => _id = value; }
        public double Valeur { get => _valeur; set => _valeur = value; }
        #endregion

        #region Methode
        #endregion


    }
}
