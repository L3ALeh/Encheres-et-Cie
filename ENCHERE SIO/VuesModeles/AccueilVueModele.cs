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
    public class AccueilVueModele:BaseVueModele
    {
        #region Attributes
        private readonly Api _apiServices = new Api();
        private ObservableCollection<Enchere> _mesEncheres;
        #endregion

        #region Constructor
        public AccueilVueModele()
        {
            _mesEncheres = new ObservableCollection<Enchere>();
            this.GetEncheresEnCours();
        }
        #endregion

        #region Getters/Setters
        public ObservableCollection<Enchere> MesEncheres 
        {
            get
            {
                return _mesEncheres;
            }
            set
            {
                SetProperty(ref _mesEncheres, value);
            }
        }

        #endregion

        #region Methods
        public async void GetEncheresEnCours()
        {
            MesEncheres = await _apiServices.GetAllAsync<Enchere>
                ("api/GetEncheresEnCours", Enchere.CollClasse);
            Enchere.CollClasse.Clear();
        }
        #endregion
    }
}
