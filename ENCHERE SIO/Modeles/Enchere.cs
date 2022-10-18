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
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private Magasin _leMagasin;
        private double _prixDepart;
        private double _prixReserve;
        private double _prixActuel;
        private char _etat;
        private double _tempsTour;
        private Article _leProduit;
        private TypeEnchere _leTypeEnchere;
        private List<User> _playerFlashes;
        private List<CaseSurprise> _tableauFlash;



        #endregion

        #region Constructeur
        public Enchere(double prixDep, double prixRes,  DateTime dateDeb, DateTime dateFin, TypeEnchere typeEnchere, Article monArticle,Magasin lemagasin)
        {
            this.AjoutEnchere(prixDep,prixRes,dateDeb,dateFin,typeEnchere,monArticle,lemagasin);
        }


        #endregion

        #region Getter/setter
        public DateTime DateDebut { get => _dateDebut; set => _dateDebut = value; }
        public DateTime DateFin { get => _dateFin; set => _dateFin = value; }
        public double PrixDepart { get => _prixDepart; set => _prixDepart = value; }
        public double PrixReserve { get => _prixReserve; set => _prixReserve = value; }
        public char Etat { get => _etat; set => _etat = value; }

        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; set => _id = value; }

        [ForeignKey(typeof(Article))]
        public int IdProduit { get; set; }

        [OneToOne(nameof(IdProduit))]
        public Article LeProduit { get => _leProduit; set => _leProduit = value; }

        [ManyToMany(typeof(Participer))]
        public List<User> LesUsers { get => _playerFlashes; set => _playerFlashes = value; }

        [OneToMany]
        public List<Participer> lesParticipations { get; set; }
        public double TempsTour { get => _tempsTour; set => _tempsTour = value; }
        public List<CaseSurprise> LesCasesSurprises { get => _tableauFlash; set => _tableauFlash = value; }
        public TypeEnchere TypeEnchere { get => _leTypeEnchere; set => _leTypeEnchere = value; }
        public double PrixActuel { get => _prixActuel; set => _prixActuel = value; }
        public Magasin LeMagasin { get => _leMagasin; set => _leMagasin = value; }
        #endregion

        #region Methode
        public virtual Enchere AjoutEnchere(double prixDep, double prixReserve,  DateTime dateDebut, DateTime dateFin, TypeEnchere typeEnchere, Article monArticle, Magasin lemagasin)
        {
            this._prixDepart = prixDep;
            this._prixReserve = prixReserve;
            this._dateDebut=dateDebut;
            this._dateFin=dateFin;
            this._playerFlashes = new List<User>();
            this.lesParticipations = new List<Participer>();
            Enchere.CollClasse.Add(this);
            this._leTypeEnchere = typeEnchere;
            this._leProduit = monArticle;
            this._leMagasin = lemagasin;

            
            

            return this;
        }

        public void GetForeignKey()
        {
            this.IdProduit = _leProduit.Id;
        }
        #endregion


    }
}
