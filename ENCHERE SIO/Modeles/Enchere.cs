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
        private double _prixActuel;
        private double _prixReserve;
        private char _etat;
        private double _tempsTour;
        private Article _leProduit;
        private TypeEnchere _leTypeEnchere;

        private List<User> _lesUsers;
        private List<CaseSurprise> _lesCasesSurprises;





        #endregion

        #region Constructeur
        public Enchere(double prixActu, double prixRes,  DateTime dateDeb, DateTime dateFin, TypeEnchere typeEnchere, Article monArticle)
        {
            this.AjoutEnchere(prixActu,prixRes,dateDeb,dateFin,typeEnchere,monArticle);
        }


        #endregion

        #region Getter/setter
        public DateTime DateDebut { get => _dateDebut; set => _dateDebut = value; }
        public DateTime DateFin { get => _dateFin; set => _dateFin = value; }
        public double PrixActuel { get => _prixActuel; set => _prixActuel = value; }
        public double PrixReserve { get => _prixReserve; set => _prixReserve = value; }
        public char Etat { get => _etat; set => _etat = value; }

        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; set => _id = value; }

        [ForeignKey(typeof(Article))]
        public int IdProduit { get; set; }

        [OneToOne(nameof(IdProduit))]
        public Article LeProduit { get => _leProduit; set => _leProduit = value; }

        [ManyToMany(typeof(Participer))]
        public List<User> LesUsers { get => _lesUsers; set => _lesUsers = value; }

        [OneToMany]
        public List<Participer> lesParticipations { get; set; }
        public double TempsTour { get => _tempsTour; set => _tempsTour = value; }
        public List<CaseSurprise> LesCasesSurprises { get => _lesCasesSurprises; set => _lesCasesSurprises = value; }
        public TypeEnchere TypeEchere { get => _leTypeEnchere; set => _leTypeEnchere = value; }
        #endregion

        #region Methode
        public virtual Enchere AjoutEnchere(double prixActu, double prixRes,  DateTime dateDeb, DateTime dateFin, TypeEnchere typeEnchere, Article monArticle)
        {
            this._prixActuel=prixActu;
            this._prixReserve = prixRes;
            this._dateDebut=dateDeb;
            this._dateFin=dateFin;
            this._lesUsers=new List<User>();
            this.lesParticipations = new List<Participer>();
            Enchere.CollClasse.Add(this);
            this._leTypeEnchere = typeEnchere;
            this._leProduit = monArticle;
            
            

            return this;
        }

        public void GetForeignKey()
        {
            this.IdProduit = _leProduit.Id;
        }
        #endregion


    }
}
