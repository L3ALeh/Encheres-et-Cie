﻿using ENCHERE_SIO.Modeles;
using ENCHERE_SIO.services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.VuesModeles
{
    public class EnchereTestVueModele : BaseVueModele
    {
        #region Attribut
        private readonly Api _apiServices = new Api();

        private ObservableCollection<Enchere> _maListeEncheresEnCoursTypeClassique;
        private Enchere _maEnchere;
        private ObservableCollection<Participer> _mes6Participations;
        public static User usertest = new User("Btssio2017", "eleloarer.ledantec@gmail.com", "le loarer", "ewen");

        #endregion

        #region Constructeur
        public EnchereTestVueModele()
        {
            LanceThread();
            GetEnchereTest("13");
            usertest.setid(300);
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
        #endregion

        #region Methode
        public async void GetListeEnCheresEnCours(int id)
        {
            MaListeEncheresEnCoursTypeClassique = await _apiServices.GetAllAsyncID<Enchere>
                ("api/getEncheresEnCours", Enchere.CollClasse, "IdTypeEnchere", id);
            Enchere.CollClasse.Clear();

        }

        public async void GetEnchereTest(string param)
        {
            MaEnchere = await _apiServices.GetOneAsyncID<Enchere>
                ("api/getEnchereTest", param);
            Enchere.CollClasse.Clear();

        }

        public async void PostEnchereTest(int param)
        {
            await _apiServices.PostAsync<Participer>(new Participer(param, usertest, MaEnchere, usertest.Prenom), "api/postEncherir");
        }

        public async void get6derniersParticiper(int param)
        {
            Mes6Participations = await _apiServices.GetAllAsyncID<Participer>
                ("api/getLastSixOffer", Participer.CollClasse,"Id", param);
            Participer.CollClasse.Clear();
        }

        public void LanceThread()
        {
            Task.Run(() =>
            {

                while (true)
                {
                    this.GetListeEnCheresEnCours(1);
                    this.get6derniersParticiper(13);
                    Thread.Sleep(5000);
                }
            });
        }
        #endregion


    }
}
