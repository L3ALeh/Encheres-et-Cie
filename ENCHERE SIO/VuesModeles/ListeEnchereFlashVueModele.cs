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
    public class ListeEnchereFlashVueModele : BaseVueModele
    {
        #region Attributs
        private readonly Api _apiServices = new Api();
        private ObservableCollection<Enchere> _mesEncheres;
        #endregion

        #region Constructeur
        public ListeEnchereFlashVueModele()
        {
            _mesEncheres = new ObservableCollection<Enchere>();
            this.GetEncheresFlashEnCours(3);
        }
        #endregion

        #region getter/setter
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

        #region Methodes
        public async void GetEncheresFlashEnCours(int id)
        {
            MesEncheres = await _apiServices.GetAllAsyncID<Enchere>
               ("api/getEncheresEnCours", Enchere.CollClasse, "IdTypeEnchere", id);
            Enchere.CollClasse.Clear();
        }
        #endregion
    }
}
