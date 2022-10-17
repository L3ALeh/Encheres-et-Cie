using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.Modeles
{
    [Table("Participer")]
    public class Participer
    {
        #region Attributes
        private int _id;
        private int _mise;
        private DateTime _date;
        #endregion

        #region Constructor
        #endregion

        #region Getters/Setters
        [ForeignKey(typeof(User))]
        public int IdUser { get; set; }

        [ManyToOne(nameof(IdUser))]
        public User leUser { get; set; }

        [ForeignKey(typeof(Enchere))]
        public int IdEnchere { get; set; }

        [ManyToOne(nameof(IdEnchere))]
        public Enchere laEnchere { get; set; }

        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; set => _id = value; }


        public int Mise { get => _mise; set => _mise = value; }
        public DateTime Date { get => _date; set => _date = value; }
        #endregion

        #region Methods
        #endregion

    }
}
