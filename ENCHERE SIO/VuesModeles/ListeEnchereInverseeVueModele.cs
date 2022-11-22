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
    public class ListeEnchereInverseeVueModele : BaseVueModele
    {
        #region Attribut
        private readonly Api _apiServices = new Api();
        private ObservableCollection<Enchere> _mesEncheres;
        #endregion

        #region Constructeur
        public ListeEnchereInverseeVueModele()
        {
            _mesEncheres = new ObservableCollection<Enchere>();
            this.GetEnchereInverseesEnCours(2);
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
        //plus tard rajouter les enchères pas encore commencées en fonction de la date de départ avec un compte à rebours
        //avant que ça commence

        public async void GetEnchereInverseesEnCours(int id)
        {
            MesEncheres = await _apiServices.GetAllAsyncID<Enchere>
                ("api/getEncheresEnCours", Enchere.CollClasse, "IdTypeEnchere", id);
            Enchere.CollClasse.Clear();
        }
        #endregion
    }
}
