using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.Modeles
{
    public class Participer
    {
        #region Attributes
        #endregion

        #region Constructor
        #endregion

        #region Getters/Setters
        [ForeignKey(typeof(User))]
        public int IdUser { get; set; }
        [ForeignKey(typeof(Enchere))]
        public int IdEnchere { get; set; }
        #endregion

        #region Methods
        #endregion

    }
}
