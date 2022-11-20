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
    public class EnchereInverseeVueModele
    {
        #region Attribut
        private readonly Api _apiServices = new Api();

        private ObservableCollection<Enchere> _maListEnchereEncheresEncoursTypeInversee;
        private Enchere _maEnchere;
        private ObservableCollection<Participer> _mes6Participations;
        public static User leUser;
        
       
        #endregion

        #region Constructeur
        public EnchereInverseeVueModele(Enchere currentEnchere)
        {

        }
        #endregion

        #region getter/setter
        public ObservableCollection<Enchere> MaListEnchereEncheresEncoursTypeInversee { get => _maListEnchereEncheresEncoursTypeInversee; set => _maListEnchereEncheresEncoursTypeInversee = value; }
        public Enchere MaEnchere { get => _maEnchere; set => _maEnchere = value; }
        public ObservableCollection<Participer> Mes6Participations { get => _mes6Participations; set => _mes6Participations = value; }

        #endregion

        #region 
        public async void GetEnchereTest(string param)
        {
            MaEnchere = await _apiServices.GetOneAsyncID<Enchere>
               ("api/getEnchereTest", param);
            Enchere.CollClasse.Clear();
        }

        public async void PostEnchereTest(float param)
        {
            if(param > MaEnchere.PrixReserve && param < Mes6Participations[0].PrixEnchere)
            {
                await _apiServices.PostAsync<Participer>
                    (new Participer(param, leUser, MaEnchere, leUser.Pseudo),
                    "api/postEncherirInverse");
            }
        }

        public async void get6derniersParticiper(int param)
        {
            Mes6Participations = await _apiServices.GetAllAsyncID<Participer>
                ("api/getLastSixOffer", Participer.CollClasse, "Id", param);
            Participer.CollClasse.Clear();
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



        public void LanceThread(int param)
        {
            Task.Run(() =>
            {
                while (true)
                {
                    this.get6derniersParticiper(param);
                    this.GetUserById();
                    Thread.Sleep(5000);
                }
            });
        }
        #endregion
    }
}
