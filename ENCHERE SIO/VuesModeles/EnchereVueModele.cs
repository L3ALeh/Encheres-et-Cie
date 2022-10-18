using ENCHERE_SIO.Modeles;
using ENCHERE_SIO.services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.VuesModeles
{
    public class EnchereVueModele:BaseVueModele
    {
        #region Attributes
        private readonly Api _apiServices = new Api();
        private Enchere _uneEnchere;
        #endregion

        #region Constructor
        public EnchereVueModele(Enchere currentEnchere)
        {
            this.GetEnchereChoisie(""+currentEnchere.Id);
        }
        #endregion

        #region Getters/Setters
        public Enchere UneEnchere
        {
            get
            {
                return _uneEnchere;
            }
            set
            {
                SetProperty(ref _uneEnchere, value);
            }
        }
        #endregion

        #region Methods
        public async void GetEnchereChoisie(string id)
        {
            UneEnchere = await _apiServices.GetOneAsyncID<Enchere>
                ("api/getEnchere", id);
        }
        #endregion
    }
}
