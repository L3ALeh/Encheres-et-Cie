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
    public class EnchereTestVueModele : BaseVueModele
    {
        #region Attribut
        private readonly Api _apiServices = new Api();

        private ObservableCollection<Enchere> _maListeEncheresEnCoursTypeClassique;
        private Enchere _maEnchere;

        #endregion

        #region Constructeur
        public EnchereTestVueModele()
        {
            LanceThread();
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
            await _apiServices.PostAsync<Participer>(new Participer(param, 1, MaEnchere.Id, 0, ""), "api/postEncherir");
        }

        public async void get6derniersParticiper(int param)
        {
            await _apiServices
        }

        public void LanceThread()
        {
            Task.Run(() =>
            {

                while (true)
                {
                    this.GetEnchereTest("13");
                    this.GetListeEnCheresEnCours(1);
                    Thread.Sleep(5000);
                }
            });
        }
        #endregion


    }
}
