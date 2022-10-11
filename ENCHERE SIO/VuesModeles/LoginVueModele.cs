using ENCHERE_SIO.Modeles;
using ENCHERE_SIO.services;
using ENCHERE_SIO.Vues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.VuesModeles
{
    public class LoginVueModele:BaseVueModele
    {
        #region Attributes
        private readonly Api _apiServices = new Api();

        private User _unUser;
        #endregion

        #region Constructor
        public LoginVueModele()
        {
            this.GetUserByMailAndPass();
        }
        #endregion

        #region Getters/Setters
        public User UnUser 
        { 
            get { return _unUser; }
            set { SetProperty(ref _unUser, value); } 
        }
        #endregion

        #region Methods
        public async void GetUserByMailAndPass()
        {
            UnUser = new User(0,"", "");
            await _apiServices.GetOneAsync<User>("api/getUserByMailAndPass",UnUser);
            if(UnUser != null)
            {
                Application.Current.MainPage = new AccueilVue();
            }
        }
        #endregion
    }
}
