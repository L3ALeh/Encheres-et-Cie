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

        private ObservableCollection<Enchere> _maListeEncheresEnCours;
        private Enchere _maEnchere;

        #endregion

        #region Constructeur
        public EnchereTestVueModele()
        {
            this.GetEnchereTest("19");
            //appel de thread pour les 6 dernieres encheres
            //appel de thread pour rafrechir l'api
            LanceThread();
        }
        #endregion

        #region Getter/setter
        public ObservableCollection<Enchere> MaListeEncheresEnCoursTypeClassique
        {
            get { return _maListeEncheresEnCours; }
            set { SetProperty(ref _maListeEncheresEnCours, value); }
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

        //thread de rafraichisement de l'api et des 6 derniers

        public void LanceThread()
        {
            Task.Run(() =>
            {

                while (true)
                {
                    this.GetEnchereTest("19");
                    this.GetListeEnCheresEnCours(1);
                    Thread.Sleep(5);
                }
            });
        }

        //changer seulement le prix actuel
        public async void PostMiseTest(double mise, string param, int id )
        {

        }

        public async void miser(double montant)
        {
            if (montant > 0)
            {
                Participer participation = new Participer();
                participation.ajoutParticiper(montant, MaEnchere.Id);
                
            }
            
        }

        #endregion


    }
}
