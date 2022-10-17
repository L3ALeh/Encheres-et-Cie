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
        private char _etat;
        private double _montant;
        private double _tempsTour;
        private Article _unArticle;
        private TypeEnchere _typeEnchere;

        private List<User> _lesUsers;
        private List<CaseSurprise> _lesCasesSurprises;

        
      


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

        [OneToMany]
        public List<Participer> lesParticipations { get; set; }
        public double Montant { get => _montant; set => _montant = value; }
        public double TempsTour { get => _tempsTour; set => _tempsTour = value; }
        public List<CaseSurprise> LesCasesSurprises { get => _lesCasesSurprises; set => _lesCasesSurprises = value; }
        public TypeEnchere TypeEchere { get => _typeEnchere; set => _typeEnchere = value; }
        #endregion

        #region Methode
        public virtual Enchere AjoutEnchereClassique(double prixActu, double prixRes, char etat, DateTime dateDeb, DateTime dateFin, double prixDep, double montant, TypeEnchere typeEnchere)
        {
            this._prixActuel=prixActu;
            this._prixReserve = prixRes;
            this._etat=etat;
            this._dateDebut=dateDeb;
            this._dateFin=dateFin;
            this._prixDeDepart=prixDep;
            this._montant = montant;
            this._lesUsers=new List<User>();
            this.lesParticipations = new List<Participer>();
            this._typeEnchere = typeEnchere;
            

            return this;
        }

        public virtual Enchere AjoutEnchereInversée(double prixActu, double prixRes, char etat, DateTime dateDeb, DateTime dateFin, double prixDep, TypeEnchere typeEnchere)
        {
            this._prixActuel = prixActu;
            this._prixReserve = prixRes;
            this._etat = etat;
            this._dateDebut = dateDeb;
            this._dateFin = dateFin;
            this._prixDeDepart = prixDep;
            this._lesUsers = new List<User>();
            this.lesParticipations = new List<Participer>();
            this._typeEnchere = typeEnchere;
            return this;
        }

        public virtual Enchere AjoutEnchereSurprise(double prixActu, double prixRes, char etat, DateTime dateDeb, DateTime dateFin, double prixDep, double tempsTour, TypeEnchere typeEnchere)
        {
            
            this._prixActuel = prixActu;
            this._prixReserve = prixRes;
            this._etat = etat;
            this._dateDebut = dateDeb;
            this._dateFin = dateFin;
            this._prixDeDepart = prixDep;
            this._tempsTour = tempsTour;
            this._lesUsers = new List<User>();
            this._lesCasesSurprises = new List<CaseSurprise>();
            this._typeEnchere = typeEnchere;
            return this;
        }
        #endregion


    }
}
