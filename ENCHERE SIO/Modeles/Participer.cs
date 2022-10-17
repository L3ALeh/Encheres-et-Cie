namespace ENCHERE_SIO.Modeles
{

    public class Participer
    {
        #region Attributes
        private int _id;
        private int _mise;
        private int _existeDeja;
        private DateTime _date;
        private string _pseudo;
        private int _idUser;
        private int _idEnchere;

        #endregion

        #region Constructor
        public Participer(int mise, int idUser, int idEnchere, int existeDeja, string pseudo)
        {
            this._mise = mise;
            this._idUser = idUser;
            this._idEnchere = idEnchere;
            this._existeDeja = existeDeja;
            this._pseudo = pseudo;
            this._date = DateTime.Now;
        }
        #endregion

        #region Getters/Setters

        public int IdUser { get => _idUser; set => _idUser = value; }
        public int IdEnchere { get => _idEnchere; set => _idEnchere = value; }
        public int Id { get => _id; set => _id = value; }
        public int Mise { get => _mise; set => _mise = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public int ExisteDeja { get => _existeDeja; set => _existeDeja = value; }
        public string Pseudo { get => _pseudo; set => _pseudo = value; }
        #endregion

        #region Methods

        public void AjouterParticiper(int mise, int idEnchere)
        {
            this._mise = mise;
            this.IdEnchere = idEnchere;
            this._date = DateTime.Now;
        }

        #endregion

    }
}