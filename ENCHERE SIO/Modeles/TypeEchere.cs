using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.Modeles
{
    [Table("TpeEnchere")]
    public class TypeEnchere
    {

        #region Attribut
        private int _id;
        private string _nom;
        #endregion

        #region Constructeur
        public TypeEnchere()
        {
            
        }


        #endregion

        #region Getter/setter
        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        #endregion

        #region Methode
        #endregion


    }
}
