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
    public class LoginVueModele:BaseVueModele
    {
        #region Attributes
        private readonly Api _apiServices = new Api();
        private ObservableCollection<User> _maListeUser;
        private User _monUser;
        #endregion

        #region Constructor
        public LoginVueModele()
        {
            
        }
        #endregion

        #region Getters/Setters
        public ObservableCollection<User> MaListeUser
        {
            get { return _maListeUser; }
            set { SetProperty(ref _maListeUser, value); }
        }
        public User MonUser
        {
            get { return _monUser; }
            set { SetProperty(ref _monUser, value); }
        }
        #endregion

        #region Methods
        public async void getUsername()
        {
            User u1 = new User();
            MonUser = await _apiServices.GetOneAsync<User>("api/GetUserByMailAndPass", u1);
        }
        #endregion
    }
}
