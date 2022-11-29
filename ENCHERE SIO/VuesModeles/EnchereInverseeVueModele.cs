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
    public class EnchereInverseeVueModele : BaseVueModele
    {
        #region Attribut
        private readonly Api _apiServices = new Api();
        private Enchere _maEnchere;
        public static User leUser;
        private Participer _participation;


        #endregion

        #region Constructeur
        public EnchereInverseeVueModele(Enchere currentEnchere)
        {
            LanceThread(""+currentEnchere.Id);
            GetEnchereTest("" + currentEnchere.Id);
        }
        #endregion

        #region getter/setter
        public Enchere MaEnchere
        {
            get { return _maEnchere; }
            set { SetProperty(ref _maEnchere, value); }
        }
        public Participer Participation
        {
            get { return _participation; }
            set { SetProperty(ref _participation, value); }
        }

        #endregion

        #region Methodes
        public async void GetEnchereTest(string param)
        {
            MaEnchere = await _apiServices.GetOneAsyncID<Enchere>
               ("api/getEnchereTest", param);
            Enchere.CollClasse.Clear();
        }

        public async void GetUserById()
        {
            string oauthToken = await SecureStorage.Default.GetAsync("session");

            if(oauthToken != null)
            {
                leUser = await _apiServices.GetOneAsyncID<User>
                    ("api/getUser", oauthToken);
                Enchere.CollClasse.Clear();
            }
        }

        public void LanceThread(string param)
        {
            Task.Run(() =>
            {
                while (true)
                {
                    this.GetUserById();
                    Thread.Sleep(5000);
                }
            });
        }
        #endregion
    }
}
