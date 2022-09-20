using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.Modeles
{
    public class Enchere
    {
        #region Attribut
        public static List<Enchere> CollClasse = new List<Enchere>();
        private int _id;
        private double _prixDeDepart;
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private double _prixActuel;
        private double _prixReserve;
        private char _Etat;
        #endregion

        #region Constructeur
        public Enchere(double prixDeDepart, DateTime dateFin, double prixActuel, double prixReserve, char etat, DateTime dateDebut)
        {
            CollClasse.Add(this);
            _prixDeDepart = prixDeDepart;
            _dateFin = dateFin;
            _prixActuel = prixActuel;
            _prixReserve = prixReserve;
            _Etat = etat;
            _dateDebut = dateDebut;
            _id = CollClasse.Count() + 1;
        }


        #endregion

        #region Getter/setter
        public double PrixDeDepart { get => _prixDeDepart; set => _prixDeDepart = value; }
        public DateTime DateDebut { get => _dateDebut; set => _dateDebut = value; }
        public DateTime DateFin { get => _dateFin; set => _dateFin = value; }
        public double PrixActuel { get => _prixActuel; set => _prixActuel = value; }
        public double PrixReserve { get => _prixReserve; set => _prixReserve = value; }
        public char Etat { get => _Etat; set => _Etat = value; }
        public int Id { get => _id; set => _id = value; }
        #endregion

        #region Methode
        #endregion


    }
}
