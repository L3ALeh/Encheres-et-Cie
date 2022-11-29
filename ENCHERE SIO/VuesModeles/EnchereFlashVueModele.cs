using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENCHERE_SIO.Modeles;

namespace ENCHERE_SIO.VuesModeles
{
    public class EnchereFlashVueModele:BaseVueModele
    {
        #region Attributes
        private Enchere _maEnchere;
        #endregion

        #region Constructor
        public EnchereFlashVueModele(Enchere currentEnchere)
        {

        }
        #endregion

        #region Getters/Setters
        public Enchere MaEnchere
        {
            get { return _maEnchere; }
            set { SetProperty(ref _maEnchere, value); }
        }
        #endregion

        #region Methods
        #endregion
    }
}
