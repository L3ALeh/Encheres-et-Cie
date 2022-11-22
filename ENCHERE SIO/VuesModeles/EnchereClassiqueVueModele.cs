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
    public class EnchereClassiqueVueModele : BaseVueModele
    {
        #region Attribut
        private readonly Api _apiServices = new Api();

        private ObservableCollection<Enchere> _maListeEncheresEnCoursTypeClassique;
        private Enchere _maEnchere;
        private ObservableCollection<Participer> _mes6Participations;
        public static User leUser;
        private int _valeurMax;
        #endregion

        #region Constructeur
        public EnchereClassiqueVueModele(Enchere currentEnchere)
        {
            LanceThread(currentEnchere.Id);
            GetEnchereTest("" + currentEnchere.Id);

        }
        #endregion

        #region Getter/setter
        public ObservableCollection<Enchere> MaListeEncheresEnCoursTypeClassique
        {
            get { return _maListeEncheresEnCoursTypeClassique; }
            set { SetProperty(ref _maListeEncheresEnCoursTypeClassique, value); }
        }

        public Enchere MaEnchere
        {
            get { return _maEnchere; }
            set { SetProperty(ref _maEnchere, value); }
        }

        public ObservableCollection<Participer> Mes6Participations
        {
            get { return _mes6Participations; }
            set { SetProperty(ref _mes6Participations, value); }
        }

        public int ValeurMax { get => _valeurMax; set => _valeurMax = value; }


        #endregion

        #region Methode


        public async void GetEnchereTest(string param)
        {
            MaEnchere = await _apiServices.GetOneAsyncID<Enchere>
                ("api/getEnchereTest", param);
            Enchere.CollClasse.Clear();

        }

        public async void PostEnchereTest(float param)
        {
            await _apiServices.PostAsync<Participer>(new Participer(param, leUser, MaEnchere, leUser.Pseudo), "api/postEncherir");
        }

        public async void get6derniersParticiper(int param)
        {
            Mes6Participations = await _apiServices.GetAllAsyncID<Participer>
                ("api/getLastSixOffer", Participer.CollClasse,"Id", param);
            Participer.CollClasse.Clear();
        }

        public void PostEnchereAuto(int valeurMax)
        {
            if(leUser != null && Mes6Participations != null)
            {
                if (Mes6Participations[0].PrixEnchere < valeurMax &&
                Mes6Participations[0].Pseudo != leUser.Pseudo)
                {
                   PostEnchereTest(Mes6Participations[0].PrixEnchere + 1);
                }
            }
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
                    this.PostEnchereAuto(ValeurMax);
                    this.GetUserById();
                    Thread.Sleep(5000);
                }
            });
        }
        #endregion


    }
}
