using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.Modeles
{
    [Table("Enchere")]
    public abstract class Enchere
    {
        #region Attribut
        private int _id;
        private double _prixDeDepart;
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private double _prixActuel;
        private double _prixReserve;
        private char _etat;
        private Article _unArticle;
        private List<User> _lesUsers;
        #endregion

        #region Constructeur
        //public Enchere(double prixDeDepart, DateTime dateFin, double prixActuel, double prixReserve, char etat, DateTime dateDebut)
        //{
        //    _prixDeDepart = prixDeDepart;
        //    _dateFin = dateFin;
        //    _prixActuel = prixActuel;
        //    _prixReserve = prixReserve;
        //    _etat = etat;
        //    _dateDebut = dateDebut;
        //}


        #endregion

        #region Getter/setter
        public double PrixDeDepart { get => _prixDeDepart; set => _prixDeDepart = value; }
        public DateTime DateDebut { get => _dateDebut; set => _dateDebut = value; }
        public DateTime DateFin { get => _dateFin; set => _dateFin = value; }
        public double PrixActuel { get => _prixActuel; set => _prixActuel = value; }
        public double PrixReserve { get => _prixReserve; set => _prixReserve = value; }
        public char Etat { get => _etat; set => _etat = value; }

        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; set => _id = value; }

        [ForeignKey(typeof(Article))]
        public int IdArticle { get; set; }

        [OneToOne(nameof(IdArticle))]
        public Article UnArticle { get => _unArticle; set => _unArticle = value; }

        [ManyToMany(typeof(Participer))]
        public List<User> LesUsers { get => _lesUsers; set => _lesUsers = value; }
        #endregion

        #region Methode
        public virtual Enchere AjoutEnchere(double prixActu, double prixRes, char etat, DateTime dateDeb, DateTime dateFin, double prixDep)
        {
            this._id = 0;
            this._prixActuel=prixActu;
            this._prixReserve = prixRes;
            this._etat=etat;
            this._dateDebut=dateDeb;
            this._dateFin=dateFin;
            this._prixDeDepart=prixDep;
            this._lesUsers=new List<User>();

            return this;
        }
        #endregion


    }
}
