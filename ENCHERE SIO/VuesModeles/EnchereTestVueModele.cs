﻿//using ENCHERE_SIO.Modeles;
//using ENCHERE_SIO.services;
//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ENCHERE_SIO.VuesModeles
//{
    //public class EnchereTestVueModele : BaseVueModele
    //{
    //    #region Attribut
    //    private readonly Api _apiServices = new Api();

    //    private ObservableCollection<EnchereClassique> _maListeEncheresEnCoursTypeClassique;
    //    private EnchereClassique _maEnchere;

    //    #endregion

        #region Constructeur
        public EnchereTestVueModele()
        {
            this.GetEnchereTest("19");
        }
        #endregion

    //    #region Getter/setter
    //    public ObservableCollection<EnchereClassique> MaListeEncheresEnCoursTypeClassique
    //    {
    //        get { return _maListeEncheresEnCoursTypeClassique; }
    //        set { SetProperty(ref _maListeEncheresEnCoursTypeClassique, value); }
    //    }

    //    public EnchereClassique MaEnchere
    //    {
    //        get { return _maEnchere; }
    //        set { SetProperty(ref _maEnchere, value); }
    //    }
    //    #endregion

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
        #endregion


//    }
//}
