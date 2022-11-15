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
    public class ListeEnchereInverseeVueModele:BaseVueModele
    {
        #region Attributes
        private readonly Api _apiServices = new Api();
        private ObservableCollection<Enchere> _mesEncheres;
        #endregion

        #region Constructor
        public ListeEnchereInverseeVueModele()
        {
            _mesEncheres = new ObservableCollection<Enchere>();
            this.GetEncheresInverseesEnCours(1);
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
        public async void GetEncheresInverseesEnCours(int id)
        {
            MesEncheres = await _apiServices.GetAllAsyncID<Enchere>
                ("api/getEncheresEnCours", Enchere.CollClasse, "IdTypeEnchere", id);
            Enchere.CollClasse.Clear();
        }

        #endregion
    }
}
