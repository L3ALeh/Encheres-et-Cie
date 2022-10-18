using SQLite;
using System.ComponentModel.DataAnnotations.Schema;
using TableAttribute = SQLite.TableAttribute;

namespace ENCHERE_SIO.Modeles
{
    [Table("Participer")]
    public class Participer
    {
        #region Attributes
        private int _id;
        private float _prixEnchere;
        private int _existeDeja;
        private DateTime _dateenchere;
        private string _pseudo;
        private User _leUser;
        private Enchere _laenchere;
        public static List<Participer> CollClasse = new List<Participer>();

        #endregion

        #region Constructor
        public Participer(float prixEnchere, User leuser, Enchere laenchere, string pseudo)
        {
            this._prixEnchere = prixEnchere;
            this._leUser = leuser;
            this._laenchere = laenchere;
            this._existeDeja = 0;
            this._pseudo = pseudo;
            this._dateenchere = DateTime.Now;
            CollClasse.Add(this);
        }
        #endregion

        #region Getters/Setters

        [ForeignKey(nameof(User))]
        public int IdUser { get => _leUser.Id; }
        [ForeignKey(nameof(Enchere))]
        public int IdEnchere { get => _laenchere.Id; }

        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; set => _id = value; }
        public float PrixEnchere { get => _prixEnchere; set => _prixEnchere = value; }
        public DateTime Date { get => _dateenchere; set => _dateenchere = value; }
        public int ExisteDeja { get => _existeDeja; set => _existeDeja = value; }
        public string Pseudo { get => _pseudo; set => _pseudo = value; }
        #endregion

        #region Methods

        public void AjouterParticiper(int mise, int idEnchere)
        {
            //this._mise = mise;
            //this.IdEnchere = idEnchere;
            //this._date = DateTime.Now;
        }

        #endregion

    }
}